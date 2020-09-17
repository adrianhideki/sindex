using MetroFramework.Components;
using sindex.model;
using sindex.repository;
using sindex.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sindex.forms
{
    public partial class frmMissingIndexes : Form
    {
        Configuration conf;
        frmMain main;
        string[] gridColName = { "Database Name", "Média de Impacto", "Última Leitura", "Tabela", "Script de Criação", "Selecionado" };
        bool[] gridVisible = { true, true, true, true, true, true };
        int checkedColumn = 5;
        int scriptColumn = 4;

        System.Data.DataTable dtMissingIndexes;

        public frmMissingIndexes(MetroStyleManager metroStyleManager, Configuration conf, frmMain main)
        {
            this.main = main;
            this.conf = conf;

            InitializeComponent();

            try
            {
                this.metroStyleManager.Theme = metroStyleManager.Theme;
                this.metroStyleManager.Style = metroStyleManager.Style;

                cbxFiltro.SelectedIndex = 0;
                GetDataGrid();
                SetTheme();
            }
            catch (Exception err)
            {
                main.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SetTheme()
        {
            Color bgColor = Color.FromArgb(17, 17, 17);
            Color frColor = Color.FromArgb(119, 119, 119);

            txtIndexes.BackColor = bgColor;
            txtIndexes.ForeColor = frColor;
        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                GetDataGrid();
            }
            catch (Exception err)
            {
                main.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ResizeGrid(DataGridView grd)
        {
            if (grd.Rows.Count <= 0) return;

            for (int i = 0; i < grd.Columns.Count; i++)
            {
                grd.Columns[i].HeaderText = gridColName[i];
                grd.Columns[i].Visible = gridVisible[i];
            }

            int widthMedia = (grdIndexes.Width / (grdIndexes.Columns.GetColumnCount(DataGridViewElementStates.Visible))) - 10;

            for (int i = 0; i < grd.Columns.Count; i++)
            {
                if (grd.Columns[i].Visible)
                  grd.Columns[i].Width = widthMedia;
            }
        }
        private void GetDataGrid()
        {

            string database = "";
            string table = "";

            if (cbxFiltro.Text == "Database")
            {
                database = txtFiltro.Text;
            } 
            else if (cbxFiltro.Text == "Table")
            {
                table = txtFiltro.Text;
            }

            dtMissingIndexes = dbIndex.GetMissingIndexes(main.GetCredentials(), main.databaseSindex, database, table);

            mnuIndexes.Enabled = !(dtMissingIndexes.Rows.Count <= 0);

            grdIndexes.DataSource = dtMissingIndexes;
            grdIndexes.Refresh();
            ResizeGrid(grdIndexes);

            lblLinhas.Text = dtMissingIndexes.Rows.Count.ToString() + " linhas.";
        }
        private void grdIndexes_Resize(object sender, EventArgs e)
        {
            ResizeGrid(grdIndexes);
        }
        private void grdIndexes_SelectionChanged(object sender, EventArgs e)
        {
            if (grdIndexes.SelectedRows.Count > 0)
            {
                txtIndexes.Text = "";

                for (int i = 0; i < grdIndexes.SelectedRows.Count; i++)
                {
                    txtIndexes.Text += grdIndexes.SelectedRows[i].Cells[scriptColumn].Value.ToString() + "\n";
                }
            }
        }
        List<MissingIndexModel> GetIndexList()
        {
            List<MissingIndexModel> list = new List<MissingIndexModel>();

            if (dtMissingIndexes.Rows.Count > 0)
            {
                for (int i = 0; i < dtMissingIndexes.Rows.Count; i++)
                {
                    MissingIndexModel index = new MissingIndexModel();
                    index.database = dtMissingIndexes.Rows[i][0].ToString();
                    index.table = dtMissingIndexes.Rows[i][3].ToString();
                    index.impact = double.Parse(dtMissingIndexes.Rows[i][1].ToString());
                    index.lastSeek = DateTime.Parse(dtMissingIndexes.Rows[i][2].ToString());
                    index.scriptIndex = dtMissingIndexes.Rows[i][4].ToString();

                    list.Add(index);
                }
            }

            if (list.Count <= 0) throw new Exception("Não há registros para a geração do relatório.");

            return list;
        }
        private void padrãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PrintSindex.PrintReportViewer(GetIndexList(), "DataSet1", "sindex.reports.MissingIndexes.rdlc", true, DeviceInfoSindex.landscape);
            }
            catch (Exception err)
            {
                main.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void gridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                grdIndexes.Theme = MetroFramework.MetroThemeStyle.Light;
                grdIndexes.Style = MetroFramework.MetroColorStyle.Silver;

                PrintSindex.PrintGrid("Missing Indexes", "", "", grdIndexes);

                grdIndexes.Theme = MetroFramework.MetroThemeStyle.Default;
                grdIndexes.Style = MetroFramework.MetroColorStyle.Default;
            }
            catch (Exception err)
            {
                main.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PrintSindex.PrintExcel(dtMissingIndexes, "Missing Indexes");
            }
            catch (Exception err)
            {
                main.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void grdIndexes_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (grdIndexes.SelectedRows.Count > 0)
                {
                    for (int i = 0; i < grdIndexes.SelectedRows.Count; i++)
                    {
                        grdIndexes.SelectedRows[i].Cells[checkedColumn].Value = !Boolean.Parse(grdIndexes.SelectedRows[i].Cells[checkedColumn].Value.ToString());
                    }
                }
            } catch (Exception err)
            {
                main.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void chkMarcarTodos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (grdIndexes.Rows.Count > 0)
                {
                    for (int i = 0; i < grdIndexes.Rows.Count; i++)
                    {
                        grdIndexes.Rows[i].Cells[checkedColumn].Value = chkMarcarTodos.Checked;
                    }
                }
            }
            catch (Exception err)
            {
                main.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void criarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Credentials cred = main.GetCredentials();
                string database = main.databaseSindex;
                string erro = "";

                if (grdIndexes.Rows.Count > 0)
                {
                    for (int i = 0; i < grdIndexes.Rows.Count; i++)
                    {
                        try
                        {
                            if (Boolean.Parse(grdIndexes.Rows[i].Cells[checkedColumn].Value.ToString()))
                            {
                                dbIndex.ExecuteScript(cred, database, grdIndexes.Rows[i].Cells[scriptColumn].Value.ToString());
                            }
                        } 
                        catch (Exception err)
                        {
                            erro += "\nÍndice: " + grdIndexes.Rows[i].Cells[scriptColumn].Value.ToString() + " Erro: " + err.Message;
                        }                        
                    }

                    if (erro != "") throw new Exception(erro);

                    main.ShowMessage(String.Format("Término da criação do(s) índice(s): {0}", DateTime.Now.ToString()), "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception err)
            {
                main.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
