namespace sindex.forms
{
    partial class frmFragmentedIndexes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.pnlBG = new MetroFramework.Controls.MetroPanel();
            this.chkMarcarTodos = new MetroFramework.Controls.MetroCheckBox();
            this.lblLinhas = new MetroFramework.Controls.MetroLabel();
            this.grdIndexes = new MetroFramework.Controls.MetroGrid();
            this.mnuIndexes = new MetroFramework.Controls.MetroContextMenu(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.grdIndexes)).BeginInit();
            this.mnuIndexes.SuspendLayout();
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
            this.pnlBG.Controls.Add(this.chkMarcarTodos);
            this.pnlBG.Controls.Add(this.lblLinhas);
            this.pnlBG.Controls.Add(this.grdIndexes);
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
            // grdIndexes
            // 
            this.grdIndexes.AllowUserToAddRows = false;
            this.grdIndexes.AllowUserToDeleteRows = false;
            this.grdIndexes.AllowUserToResizeRows = false;
            this.grdIndexes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdIndexes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdIndexes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdIndexes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdIndexes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdIndexes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdIndexes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdIndexes.ContextMenuStrip = this.mnuIndexes;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdIndexes.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdIndexes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdIndexes.EnableHeadersVisualStyles = false;
            this.grdIndexes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdIndexes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdIndexes.Location = new System.Drawing.Point(12, 71);
            this.grdIndexes.Name = "grdIndexes";
            this.grdIndexes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdIndexes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdIndexes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdIndexes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdIndexes.ShowEditingIcon = false;
            this.grdIndexes.Size = new System.Drawing.Size(710, 205);
            this.grdIndexes.TabIndex = 8;
            this.grdIndexes.SelectionChanged += new System.EventHandler(this.grdIndexes_SelectionChanged);
            this.grdIndexes.DoubleClick += new System.EventHandler(this.grdIndexes_DoubleClick);
            this.grdIndexes.Resize += new System.EventHandler(this.grdIndexes_Resize);
            // 
            // mnuIndexes
            // 
            this.mnuIndexes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mnuIndexes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mnuIndexes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.mnuIndexes.Name = "mnuIndexes";
            this.mnuIndexes.Size = new System.Drawing.Size(264, 48);
            // 
            // criarToolStripMenuItem
            // 
            this.criarToolStripMenuItem.Name = "criarToolStripMenuItem";
            this.criarToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.criarToolStripMenuItem.Text = "Desfragmentar indices selecionados";
            this.criarToolStripMenuItem.Click += new System.EventHandler(this.criarToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.padrãoToolStripMenuItem,
            this.gridToolStripMenuItem,
            this.excelToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
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
            this.btnFiltrar.Location = new System.Drawing.Point(608, 15);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(114, 23);
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
            this.txtFiltro.CustomButton.Location = new System.Drawing.Point(403, 1);
            this.txtFiltro.CustomButton.Name = "";
            this.txtFiltro.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFiltro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFiltro.CustomButton.TabIndex = 1;
            this.txtFiltro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFiltro.CustomButton.UseSelectable = true;
            this.txtFiltro.CustomButton.Visible = false;
            this.txtFiltro.Lines = new string[0];
            this.txtFiltro.Location = new System.Drawing.Point(177, 15);
            this.txtFiltro.MaxLength = 32767;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.PasswordChar = '\0';
            this.txtFiltro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFiltro.SelectedText = "";
            this.txtFiltro.SelectionLength = 0;
            this.txtFiltro.SelectionStart = 0;
            this.txtFiltro.ShortcutsEnabled = true;
            this.txtFiltro.Size = new System.Drawing.Size(425, 23);
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
            "Table"});
            this.cbxFiltro.Location = new System.Drawing.Point(12, 12);
            this.cbxFiltro.Name = "cbxFiltro";
            this.cbxFiltro.Size = new System.Drawing.Size(157, 29);
            this.cbxFiltro.TabIndex = 5;
            this.cbxFiltro.UseSelectable = true;
            // 
            // chkSomenteTabelasDados
            // 
            this.chkSomenteTabelasDados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSomenteTabelasDados.AutoSize = true;
            this.chkSomenteTabelasDados.Location = new System.Drawing.Point(549, 48);
            this.chkSomenteTabelasDados.Name = "chkSomenteTabelasDados";
            this.chkSomenteTabelasDados.Size = new System.Drawing.Size(173, 15);
            this.chkSomenteTabelasDados.TabIndex = 13;
            this.chkSomenteTabelasDados.Text = "Somente Tabelas com dados";
            this.chkSomenteTabelasDados.UseSelectable = true;
            // 
            // lblIndex
            // 
            this.lblIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIndex.AutoSize = true;
            this.lblIndex.Location = new System.Drawing.Point(15, 279);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(232, 19);
            this.lblIndex.TabIndex = 26;
            this.lblIndex.Text = "Script de desfragmentação de índices:";
            // 
            // txtScript
            // 
            this.txtScript.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtScript.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtScript.Location = new System.Drawing.Point(11, 306);
            this.txtScript.Name = "txtScript";
            this.txtScript.ReadOnly = true;
            this.txtScript.Size = new System.Drawing.Size(711, 99);
            this.txtScript.TabIndex = 25;
            this.txtScript.Text = "";
            // 
            // frmFragmentedIndexes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 440);
            this.Controls.Add(this.pnlBG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFragmentedIndexes";
            this.Text = "frmMissingIndexes";
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.pnlBG.ResumeLayout(false);
            this.pnlBG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdIndexes)).EndInit();
            this.mnuIndexes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroPanel pnlBG;
        private MetroFramework.Controls.MetroTextBox txtFiltro;
        private MetroFramework.Controls.MetroComboBox cbxFiltro;
        private MetroFramework.Controls.MetroButton btnFiltrar;
        private MetroFramework.Controls.MetroGrid grdIndexes;
        private MetroFramework.Controls.MetroLabel lblLinhas;
        private MetroFramework.Controls.MetroContextMenu mnuIndexes;
        private System.Windows.Forms.ToolStripMenuItem criarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem padrãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private MetroFramework.Controls.MetroCheckBox chkMarcarTodos;
        private MetroFramework.Controls.MetroCheckBox chkSomenteTabelasDados;
        private MetroFramework.Controls.MetroLabel lblIndex;
        private System.Windows.Forms.RichTextBox txtScript;
    }
}