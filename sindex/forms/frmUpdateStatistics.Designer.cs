namespace sindex.forms
{
    partial class frmUpdateStatistics
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.pnlBG = new MetroFramework.Controls.MetroPanel();
            this.txtDias = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtPercent = new MetroFramework.Controls.MetroTextBox();
            this.txtRows = new MetroFramework.Controls.MetroTextBox();
            this.rbtSamplePercent = new MetroFramework.Controls.MetroRadioButton();
            this.rbtSampleRows = new MetroFramework.Controls.MetroRadioButton();
            this.rbtResample = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.rbtFullScan = new MetroFramework.Controls.MetroRadioButton();
            this.chkMarcarTodos = new MetroFramework.Controls.MetroCheckBox();
            this.lblLinhas = new MetroFramework.Controls.MetroLabel();
            this.grdStats = new MetroFramework.Controls.MetroGrid();
            this.mnuStats = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.criarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.padrãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFiltrar = new MetroFramework.Controls.MetroButton();
            this.txtFiltro = new MetroFramework.Controls.MetroTextBox();
            this.cbxFiltro = new MetroFramework.Controls.MetroComboBox();
            this.chkSomenteTabelasDados = new MetroFramework.Controls.MetroCheckBox();
            this.lblIndex = new MetroFramework.Controls.MetroLabel();
            this.txtScript = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.pnlBG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStats)).BeginInit();
            this.mnuStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // pnlBG
            // 
            this.pnlBG.Controls.Add(this.lblIndex);
            this.pnlBG.Controls.Add(this.txtScript);
            this.pnlBG.Controls.Add(this.chkSomenteTabelasDados);
            this.pnlBG.Controls.Add(this.txtDias);
            this.pnlBG.Controls.Add(this.metroLabel2);
            this.pnlBG.Controls.Add(this.txtPercent);
            this.pnlBG.Controls.Add(this.txtRows);
            this.pnlBG.Controls.Add(this.rbtSamplePercent);
            this.pnlBG.Controls.Add(this.rbtSampleRows);
            this.pnlBG.Controls.Add(this.rbtResample);
            this.pnlBG.Controls.Add(this.metroLabel1);
            this.pnlBG.Controls.Add(this.rbtFullScan);
            this.pnlBG.Controls.Add(this.chkMarcarTodos);
            this.pnlBG.Controls.Add(this.lblLinhas);
            this.pnlBG.Controls.Add(this.grdStats);
            this.pnlBG.Controls.Add(this.btnFiltrar);
            this.pnlBG.Controls.Add(this.txtFiltro);
            this.pnlBG.Controls.Add(this.cbxFiltro);
            this.pnlBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBG.HorizontalScrollbarBarColor = true;
            this.pnlBG.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlBG.HorizontalScrollbarSize = 10;
            this.pnlBG.Location = new System.Drawing.Point(0, 0);
            this.pnlBG.Name = "pnlBG";
            this.pnlBG.Size = new System.Drawing.Size(737, 440);
            this.pnlBG.TabIndex = 0;
            this.pnlBG.VerticalScrollbarBarColor = true;
            this.pnlBG.VerticalScrollbarHighlightOnWheel = false;
            this.pnlBG.VerticalScrollbarSize = 10;
            // 
            // txtDias
            // 
            this.txtDias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtDias.CustomButton.Image = null;
            this.txtDias.CustomButton.Location = new System.Drawing.Point(39, 1);
            this.txtDias.CustomButton.Name = "";
            this.txtDias.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDias.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDias.CustomButton.TabIndex = 1;
            this.txtDias.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDias.CustomButton.UseSelectable = true;
            this.txtDias.CustomButton.Visible = false;
            this.txtDias.Lines = new string[] {
        "0"};
            this.txtDias.Location = new System.Drawing.Point(561, 15);
            this.txtDias.MaxLength = 32767;
            this.txtDias.Name = "txtDias";
            this.txtDias.PasswordChar = '\0';
            this.txtDias.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDias.SelectedText = "";
            this.txtDias.SelectionLength = 0;
            this.txtDias.SelectionStart = 0;
            this.txtDias.ShortcutsEnabled = true;
            this.txtDias.Size = new System.Drawing.Size(61, 23);
            this.txtDias.TabIndex = 21;
            this.txtDias.Text = "0";
            this.txtDias.UseSelectable = true;
            this.txtDias.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDias.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(274, 17);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(286, 19);
            this.metroLabel2.TabIndex = 20;
            this.metroLabel2.Text = "Quantidade de dias desde a última atualização:";
            // 
            // txtPercent
            // 
            // 
            // 
            // 
            this.txtPercent.CustomButton.Image = null;
            this.txtPercent.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.txtPercent.CustomButton.Name = "";
            this.txtPercent.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPercent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPercent.CustomButton.TabIndex = 1;
            this.txtPercent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPercent.CustomButton.UseSelectable = true;
            this.txtPercent.CustomButton.Visible = false;
            this.txtPercent.Enabled = false;
            this.txtPercent.Lines = new string[] {
        "0"};
            this.txtPercent.Location = new System.Drawing.Point(224, 100);
            this.txtPercent.MaxLength = 32767;
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.PasswordChar = '\0';
            this.txtPercent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPercent.SelectedText = "";
            this.txtPercent.SelectionLength = 0;
            this.txtPercent.SelectionStart = 0;
            this.txtPercent.ShortcutsEnabled = true;
            this.txtPercent.Size = new System.Drawing.Size(127, 23);
            this.txtPercent.TabIndex = 19;
            this.txtPercent.Text = "0";
            this.txtPercent.UseSelectable = true;
            this.txtPercent.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPercent.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtRows
            // 
            // 
            // 
            // 
            this.txtRows.CustomButton.Image = null;
            this.txtRows.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.txtRows.CustomButton.Name = "";
            this.txtRows.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRows.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRows.CustomButton.TabIndex = 1;
            this.txtRows.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRows.CustomButton.UseSelectable = true;
            this.txtRows.CustomButton.Visible = false;
            this.txtRows.Enabled = false;
            this.txtRows.Lines = new string[] {
        "0"};
            this.txtRows.Location = new System.Drawing.Point(224, 75);
            this.txtRows.MaxLength = 32767;
            this.txtRows.Name = "txtRows";
            this.txtRows.PasswordChar = '\0';
            this.txtRows.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRows.SelectedText = "";
            this.txtRows.SelectionLength = 0;
            this.txtRows.SelectionStart = 0;
            this.txtRows.ShortcutsEnabled = true;
            this.txtRows.Size = new System.Drawing.Size(127, 23);
            this.txtRows.TabIndex = 18;
            this.txtRows.Text = "0";
            this.txtRows.UseSelectable = true;
            this.txtRows.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRows.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // rbtSamplePercent
            // 
            this.rbtSamplePercent.AutoSize = true;
            this.rbtSamplePercent.Location = new System.Drawing.Point(110, 103);
            this.rbtSamplePercent.Name = "rbtSamplePercent";
            this.rbtSamplePercent.Size = new System.Drawing.Size(108, 15);
            this.rbtSamplePercent.TabIndex = 17;
            this.rbtSamplePercent.Text = "Sample Percent:";
            this.rbtSamplePercent.UseSelectable = true;
            this.rbtSamplePercent.CheckedChanged += new System.EventHandler(this.rbtSamplePercent_CheckedChanged);
            // 
            // rbtSampleRows
            // 
            this.rbtSampleRows.AutoSize = true;
            this.rbtSampleRows.Location = new System.Drawing.Point(110, 80);
            this.rbtSampleRows.Name = "rbtSampleRows";
            this.rbtSampleRows.Size = new System.Drawing.Size(96, 15);
            this.rbtSampleRows.TabIndex = 16;
            this.rbtSampleRows.Text = "Sample Rows:";
            this.rbtSampleRows.UseSelectable = true;
            this.rbtSampleRows.CheckedChanged += new System.EventHandler(this.rbtSampleRows_CheckedChanged);
            // 
            // rbtResample
            // 
            this.rbtResample.AutoSize = true;
            this.rbtResample.Location = new System.Drawing.Point(12, 103);
            this.rbtResample.Name = "rbtResample";
            this.rbtResample.Size = new System.Drawing.Size(74, 15);
            this.rbtResample.TabIndex = 15;
            this.rbtResample.Text = "Resample";
            this.rbtResample.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(11, 50);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(349, 19);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "Opções de geração do script de atualização de estatística:";
            // 
            // rbtFullScan
            // 
            this.rbtFullScan.AutoSize = true;
            this.rbtFullScan.Checked = true;
            this.rbtFullScan.Location = new System.Drawing.Point(12, 80);
            this.rbtFullScan.Name = "rbtFullScan";
            this.rbtFullScan.Size = new System.Drawing.Size(70, 15);
            this.rbtFullScan.TabIndex = 13;
            this.rbtFullScan.TabStop = true;
            this.rbtFullScan.Text = "Full Scan";
            this.rbtFullScan.UseSelectable = true;
            // 
            // chkMarcarTodos
            // 
            this.chkMarcarTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkMarcarTodos.AutoSize = true;
            this.chkMarcarTodos.Location = new System.Drawing.Point(628, 413);
            this.chkMarcarTodos.Name = "chkMarcarTodos";
            this.chkMarcarTodos.Size = new System.Drawing.Size(94, 15);
            this.chkMarcarTodos.TabIndex = 12;
            this.chkMarcarTodos.Text = "Marcar Todos";
            this.chkMarcarTodos.UseSelectable = true;
            this.chkMarcarTodos.CheckedChanged += new System.EventHandler(this.chkMarcarTodos_CheckedChanged);
            // 
            // lblLinhas
            // 
            this.lblLinhas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLinhas.Location = new System.Drawing.Point(481, 408);
            this.lblLinhas.Name = "lblLinhas";
            this.lblLinhas.Size = new System.Drawing.Size(135, 23);
            this.lblLinhas.TabIndex = 9;
            this.lblLinhas.Text = "0 linha(s)";
            this.lblLinhas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grdStats
            // 
            this.grdStats.AllowUserToAddRows = false;
            this.grdStats.AllowUserToDeleteRows = false;
            this.grdStats.AllowUserToResizeRows = false;
            this.grdStats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdStats.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdStats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdStats.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdStats.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdStats.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStats.ContextMenuStrip = this.mnuStats;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdStats.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdStats.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdStats.EnableHeadersVisualStyles = false;
            this.grdStats.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdStats.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdStats.Location = new System.Drawing.Point(12, 138);
            this.grdStats.Name = "grdStats";
            this.grdStats.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdStats.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdStats.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdStats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdStats.ShowEditingIcon = false;
            this.grdStats.Size = new System.Drawing.Size(710, 138);
            this.grdStats.TabIndex = 8;
            this.grdStats.SelectionChanged += new System.EventHandler(this.grdStats_SelectionChanged);
            this.grdStats.DoubleClick += new System.EventHandler(this.grdIndexes_DoubleClick);
            this.grdStats.Resize += new System.EventHandler(this.grdIndexes_Resize);
            // 
            // mnuStats
            // 
            this.mnuStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mnuStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mnuStats.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.mnuStats.Name = "mnuIndexes";
            this.mnuStats.Size = new System.Drawing.Size(251, 48);
            // 
            // criarToolStripMenuItem
            // 
            this.criarToolStripMenuItem.Name = "criarToolStripMenuItem";
            this.criarToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.criarToolStripMenuItem.Text = "Atualizar estatísticas selecionadas";
            this.criarToolStripMenuItem.Click += new System.EventHandler(this.criarToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.padrãoToolStripMenuItem,
            this.gridToolStripMenuItem,
            this.excelToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.relatóriosToolStripMenuItem.Text = "Gerar relatório";
            // 
            // padrãoToolStripMenuItem
            // 
            this.padrãoToolStripMenuItem.Name = "padrãoToolStripMenuItem";
            this.padrãoToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.padrãoToolStripMenuItem.Text = "Padrão";
            this.padrãoToolStripMenuItem.Click += new System.EventHandler(this.padrãoToolStripMenuItem_Click);
            // 
            // gridToolStripMenuItem
            // 
            this.gridToolStripMenuItem.Name = "gridToolStripMenuItem";
            this.gridToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.gridToolStripMenuItem.Text = "Grid";
            this.gridToolStripMenuItem.Click += new System.EventHandler(this.gridToolStripMenuItem_Click);
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.excelToolStripMenuItem.Text = "Excel";
            this.excelToolStripMenuItem.Click += new System.EventHandler(this.excelToolStripMenuItem_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltrar.Location = new System.Drawing.Point(630, 15);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(92, 23);
            this.btnFiltrar.TabIndex = 7;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseSelectable = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtFiltro.CustomButton.Image = null;
            this.txtFiltro.CustomButton.Location = new System.Drawing.Point(108, 1);
            this.txtFiltro.CustomButton.Name = "";
            this.txtFiltro.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFiltro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFiltro.CustomButton.TabIndex = 1;
            this.txtFiltro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFiltro.CustomButton.UseSelectable = true;
            this.txtFiltro.CustomButton.Visible = false;
            this.txtFiltro.Lines = new string[0];
            this.txtFiltro.Location = new System.Drawing.Point(142, 15);
            this.txtFiltro.MaxLength = 32767;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.PasswordChar = '\0';
            this.txtFiltro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFiltro.SelectedText = "";
            this.txtFiltro.SelectionLength = 0;
            this.txtFiltro.SelectionStart = 0;
            this.txtFiltro.ShortcutsEnabled = true;
            this.txtFiltro.Size = new System.Drawing.Size(130, 23);
            this.txtFiltro.TabIndex = 6;
            this.txtFiltro.UseSelectable = true;
            this.txtFiltro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFiltro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbxFiltro
            // 
            this.cbxFiltro.FormattingEnabled = true;
            this.cbxFiltro.ItemHeight = 23;
            this.cbxFiltro.Items.AddRange(new object[] {
            "Database",
            "Table",
            "Stat"});
            this.cbxFiltro.Location = new System.Drawing.Point(12, 12);
            this.cbxFiltro.Name = "cbxFiltro";
            this.cbxFiltro.Size = new System.Drawing.Size(124, 29);
            this.cbxFiltro.TabIndex = 5;
            this.cbxFiltro.UseSelectable = true;
            // 
            // chkSomenteTabelasDados
            // 
            this.chkSomenteTabelasDados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSomenteTabelasDados.AutoSize = true;
            this.chkSomenteTabelasDados.Location = new System.Drawing.Point(551, 108);
            this.chkSomenteTabelasDados.Name = "chkSomenteTabelasDados";
            this.chkSomenteTabelasDados.Size = new System.Drawing.Size(172, 15);
            this.chkSomenteTabelasDados.TabIndex = 22;
            this.chkSomenteTabelasDados.Text = "Somente tabelas com dados";
            this.chkSomenteTabelasDados.UseSelectable = true;
            // 
            // lblIndex
            // 
            this.lblIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIndex.AutoSize = true;
            this.lblIndex.Location = new System.Drawing.Point(15, 279);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(216, 19);
            this.lblIndex.TabIndex = 24;
            this.lblIndex.Text = "Script de atualização de estatísticas:";
            // 
            // txtScript
            // 
            this.txtScript.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtScript.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtScript.Location = new System.Drawing.Point(11, 308);
            this.txtScript.Name = "txtScript";
            this.txtScript.ReadOnly = true;
            this.txtScript.Size = new System.Drawing.Size(711, 99);
            this.txtScript.TabIndex = 23;
            this.txtScript.Text = "";
            // 
            // frmUpdateStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 440);
            this.Controls.Add(this.pnlBG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUpdateStatistics";
            this.Text = "frmMissingIndexes";
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.pnlBG.ResumeLayout(false);
            this.pnlBG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStats)).EndInit();
            this.mnuStats.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroPanel pnlBG;
        private MetroFramework.Controls.MetroTextBox txtFiltro;
        private MetroFramework.Controls.MetroComboBox cbxFiltro;
        private MetroFramework.Controls.MetroButton btnFiltrar;
        private MetroFramework.Controls.MetroGrid grdStats;
        private MetroFramework.Controls.MetroLabel lblLinhas;
        private MetroFramework.Controls.MetroContextMenu mnuStats;
        private System.Windows.Forms.ToolStripMenuItem criarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem padrãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private MetroFramework.Controls.MetroCheckBox chkMarcarTodos;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroRadioButton rbtFullScan;
        private MetroFramework.Controls.MetroTextBox txtPercent;
        private MetroFramework.Controls.MetroTextBox txtRows;
        private MetroFramework.Controls.MetroRadioButton rbtSamplePercent;
        private MetroFramework.Controls.MetroRadioButton rbtSampleRows;
        private MetroFramework.Controls.MetroRadioButton rbtResample;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtDias;
        private MetroFramework.Controls.MetroCheckBox chkSomenteTabelasDados;
        private MetroFramework.Controls.MetroLabel lblIndex;
        private System.Windows.Forms.RichTextBox txtScript;
    }
}