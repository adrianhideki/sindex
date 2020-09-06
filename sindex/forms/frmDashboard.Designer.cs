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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chtMemory = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.pnlBackground = new MetroFramework.Controls.MetroPanel();
            this.tlpCharts = new System.Windows.Forms.TableLayoutPanel();
            this.chtCPU = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chtMemory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.pnlBackground.SuspendLayout();
            this.tlpCharts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtCPU)).BeginInit();
            this.SuspendLayout();
            // 
            // chtMemory
            // 
            chartArea5.Name = "ChartArea1";
            this.chtMemory.ChartAreas.Add(chartArea5);
            this.chtMemory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chtMemory.Location = new System.Drawing.Point(3, 3);
            this.chtMemory.Name = "chtMemory";
            series7.ChartArea = "ChartArea1";
            series7.Name = "Series1";
            this.chtMemory.Series.Add(series7);
            this.chtMemory.Size = new System.Drawing.Size(375, 221);
            this.chtMemory.TabIndex = 4;
            this.chtMemory.Text = "chart1";
            title5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title5.Name = "Memory";
            title5.Text = "Memory";
            this.chtMemory.Titles.Add(title5);
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
            // chtCPU
            // 
            chartArea6.Name = "ChartArea1";
            this.chtCPU.ChartAreas.Add(chartArea6);
            this.chtCPU.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chtCPU.Legends.Add(legend3);
            this.chtCPU.Location = new System.Drawing.Point(384, 3);
            this.chtCPU.Name = "chtCPU";
            series8.BorderWidth = 5;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.LabelForeColor = System.Drawing.Color.DimGray;
            series8.Legend = "Legend1";
            series8.LegendText = "CPU Usage";
            series8.Name = "Series1";
            series9.BorderWidth = 5;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.LegendText = "SQL CPU Usage";
            series9.Name = "Series2";
            this.chtCPU.Series.Add(series8);
            this.chtCPU.Series.Add(series9);
            this.chtCPU.Size = new System.Drawing.Size(375, 221);
            this.chtCPU.TabIndex = 5;
            this.chtCPU.Text = "chart1";
            title6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title6.Name = "Title1";
            title6.Text = "CPU";
            this.chtCPU.Titles.Add(title6);
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
    }
}