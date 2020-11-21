using MetroFramework.Components;
using Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel;
using sindex.repository;
using sindex.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace sindex.forms
{

    public partial class frmDashboard : Form
    {
        Configuration conf;
        frmMain main;
        List<Chart> charts;
        int colCount = 0;
        int rowCount = 0;

        public frmDashboard(MetroStyleManager metroStyleManager, Configuration conf, frmMain main)
        {
            InitializeComponent();

            this.colCount = tlpCharts.ColumnCount;
            this.rowCount = tlpCharts.RowCount;

            this.conf = conf;
            this.main = main;
            this.charts = new List<Chart>();

            this.metroStyleManager.Theme = metroStyleManager.Theme;
            this.metroStyleManager.Style = metroStyleManager.Style;
            this.tmrUpdate.Interval = main.secondsToUpdateChart * 1000;

            this.Refresh();

            try
            {
                SetupDiskChart();
                SetTheme(chtCPU);
                SetTheme(chtMemory);
                SetTheme(chtArquivos);
                SetTheme(chtConnection);

                charts.Add(chtCPU);
                charts.Add(chtMemory);
                charts.Add(chtArquivos);
                charts.Add(chtConnection);

                tmrUpdate.Enabled = true;
                tmrUpdate_Tick(null,null);
            }
            catch (Exception err)
            {
                tmrUpdate.Enabled = false;
                main.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ZoomChart(Chart chart, bool zoomIn)
        {
            int index = charts.IndexOf(chart);

            for (int i = 0; i < charts.Count; i++)
            {
                if (i != index)
                {
                    charts[i].Visible = !zoomIn;
                }
            }

            if (zoomIn)
            {
                tlpCharts.ColumnCount = 1;
                tlpCharts.RowCount = 1;

                tlpCharts.RowStyles[0].SizeType = SizeType.AutoSize;
                tlpCharts.ColumnStyles[0].SizeType = SizeType.AutoSize;
            } 
            else 
            {
                int avgWidth  = 100 / colCount;
                int avgHeight = 100 / rowCount;

                tlpCharts.ColumnCount = colCount;
                tlpCharts.RowCount = rowCount;

                for (int i = 0; i < tlpCharts.RowStyles.Count; i++)
                {
                    tlpCharts.RowStyles[i].SizeType = SizeType.Percent;
                    tlpCharts.RowStyles[i].Height = avgHeight;
                }

                for (int i = 0; i < tlpCharts.ColumnStyles.Count; i++)
                {
                    tlpCharts.ColumnStyles[i].SizeType = SizeType.Percent;
                    tlpCharts.ColumnStyles[i].Width = avgWidth;
                }
            }
        }

        private void SetTheme(Chart chart)
        {
            Color back = Color.FromArgb(17, 17, 17);
            Color fore = Color.FromArgb(191, 191, 191);
            Color foreTwo = Color.FromArgb(80, 80, 80);

            chart.BackColor = back;
            chart.ForeColor = fore;

            for (int i = 0; i < chart.Series.Count; i++)
            {
                //chart.Series[i].Color = fore;
                chart.Series[i].LabelForeColor = fore;
                chart.Series[i].BorderColor = fore;
                chart.Series[i].MarkerColor = fore;
            }

            for (int i = 0; i < chart.ChartAreas.Count; i++)
            {
                chart.ChartAreas[i].BackColor = back;

                for (int x = 0; x < chart.ChartAreas[i].Axes.Count(); x++)
                {
                    chart.ChartAreas[i].Axes[x].LineColor = foreTwo;
                }

                chart.ChartAreas[i].AxisX.LineColor = fore;
                chart.ChartAreas[i].AxisY.LineColor = fore;
                chart.ChartAreas[i].AxisX2.LineColor = fore;
                chart.ChartAreas[i].AxisY2.LineColor = fore;
                chart.ChartAreas[i].AxisX.MinorGrid.LineColor = foreTwo;
                chart.ChartAreas[i].AxisY.MinorGrid.LineColor = foreTwo;
                chart.ChartAreas[i].AxisX.MajorGrid.LineColor = foreTwo;
                chart.ChartAreas[i].AxisY.MajorGrid.LineColor = foreTwo;
                chart.ChartAreas[i].AxisY.LabelStyle.ForeColor = fore;
                chart.ChartAreas[i].AxisX.LabelStyle.ForeColor = fore;
                chart.ChartAreas[i].AxisX.TitleForeColor = fore;
                chart.ChartAreas[i].AxisX.Interval = 1;
            }

            for (int i = 0; i < chart.Legends.Count; i++)
            {
                chart.Legends[i].ForeColor = fore;
                chart.Legends[i].BackColor = back;
                chart.Legends[i].ForeColor = fore;
            }

            for (int i = 0; i < chart.Titles.Count; i++)
            {
                chart.Titles[i].BackColor = back;
                chart.Titles[i].ForeColor = fore;
            }
        }

        private async void SetConnectionChart()
        {
            DataTable dt = dbServer.GetConnectionsInfo(main.cred, main.databaseSindex);

            DataPoint Dp = new DataPoint();
            Dp.SetValueXY(dt.Columns[0].ColumnName, dt.Rows[0][0].ToString());

            chtConnection.Series[0].Points.Clear();
            chtConnection.Series[0].Points.Add(Dp);

            Dp = new DataPoint();
            Dp.SetValueXY(dt.Columns[1].ColumnName, dt.Rows[0][1].ToString());
            chtConnection.Series[0].Points.Add(Dp);

            Dp = new DataPoint();
            Dp.SetValueXY(dt.Columns[2].ColumnName, dt.Rows[0][2].ToString());
            chtConnection.Series[0].Points.Add(Dp);

            Dp = new DataPoint();
            Dp.SetValueXY(dt.Columns[3].ColumnName, dt.Rows[0][3].ToString());
            chtConnection.Series[0].Points.Add(Dp);

            Dp = new DataPoint();
            Dp.SetValueXY(dt.Columns[4].ColumnName, dt.Rows[0][4].ToString());
            chtConnection.Series[0].Points.Add(Dp);

            Dp = new DataPoint();
            Dp.SetValueXY(dt.Columns[5].ColumnName, dt.Rows[0][5].ToString());
            chtConnection.Series[0].Points.Add(Dp);

            Dp = new DataPoint();
            Dp.SetValueXY(dt.Columns[6].ColumnName, dt.Rows[0][6].ToString());
            chtConnection.Series[0].Points.Add(Dp);

            Dp = new DataPoint();
            Dp.SetValueXY(dt.Columns[7].ColumnName, dt.Rows[0][7].ToString());
            chtConnection.Series[0].Points.Add(Dp);

            Dp = new DataPoint();
            Dp.SetValueXY(dt.Columns[8].ColumnName, dt.Rows[0][8].ToString());
            chtConnection.Series[0].Points.Add(Dp);

            SetTheme(chtConnection);
            chtConnection.Series[0].IsValueShownAsLabel = true;
        }

        private async void SetMemoryChart()
        {
            DataTable dt = dbServer.GetMemoryInfo(main.cred, main.databaseSindex);

            DataPoint Dp = new DataPoint();
            Dp.SetValueXY(dt.Columns[0].ColumnName, dt.Rows[0][0].ToString());

            chtMemory.Series[0].Points.Clear();
            chtMemory.Series[0].Points.Add(Dp);

            Dp = new DataPoint();
            Dp.SetValueXY(dt.Columns[1].ColumnName, dt.Rows[0][1].ToString());
            chtMemory.Series[0].Points.Add(Dp);

            Dp = new DataPoint();
            Dp.SetValueXY(dt.Columns[2].ColumnName, dt.Rows[0][2].ToString());
            chtMemory.Series[0].Points.Add(Dp);

            Dp = new DataPoint();
            Dp.SetValueXY(dt.Columns[3].ColumnName, dt.Rows[0][3].ToString());
            chtMemory.Series[0].Points.Add(Dp);

            Dp = new DataPoint();
            Dp.SetValueXY(dt.Columns[4].ColumnName, dt.Rows[0][4].ToString());
            chtMemory.Series[0].Points.Add(Dp);

            SetTheme(chtMemory);
            chtMemory.Series[0].IsValueShownAsLabel = true;
        }

        private async void SetCPUChart()
        {
            DataTable dt = dbServer.GetCPUInfo(main.cred, main.databaseSindex);

            chtCPU.Series[0].Points.Clear();
            chtCPU.Series[1].Points.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataPoint Dp = new DataPoint();
                Dp.SetValueXY(dt.Rows[i][4].ToString(), dt.Rows[i][2].ToString());
                chtCPU.Series[0].Points.Add(Dp);

                Dp = new DataPoint();
                Dp.SetValueXY(dt.Rows[i][4].ToString(), dt.Rows[i][0].ToString());
                chtCPU.Series[1].Points.Add(Dp);
            }

            SetTheme(chtCPU);

            chtCPU.Series[0].IsValueShownAsLabel = true;
            chtCPU.Series[1].IsValueShownAsLabel = true;
        }

        private async void SetupDiskChart()
        {
            chtArquivos.Series.Clear();
            chtArquivos.Legends.Clear();

            chtArquivos.Series.Add(new Series() { LegendText = "Data Free Space", IsValueShownAsLabel = true, ChartType = SeriesChartType.StackedColumn100 });
            chtArquivos.Series.Add(new Series() { LegendText = "Data Usage", IsValueShownAsLabel = true, ChartType = SeriesChartType.StackedColumn100 });
            chtArquivos.Series.Add(new Series() { LegendText = "LOG Free Space", IsValueShownAsLabel = true, ChartType = SeriesChartType.StackedColumn100 });
            chtArquivos.Series.Add(new Series() { LegendText = "LOG Usage", IsValueShownAsLabel = true, ChartType = SeriesChartType.StackedColumn100 });
            chtArquivos.Legends.Add(new Legend() { BackColor = Color.FromArgb(17,17,17) });
        }

        private async void SetDiskChart()
        {
            DataTable dt = dbServer.GetDatabasesFileInfo(main.cred, main.databaseSindex);

            chtArquivos.Series[0].Points.Clear();
            chtArquivos.Series[1].Points.Clear();
            chtArquivos.Series[2].Points.Clear();
            chtArquivos.Series[3].Points.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string dbName = dt.Rows[i][0].ToString() + "\n" + dt.Rows[i][5].ToString() + " MB";
                DataPoint Dp = new DataPoint();
                Dp.SetValueXY(dbName, dt.Rows[i][1].ToString());
                chtArquivos.Series[0].Points.Add(Dp);

                Dp = new DataPoint();
                Dp.SetValueXY(dbName, dt.Rows[i][2].ToString());
                chtArquivos.Series[1].Points.Add(Dp);

                Dp = new DataPoint();
                Dp.SetValueXY(dbName, dt.Rows[i][3].ToString());
                chtArquivos.Series[2].Points.Add(Dp);

                Dp = new DataPoint();
                Dp.SetValueXY(dbName, dt.Rows[i][4].ToString());
                chtArquivos.Series[3].Points.Add(Dp);
            }

            SetTheme(chtArquivos);
        }

        private async void tmrUpdate_Tick(object sender, EventArgs e)
        {
            try
            {
                SetCPUChart();
                SetMemoryChart();
                SetDiskChart();
                SetConnectionChart();
            }
            catch (Exception err)
            {
                tmrUpdate.Enabled = false;
                main.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chtArquivos_DoubleClick(object sender, EventArgs e)
        {
            bool zoomIt = (tlpCharts.ColumnCount == colCount);
            ZoomChart((Chart)sender, zoomIt);
        }
    }
}
