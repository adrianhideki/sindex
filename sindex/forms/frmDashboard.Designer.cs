namespace sindex.forms
{
    partial class frmDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chtMemory = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.pnlBackground = new MetroFramework.Controls.MetroPanel();
            this.tlpCharts = new System.Windows.Forms.TableLayoutPanel();
            this.chtConnection = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chtArquivos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chtCPU = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chtMemory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.pnlBackground.SuspendLayout();
            this.tlpCharts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtConnection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtArquivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtCPU)).BeginInit();
            this.SuspendLayout();
            // 
            // chtMemory
            // 
            chartArea1.Name = "ChartArea1";
            this.chtMemory.ChartAreas.Add(chartArea1);
            this.chtMemory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chtMemory.Location = new System.Drawing.Point(3, 3);
            this.chtMemory.Name = "chtMemory";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chtMemory.Series.Add(series1);
            this.chtMemory.Size = new System.Drawing.Size(375, 221);
            this.chtMemory.TabIndex = 4;
            this.chtMemory.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title1.Name = "Memory";
            title1.Text = "Memory";
            this.chtMemory.Titles.Add(title1);
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // pnlBackground
            // 
            this.pnlBackground.Controls.Add(this.tlpCharts);
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.HorizontalScrollbarBarColor = true;
            this.pnlBackground.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlBackground.HorizontalScrollbarSize = 10;
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(762, 454);
            this.pnlBackground.TabIndex = 5;
            this.pnlBackground.VerticalScrollbarBarColor = true;
            this.pnlBackground.VerticalScrollbarHighlightOnWheel = false;
            this.pnlBackground.VerticalScrollbarSize = 10;
            // 
            // tlpCharts
            // 
            this.tlpCharts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.tlpCharts.ColumnCount = 2;
            this.tlpCharts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCharts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCharts.Controls.Add(this.chtConnection, 0, 1);
            this.tlpCharts.Controls.Add(this.chtArquivos, 0, 1);
            this.tlpCharts.Controls.Add(this.chtCPU, 1, 0);
            this.tlpCharts.Controls.Add(this.chtMemory, 0, 0);
            this.tlpCharts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCharts.Location = new System.Drawing.Point(0, 0);
            this.tlpCharts.Name = "tlpCharts";
            this.tlpCharts.RowCount = 2;
            this.tlpCharts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCharts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCharts.Size = new System.Drawing.Size(762, 454);
            this.tlpCharts.TabIndex = 6;
            // 
            // chtConnection
            // 
            chartArea2.Name = "ChartArea1";
            this.chtConnection.ChartAreas.Add(chartArea2);
            this.chtConnection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chtConnection.Location = new System.Drawing.Point(3, 230);
            this.chtConnection.Name = "chtConnection";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.chtConnection.Series.Add(series2);
            this.chtConnection.Size = new System.Drawing.Size(375, 221);
            this.chtConnection.TabIndex = 7;
            this.chtConnection.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title2.Name = "Memory";
            title2.Text = "Connections";
            this.chtConnection.Titles.Add(title2);
            // 
            // chtArquivos
            // 
            chartArea3.Name = "ChartArea1";
            this.chtArquivos.ChartAreas.Add(chartArea3);
            this.chtArquivos.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.ForeColor = System.Drawing.Color.Silver;
            legend1.Name = "Legend1";
            this.chtArquivos.Legends.Add(legend1);
            this.chtArquivos.Location = new System.Drawing.Point(384, 230);
            this.chtArquivos.Name = "chtArquivos";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar100;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.YValuesPerPoint = 2;
            this.chtArquivos.Series.Add(series3);
            this.chtArquivos.Size = new System.Drawing.Size(375, 221);
            this.chtArquivos.TabIndex = 6;
            this.chtArquivos.Text = "chart1";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title3.Name = "Memory";
            title3.Text = "File Disk";
            this.chtArquivos.Titles.Add(title3);
            // 
            // chtCPU
            // 
            chartArea4.Name = "ChartArea1";
            this.chtCPU.ChartAreas.Add(chartArea4);
            this.chtCPU.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chtCPU.Legends.Add(legend2);
            this.chtCPU.Location = new System.Drawing.Point(384, 3);
            this.chtCPU.Name = "chtCPU";
            series4.BorderWidth = 5;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.LabelForeColor = System.Drawing.Color.DimGray;
            series4.Legend = "Legend1";
            series4.LegendText = "CPU Usage";
            series4.Name = "Series1";
            series5.BorderWidth = 5;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.LegendText = "SQL CPU Usage";
            series5.Name = "Series2";
            this.chtCPU.Series.Add(series4);
            this.chtCPU.Series.Add(series5);
            this.chtCPU.Size = new System.Drawing.Size(375, 221);
            this.chtCPU.TabIndex = 5;
            this.chtCPU.Text = "chart1";
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title4.Name = "Title1";
            title4.Text = "CPU";
            this.chtCPU.Titles.Add(title4);
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Interval = 1000;
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 454);
            this.Controls.Add(this.pnlBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboard";
            this.Text = "frmDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.chtMemory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.pnlBackground.ResumeLayout(false);
            this.tlpCharts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtConnection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtArquivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtCPU)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chtMemory;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroPanel pnlBackground;
        private System.Windows.Forms.TableLayoutPanel tlpCharts;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtCPU;
        private System.Windows.Forms.Timer tmrUpdate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtArquivos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtConnection;
    }
}