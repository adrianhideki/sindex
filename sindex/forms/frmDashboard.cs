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

        public frmDashboard(MetroStyleManager metroStyleManager, Configuration conf, frmMain main)
        {
            InitializeComponent();

            this.conf = conf;
            this.main = main;

            this.metroStyleManager.Theme = metroStyleManager.Theme;
            this.metroStyleManager.Style = metroStyleManager.Style;
            SetTheme(chtMemory);

            this.Refresh();
            SetTheme(chtCPU);
            SetTheme(chtMemory);

            tmrUpdate.Enabled = true;
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
                    chart.ChartAreas[i].Axes[x].LineColor = fore;
                }

                chart.ChartAreas[i].AxisX.LineColor = fore;
                chart.ChartAreas[i].AxisY.LineColor = fore;
                chart.ChartAreas[i].AxisX2.LineColor = fore;
                chart.ChartAreas[i].AxisY2.LineColor = fore;
                chart.ChartAreas[i].AxisX.MinorGrid.LineColor = fore;
                chart.ChartAreas[i].AxisY.MinorGrid.LineColor = fore;
                chart.ChartAreas[i].AxisX.MajorGrid.LineColor = foreTwo;
                chart.ChartAreas[i].AxisY.MajorGrid.LineColor = foreTwo;
                chart.ChartAreas[i].AxisY.LabelStyle.ForeColor = foreTwo;
                chart.ChartAreas[i].AxisX.LabelStyle.ForeColor = foreTwo;
                chart.ChartAreas[i].AxisX.TitleForeColor = foreTwo;
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

        private void SetMemoryChart()
        {
            DataTable dt = dbTables.GetMemoryInfo(main.cred, main.databaseSindex);

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

        private void SetCPUChart()
        {
            DataTable dt = dbTables.GetCPUInfo(main.cred, main.databaseSindex);

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

        private async void tmrUpdate_Tick(object sender, EventArgs e)
        {
            SetCPUChart();
            SetMemoryChart();
        }
    }
}
