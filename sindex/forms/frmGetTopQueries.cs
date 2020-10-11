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
    public partial class frmGetTopQueries : Form
    {
        Configuration conf;
        frmMain main;
        string[] gridColName = { "Data de Execução", "Última Execução", "Tempo Total CPU", "Média de CPU", "Média de Leituras", "Média de Escritas"
                                ,"Tempo Médio de Execução", "Quantidade de Execuções", "Query", "Plano de Execução", "Banco de Dados", "Média de Threads"
                                ,"Média MAXDOP", "Declaração" };
        bool[] gridVisible = { true, true, true, true, true, true
                              ,true, true, false, false, true, true
                              ,true, true };
        int scriptColumn = 13;

        System.Data.DataTable dtTopQueries;

        public frmGetTopQueries(MetroStyleManager metroStyleManager, Configuration conf, frmMain main)
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
            int top = 50;

            if (cbxFiltro.Text == "Database")
            {
                database = txtFiltro.Text;
            }

            if (txtTop.Text.All(char.IsNumber))
            {
                top = Int32.Parse(txtTop.Text);
            }

            dtTopQueries = dbQuery.GetTopQueries(main.GetCredentials(), main.databaseSindex, top, database);

            mnuIndexes.Enabled = !(dtTopQueries.Rows.Count <= 0);

            grdIndexes.DataSource = dtTopQueries;
            grdIndexes.Refresh();
            ResizeGrid(grdIndexes);

            lblLinhas.Text = dtTopQueries.Rows.Count.ToString() + " linhas.";
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

        List<TopQueryModel> GetIndexList()
        {
            List<TopQueryModel> list = new List<TopQueryModel>();

            if (dtTopQueries.Rows.Count > 0)
            {
                for (int i = 0; i < dtTopQueries.Rows.Count; i++)
                {
                    TopQueryModel index = new TopQueryModel();
                    index.createTime = DateTime.Parse(dtTopQueries.Rows[i][0].ToString());
                    index.lastExecutionDateTime = DateTime.Parse(dtTopQueries.Rows[i][1].ToString());
                    index.totalWokerTime = Double.Parse(dtTopQueries.Rows[i][2].ToString());
                    index.avgCpuTime = Double.Parse(dtTopQueries.Rows[i][3].ToString());
                    index.avgPhysicalReads = Int32.Parse(dtTopQueries.Rows[i][4].ToString());
                    index.avgLogicalWrites = Int32.Parse(dtTopQueries.Rows[i][5].ToString());
                    index.avgElapsedTime = Double.Parse(dtTopQueries.Rows[i][6].ToString());
                    index.executionCount = Int32.Parse(dtTopQueries.Rows[i][7].ToString());
                    index.query = dtTopQueries.Rows[i][8].ToString();
                    index.plan = dtTopQueries.Rows[i][9].ToString();
                    index.databaseName = dtTopQueries.Rows[i][10].ToString();
                    index.avgUsedThreads = Int32.Parse(dtTopQueries.Rows[i][11].ToString());
                    index.avgMaxDop = Int32.Parse(dtTopQueries.Rows[i][12].ToString());
                    index.statement = dtTopQueries.Rows[i][13].ToString();

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
                PrintSindex.PrintReportViewer(GetIndexList(), "DataSet1", "sindex.reports.TopQueries.rdlc", true, DeviceInfoSindex.landscape);
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

                PrintSindex.PrintGrid("Top Queries", "", "", grdIndexes);

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
                PrintSindex.PrintExcel(dtTopQueries, "Top Queries");
            }
            catch (Exception err)
            {
                main.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void grdIndexes_DoubleClick(object sender, EventArgs e)
        {

        }

        private void chkMarcarTodos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private async void criarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verDetalhesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                if (grdIndexes.SelectedRows.Count > 0)
                {
                    for (int i = 0; i < grdIndexes.SelectedRows.Count; i++)
                    {
                        int x = grdIndexes.SelectedRows[i].Index;
                        TopQueryModel index = new TopQueryModel();
                        index.createTime = DateTime.Parse(dtTopQueries.Rows[x][0].ToString());
                        index.lastExecutionDateTime = DateTime.Parse(dtTopQueries.Rows[x][1].ToString());
                        index.totalWokerTime = Double.Parse(dtTopQueries.Rows[x][2].ToString());
                        index.avgCpuTime = Double.Parse(dtTopQueries.Rows[x][3].ToString());
                        index.avgPhysicalReads = Int32.Parse(dtTopQueries.Rows[x][4].ToString());
                        index.avgLogicalWrites = Int32.Parse(dtTopQueries.Rows[x][5].ToString());
                        index.avgElapsedTime = Double.Parse(dtTopQueries.Rows[x][6].ToString());
                        index.executionCount = Int32.Parse(dtTopQueries.Rows[x][7].ToString());
                        index.query = dtTopQueries.Rows[x][8].ToString();
                        index.plan = dtTopQueries.Rows[x][9].ToString();
                        index.databaseName = dtTopQueries.Rows[x][10].ToString();
                        index.avgUsedThreads = Int32.Parse(dtTopQueries.Rows[x][11].ToString());
                        index.avgMaxDop = Int32.Parse(dtTopQueries.Rows[x][12].ToString());
                        index.statement = dtTopQueries.Rows[x][13].ToString();

                        Form frm = new frmDetailTopQuery(this.metroStyleManager, index);
                        frm.Show();
                    }
                }
            }
            catch (Exception err)
            {
                main.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
