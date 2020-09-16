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
    public partial class frmFragmentedIndexes : Form
    {
        Configuration conf;
        frmMain main;
        string[] gridColName = { "Tabela", "Database Name", "Índice", "Fragmentação", "Tipo", "Script", "Selecionado" };
        bool[] gridVisible = { true, true, true, true, true, true, true };
        int checkedColumn = 6;
        int scriptColumn = 5;
        DataTable dtFragmentedIndexes;

        public frmFragmentedIndexes(MetroStyleManager metroStyleManager, Configuration conf, frmMain main)
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
            string type = "";
            double fragmented = 0;
            bool tableWithData = false;

            if (cbxFiltro.Text == "Database")
            {
                database = txtFiltro.Text;
            }
            else if (cbxFiltro.Text == "Table")
            {
                table = txtFiltro.Text;
            }
            else if (cbxFiltro.Text == "Type")
            {
                type = txtFiltro.Text;
            }
            else if (cbxFiltro.Text == "Fragmentation")
            {
                fragmented = double.Parse(txtFiltro.Text);
            }

            tableWithData = chkSomenteTabelasDados.Checked;

            dtFragmentedIndexes = dbIndex.GetFragmentedIndexes(main.GetCredentials(), main.databaseSindex, database, table, type, fragmented, tableWithData);

            mnuIndexes.Enabled = !(dtFragmentedIndexes.Rows.Count <= 0);

            grdIndexes.DataSource = dtFragmentedIndexes;
            grdIndexes.Refresh();
            ResizeGrid(grdIndexes);

            lblLinhas.Text = dtFragmentedIndexes.Rows.Count.ToString() + " linhas.";
        }
        private void grdIndexes_Resize(object sender, EventArgs e)
        {
            ResizeGrid(grdIndexes);
        }
        List<FragmentedIndexModel> GetIndexList()
        {
            List<FragmentedIndexModel> list = new List<FragmentedIndexModel>();

            if (dtFragmentedIndexes.Rows.Count > 0)
            {
                for (int i = 0; i < dtFragmentedIndexes.Rows.Count; i++)
                {
                    FragmentedIndexModel index = new FragmentedIndexModel();
                    index.table = dtFragmentedIndexes.Rows[i][0].ToString();
                    index.database = dtFragmentedIndexes.Rows[i][1].ToString();
                    index.index = dtFragmentedIndexes.Rows[i][2].ToString();
                    index.fragmentation = double.Parse(dtFragmentedIndexes.Rows[i][3].ToString());
                    index.type = dtFragmentedIndexes.Rows[i][4].ToString();
                    index.script = dtFragmentedIndexes.Rows[i][5].ToString();

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
                PrintSindex.PrintReportViewer(GetIndexList(), "DataSet1", "sindex.reports.FragmentedIndexes.rdlc", true, DeviceInfoSindex.landscape);
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

                PrintSindex.PrintGrid("Fragmented Indexes", "", "", grdIndexes);

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
                PrintSindex.PrintExcel(dtFragmentedIndexes, "Fragmented Indexes");
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

                if (grdIndexes.Rows.Count > 0)
                {
                    string erro = "";

                    for (int i = 0; i < grdIndexes.Rows.Count; i++)
                    {
                        try
                        {
                            if (Boolean.Parse(grdIndexes.Rows[i].Cells[checkedColumn].Value.ToString()))
                            {
                                dbIndex.ExecuteScript(cred, database, grdIndexes.Rows[i].Cells[scriptColumn].Value.ToString());
                            }
                        } catch (Exception err)
                        {
                            erro = "\nÍndice: " + grdIndexes.Rows[i].Cells[scriptColumn].Value.ToString() + " Erro: " + err.Message;
                        }                        
                    }

                    if (erro != "") throw new Exception(erro);

                    main.ShowMessage(String.Format("Término da desfragmentação do(s) índice(s): {0}", DateTime.Now.ToString()), "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception err)
            {
                main.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
