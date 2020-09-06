using MetroFramework.Components;
using sindex.utils;
using sindex.repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sindex.forms
{
    public partial class frmDatabases : Form
    {
        string path;
        string [] arquivos;
        private object dbConnect;
        Configuration conf;
        frmMain main;
        bool login;

        public frmDatabases(MetroStyleManager metroStyleManager, Configuration conf, frmMain main, bool login)
        {
            InitializeComponent();
            this.metroStyleManager.Theme = metroStyleManager.Theme;
            this.metroStyleManager.Style = metroStyleManager.Style;

            this.Refresh();

            this.conf = conf;
            this.main = main;
            this.login = login;

            try
            {
                path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\scripts";

                arquivos = Directory.GetFiles(path,"*.sql",SearchOption.AllDirectories).OrderBy(f=>f).ToArray();

                if (arquivos.Length == 0)
                {
                    throw new Exception("Não foi possível localizar os scripts de criação da base.");
                }

                CreateObjects();
                LoadDatabases();
                GetDatabases();
            }
            catch (Exception err)
            {
                main.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GetDatabases()
        {
            UpdateDataSource();
        }

        public void LoadDatabases()
        {
            dbTables.LoadServer(main.GetCredentials(), main.GetDatabaseName());
            dbTables.LoadDatabases(main.GetCredentials(), main.GetDatabaseName());
        }

        public void CreateObjects()
        {

            DataTable dt = main.GetDbConnect().executeDataTable("SELECT * FROM sys.tables WHERE name = 'index'", new Dapper.DynamicParameters(), main.GetDatabaseName(), out string errMsg, out int errCode);

            if (errCode != 0)
            {
                throw new Exception(errMsg);
            }

            //Cria tabelas
            if (dt.Rows.Count == 0)
            {
                foreach(string f in arquivos)
                {
                    StreamReader sr = new StreamReader(f);
                    string script = sr.ReadToEnd();

                    errMsg = "";
                    errCode = 0;

                    main.dbCon.executeCommand(script, new Dapper.DynamicParameters(), main.databaseSindex, out errMsg, out errCode);

                    if (errCode != 0)
                    {
                        throw new Exception(errMsg);
                    }
                }
            }
        }

        private void frmDatabases_Load(object sender, EventArgs e)
        {

        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateDataSource();
            }
            catch (Exception err)
            {
                main.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkMarcarTodos_Click(object sender, EventArgs e)
        {
            try
            {
                grdDatabases.SelectAll();

                SetDataBaseEnabled(chkMarcarTodos.Checked);

                UpdateDataSource();
                grdDatabases.ClearSelection();
            }
            catch (Exception err)
            {
                main.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateDataSource()
        {
            try
            {
                if (txtFiltrar.Text != "")
                {
                    grdDatabases.DataSource = dbTables.GetDatabases(main.cred, main.databaseSindex, txtFiltrar.Text);
                } else
                {
                    grdDatabases.DataSource = dbTables.GetDatabases(main.cred, main.databaseSindex);
                }

                ResizeGrid();
            }
            catch (Exception err)
            {
                main.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResizeGrid()
        {
            if (grdDatabases.Columns.Count > 0)
            {
                grdDatabases.Columns[0].HeaderText = "Database ID";
                grdDatabases.Columns[0].Visible = true;

                grdDatabases.Columns[1].HeaderText = "Servidor";
                grdDatabases.Columns[1].Visible = false;

                grdDatabases.Columns[2].HeaderText = "Banco de Dados";
                grdDatabases.Columns[2].Visible = true;

                grdDatabases.Columns[3].HeaderText = "Última Atualização";
                grdDatabases.Columns[3].Visible = true;

                grdDatabases.Columns[4].HeaderText = "Monitorar";
                grdDatabases.Columns[4].Visible = true;

                int widthMedia = (grdDatabases.Width / (grdDatabases.Columns.GetColumnCount(DataGridViewElementStates.Visible))) - 10;

                grdDatabases.Columns[0].Width = widthMedia;
                grdDatabases.Columns[2].Width = widthMedia;
                grdDatabases.Columns[3].Width = widthMedia;
                grdDatabases.Columns[4].Width = widthMedia;
            }
        }

        private void grdDatabases_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetDataBaseEnabled();
        }

        private void SetDataBaseEnabled(bool value)
        {
            int[] rows = new int[grdDatabases.SelectedRows.Count];
            int x = 0;
            bool index0 = false;

            foreach (DataGridViewRow r in grdDatabases.SelectedRows)
            {
                dbTables.SetDatabaseEnabled(main.cred, main.databaseSindex, Int32.Parse(r.Cells[0].Value.ToString()), value);
                rows[x] = r.Index;
                x++;

                if (r.Index == 0)
                {
                    index0 = true;
                }
            }

            UpdateDataSource();

            if (!index0)
            {
                grdDatabases.Rows[0].Selected = false;
            }

            for (int i = 0; i < rows.Length; i++)
            {
                grdDatabases.Rows[rows[i]].Selected = true;
            }
        }
        private void SetDataBaseEnabled()
        {
            int[] rows = new int[grdDatabases.SelectedRows.Count];
            int x = 0;
            bool index0 = false;

            foreach (DataGridViewRow r in grdDatabases.SelectedRows)
            {
                dbTables.SetDatabaseEnabled(main.cred, main.databaseSindex, Int32.Parse(r.Cells[0].Value.ToString()), !Boolean.Parse(r.Cells[4].Value.ToString()));
                rows[x] = r.Index;
                x++;

                if (r.Index == 0)
                {
                    index0 = true;
                }
            }

            UpdateDataSource();

            if (!index0)
            {
                grdDatabases.Rows[0].Selected = false;
            }

            for (int i = 0; i < rows.Length; i++)
            {
                grdDatabases.Rows[rows[i]].Selected = true;
            }
        }

        private void marcarSelecionadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetDataBaseEnabled(true);
        }

        private void desmarcarSelecionadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetDataBaseEnabled(false);
        }

        private void grdDatabases_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lnkSalvarFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            main.LoadTables(login);
        }

        private void frmDatabases_Resize(object sender, EventArgs e)
        {
            ResizeGrid();
        }
    }
}
