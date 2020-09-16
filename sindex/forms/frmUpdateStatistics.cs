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
    public partial class frmUpdateStatistics : Form
    {
        Configuration conf;
        frmMain main;
        string[] gridColName = { "Estatística", "Tabela", "Criado Automático", "Dias Última Atualização", "Data de Atualização", "Banco de Dados", "Script", "Selecionado" };
        bool[] gridVisible = { true, true, true, true, true, true, true, true };
        int checkedColumn = 7;
        int scriptColumn = 6;
        DataTable dtStats;

        public frmUpdateStatistics(MetroStyleManager metroStyleManager, Configuration conf, frmMain main)
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
                ValidaFiltro();
                GetDataGrid();
            }
            catch (Exception err)
            {
                main.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidaFiltro()
        {

        }

        private void ResizeGrid(DataGridView grd)
        {
            if (grd.Rows.Count <= 0) return;

            for (int i = 0; i < grd.Columns.Count; i++)
            {
                grd.Columns[i].HeaderText = gridColName[i];
                grd.Columns[i].Visible = gridVisible[i];
            }

            int widthMedia = (grdStats.Width / (grdStats.Columns.GetColumnCount(DataGridViewElementStates.Visible))) - 10;

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
            string stat = "";
            bool fullscan = false;
            bool sample = false;
            bool resample = false;
            bool onlyTableData = false;
            int percent = 0;
            int rows = 0;
            int days = 0;

            if (cbxFiltro.Text == "Database")
            {
                database = txtFiltro.Text;
            }
            else if (cbxFiltro.Text == "Table")
            {
                table = txtFiltro.Text;
            }
            else if (cbxFiltro.Text == "Stat")
            {
                stat = txtFiltro.Text;
            }

            fullscan = rbtFullScan.Checked;
            resample = rbtResample.Checked;
            sample = rbtSamplePercent.Checked || rbtSampleRows.Checked;
            onlyTableData = chkSomenteTabelasDados.Checked;
            if (rbtSamplePercent.Checked) percent = Int32.Parse(txtPercent.Text);
            if (rbtSampleRows.Checked) rows = Int32.Parse(txtRows.Text);
            days = Int32.Parse(txtDias.Text);

            dtStats = dbStat.GetUpdateStatistics(main.GetCredentials(), main.databaseSindex, fullscan, sample, resample, percent, rows, database, table, stat, days, onlyTableData);

            mnuStats.Enabled = !(dtStats.Rows.Count <= 0);

            grdStats.DataSource = dtStats;
            grdStats.Refresh();
            ResizeGrid(grdStats);

            lblLinhas.Text = dtStats.Rows.Count.ToString() + " linhas.";
        }
        private void grdIndexes_Resize(object sender, EventArgs e)
        {
            ResizeGrid(grdStats);
        }
        List<StatModel> GetStatList()
        {
            List<StatModel> list = new List<StatModel>();

            if (dtStats.Rows.Count > 0)
            {
                for (int i = 0; i < dtStats.Rows.Count; i++)
                {
                    StatModel stat = new StatModel();
                    stat.stat = dtStats.Rows[i][0].ToString();
                    stat.table =  dtStats.Rows[i][1].ToString();
                    stat.autoCreate =  Boolean.Parse(dtStats.Rows[i][2].ToString());
                    stat.days =  Int32.Parse(dtStats.Rows[i][3].ToString());
                    stat.updateDate =  DateTime.Parse(dtStats.Rows[i][4].ToString());
                    stat.database =  dtStats.Rows[i][5].ToString();
                    stat.script = dtStats.Rows[i][6].ToString();

                    list.Add(stat);
                }
            }

            if (list.Count <= 0) throw new Exception("Não há registros para a geração do relatório.");

            return list;
        }
        private void padrãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PrintSindex.PrintReportViewer(GetStatList(), "DataSet1", "sindex.reports.UpdateStats.rdlc", true, DeviceInfoSindex.landscape);
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
                grdStats.Theme = MetroFramework.MetroThemeStyle.Light;
                grdStats.Style = MetroFramework.MetroColorStyle.Silver;

                PrintSindex.PrintGrid("Update Stats", "", "", grdStats);

                grdStats.Theme = MetroFramework.MetroThemeStyle.Default;
                grdStats.Style = MetroFramework.MetroColorStyle.Default;
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
                PrintSindex.PrintExcel(dtStats, "Update Stats");
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
                if (grdStats.SelectedRows.Count > 0)
                {
                    for (int i = 0; i < grdStats.SelectedRows.Count; i++)
                    {
                        grdStats.SelectedRows[i].Cells[checkedColumn].Value = !Boolean.Parse(grdStats.SelectedRows[i].Cells[checkedColumn].Value.ToString());
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
                if (grdStats.Rows.Count > 0)
                {
                    for (int i = 0; i < grdStats.Rows.Count; i++)
                    {
                        grdStats.Rows[i].Cells[checkedColumn].Value = chkMarcarTodos.Checked;
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

                if (grdStats.Rows.Count > 0)
                {
                    string erro = "";

                    for (int i = 0; i < grdStats.Rows.Count; i++)
                    {
                        try
                        {
                            if (Boolean.Parse(grdStats.Rows[i].Cells[checkedColumn].Value.ToString()))
                            {
                                dbStat.ExecuteScript(cred, database, grdStats.Rows[i].Cells[scriptColumn].Value.ToString());
                            }
                        } catch (Exception err)
                        {
                            erro = "\nÍndice: " + grdStats.Rows[i].Cells[scriptColumn].Value.ToString() + " Erro: " + err.Message;
                        }
                    }

                    if (erro != "") throw new Exception(erro);

                    main.ShowMessage(String.Format("Término da atualização da(s) estatística(s): {0}", DateTime.Now.ToString()), "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception err)
            {
                main.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbtSampleRows_CheckedChanged(object sender, EventArgs e)
        {
            txtRows.Enabled = rbtSampleRows.Checked;
        }

        private void rbtSamplePercent_CheckedChanged(object sender, EventArgs e)
        {
            txtPercent.Enabled = rbtSamplePercent.Checked;
        }
    }
}
