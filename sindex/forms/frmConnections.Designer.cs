namespace sindex.forms
{
    partial class frmConnections
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
            this.lblSegundos = new MetroFramework.Controls.MetroLabel();
            this.tkbSegundos = new MetroFramework.Controls.MetroTrackBar();
            this.chkRefresh = new MetroFramework.Controls.MetroCheckBox();
            this.chkConexoesBloqueadas = new MetroFramework.Controls.MetroCheckBox();
            this.chkIgnorarSQLConections = new MetroFramework.Controls.MetroCheckBox();
            this.chkMarcarTodos = new MetroFramework.Controls.MetroCheckBox();
            this.lbxCampos = new System.Windows.Forms.CheckedListBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnFiltrar = new MetroFramework.Controls.MetroButton();
            this.txtFiltro = new MetroFramework.Controls.MetroTextBox();
            this.cbxFiltro = new MetroFramework.Controls.MetroComboBox();
            this.grdSessios = new MetroFramework.Controls.MetroGrid();
            this.mnuGridView = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.verDetalhesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.matarSessãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.habilitarDesabilitarAutoRefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.padrãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrSession = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.pnlBG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSessios)).BeginInit();
            this.mnuGridView.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // pnlBG
            // 
            this.pnlBG.Controls.Add(this.lblSegundos);
            this.pnlBG.Controls.Add(this.tkbSegundos);
            this.pnlBG.Controls.Add(this.chkRefresh);
            this.pnlBG.Controls.Add(this.chkConexoesBloqueadas);
            this.pnlBG.Controls.Add(this.chkIgnorarSQLConections);
            this.pnlBG.Controls.Add(this.chkMarcarTodos);
            this.pnlBG.Controls.Add(this.lbxCampos);
            this.pnlBG.Controls.Add(this.metroLabel1);
            this.pnlBG.Controls.Add(this.btnFiltrar);
            this.pnlBG.Controls.Add(this.txtFiltro);
            this.pnlBG.Controls.Add(this.cbxFiltro);
            this.pnlBG.Controls.Add(this.grdSessios);
            this.pnlBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBG.HorizontalScrollbarBarColor = true;
            this.pnlBG.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlBG.HorizontalScrollbarSize = 10;
            this.pnlBG.Location = new System.Drawing.Point(0, 0);
            this.pnlBG.Name = "pnlBG";
            this.pnlBG.Size = new System.Drawing.Size(729, 539);
            this.pnlBG.TabIndex = 0;
            this.pnlBG.VerticalScrollbarBarColor = true;
            this.pnlBG.VerticalScrollbarHighlightOnWheel = false;
            this.pnlBG.VerticalScrollbarSize = 10;
            // 
            // lblSegundos
            // 
            this.lblSegundos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.Location = new System.Drawing.Point(227, 508);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(21, 19);
            this.lblSegundos.TabIndex = 14;
            this.lblSegundos.Text = "10";
            // 
            // tkbSegundos
            // 
            this.tkbSegundos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tkbSegundos.BackColor = System.Drawing.Color.Transparent;
            this.tkbSegundos.Location = new System.Drawing.Point(122, 507);
            this.tkbSegundos.Name = "tkbSegundos";
            this.tkbSegundos.Size = new System.Drawing.Size(75, 23);
            this.tkbSegundos.TabIndex = 13;
            this.tkbSegundos.Value = 0;
            this.tkbSegundos.ValueChanged += new System.EventHandler(this.tkbSegundos_ValueChanged);
            // 
            // chkRefresh
            // 
            this.chkRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkRefresh.AutoSize = true;
            this.chkRefresh.Location = new System.Drawing.Point(12, 512);
            this.chkRefresh.Name = "chkRefresh";
            this.chkRefresh.Size = new System.Drawing.Size(91, 15);
            this.chkRefresh.TabIndex = 12;
            this.chkRefresh.Text = "Auto Refresh";
            this.chkRefresh.UseSelectable = true;
            this.chkRefresh.CheckedChanged += new System.EventHandler(this.chkRefresh_CheckedChanged);
            // 
            // chkConexoesBloqueadas
            // 
            this.chkConexoesBloqueadas.AutoSize = true;
            this.chkConexoesBloqueadas.Location = new System.Drawing.Point(339, 175);
            this.chkConexoesBloqueadas.Name = "chkConexoesBloqueadas";
            this.chkConexoesBloqueadas.Size = new System.Drawing.Size(220, 15);
            this.chkConexoesBloqueadas.TabIndex = 11;
            this.chkConexoesBloqueadas.Text = "Listar Somente Conexões Bloqueadas";
            this.chkConexoesBloqueadas.UseSelectable = true;
            // 
            // chkIgnorarSQLConections
            // 
            this.chkIgnorarSQLConections.AutoSize = true;
            this.chkIgnorarSQLConections.Location = new System.Drawing.Point(157, 175);
            this.chkIgnorarSQLConections.Name = "chkIgnorarSQLConections";
            this.chkIgnorarSQLConections.Size = new System.Drawing.Size(176, 15);
            this.chkIgnorarSQLConections.TabIndex = 10;
            this.chkIgnorarSQLConections.Text = "Ignorar Conexões de Sistema";
            this.chkIgnorarSQLConections.UseSelectable = true;
            // 
            // chkMarcarTodos
            // 
            this.chkMarcarTodos.AutoSize = true;
            this.chkMarcarTodos.Location = new System.Drawing.Point(12, 175);
            this.chkMarcarTodos.Name = "chkMarcarTodos";
            this.chkMarcarTodos.Size = new System.Drawing.Size(139, 15);
            this.chkMarcarTodos.TabIndex = 9;
            this.chkMarcarTodos.Text = "Marcar Todas Colunas";
            this.chkMarcarTodos.UseSelectable = true;
            this.chkMarcarTodos.Click += new System.EventHandler(this.chkMarcarTodos_Click);
            // 
            // lbxCampos
            // 
            this.lbxCampos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxCampos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxCampos.ColumnWidth = 200;
            this.lbxCampos.FormattingEnabled = true;
            this.lbxCampos.Location = new System.Drawing.Point(12, 44);
            this.lbxCampos.MultiColumn = true;
            this.lbxCampos.Name = "lbxCampos";
            this.lbxCampos.Size = new System.Drawing.Size(705, 120);
            this.lbxCampos.TabIndex = 8;
            this.lbxCampos.DoubleClick += new System.EventHandler(this.lbxCampos_Enter);
            this.lbxCampos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lbxCampos_KeyUp);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 11);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(47, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Filtrar:";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltrar.Location = new System.Drawing.Point(603, 171);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(114, 23);
            this.btnFiltrar.TabIndex = 5;
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
            this.txtFiltro.CustomButton.Location = new System.Drawing.Point(468, 1);
            this.txtFiltro.CustomButton.Name = "";
            this.txtFiltro.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFiltro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFiltro.CustomButton.TabIndex = 1;
            this.txtFiltro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFiltro.CustomButton.UseSelectable = true;
            this.txtFiltro.CustomButton.Visible = false;
            this.txtFiltro.Lines = new string[0];
            this.txtFiltro.Location = new System.Drawing.Point(227, 10);
            this.txtFiltro.MaxLength = 32767;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.PasswordChar = '\0';
            this.txtFiltro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFiltro.SelectedText = "";
            this.txtFiltro.SelectionLength = 0;
            this.txtFiltro.SelectionStart = 0;
            this.txtFiltro.ShortcutsEnabled = true;
            this.txtFiltro.Size = new System.Drawing.Size(490, 23);
            this.txtFiltro.TabIndex = 4;
            this.txtFiltro.UseSelectable = true;
            this.txtFiltro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFiltro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbxFiltro
            // 
            this.cbxFiltro.FormattingEnabled = true;
            this.cbxFiltro.ItemHeight = 23;
            this.cbxFiltro.Location = new System.Drawing.Point(62, 7);
            this.cbxFiltro.Name = "cbxFiltro";
            this.cbxFiltro.Size = new System.Drawing.Size(157, 29);
            this.cbxFiltro.TabIndex = 3;
            this.cbxFiltro.UseSelectable = true;
            // 
            // grdSessios
            // 
            this.grdSessios.AllowUserToAddRows = false;
            this.grdSessios.AllowUserToDeleteRows = false;
            this.grdSessios.AllowUserToResizeRows = false;
            this.grdSessios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdSessios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdSessios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdSessios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdSessios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdSessios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdSessios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSessios.ContextMenuStrip = this.mnuGridView;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdSessios.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdSessios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdSessios.EnableHeadersVisualStyles = false;
            this.grdSessios.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdSessios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdSessios.Location = new System.Drawing.Point(12, 208);
            this.grdSessios.Name = "grdSessios";
            this.grdSessios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdSessios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdSessios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdSessios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSessios.ShowEditingIcon = false;
            this.grdSessios.Size = new System.Drawing.Size(705, 293);
            this.grdSessios.TabIndex = 2;
            // 
            // mnuGridView
            // 
            this.mnuGridView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mnuGridView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mnuGridView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verDetalhesToolStripMenuItem1,
            this.matarSessãoToolStripMenuItem1,
            this.habilitarDesabilitarAutoRefreshToolStripMenuItem,
            this.imprimirToolStripMenuItem});
            this.mnuGridView.Name = "metroContextMenu1";
            this.mnuGridView.Size = new System.Drawing.Size(257, 114);
            // 
            // verDetalhesToolStripMenuItem1
            // 
            this.verDetalhesToolStripMenuItem1.Name = "verDetalhesToolStripMenuItem1";
            this.verDetalhesToolStripMenuItem1.Size = new System.Drawing.Size(256, 22);
            this.verDetalhesToolStripMenuItem1.Text = "Ver Detalhes";
            this.verDetalhesToolStripMenuItem1.Click += new System.EventHandler(this.verDetalhesToolStripMenuItem_Click);
            // 
            // matarSessãoToolStripMenuItem1
            // 
            this.matarSessãoToolStripMenuItem1.Name = "matarSessãoToolStripMenuItem1";
            this.matarSessãoToolStripMenuItem1.Size = new System.Drawing.Size(256, 22);
            this.matarSessãoToolStripMenuItem1.Text = "Matar Sessão";
            this.matarSessãoToolStripMenuItem1.Click += new System.EventHandler(this.matarSessãoToolStripMenuItem1_Click);
            // 
            // habilitarDesabilitarAutoRefreshToolStripMenuItem
            // 
            this.habilitarDesabilitarAutoRefreshToolStripMenuItem.Name = "habilitarDesabilitarAutoRefreshToolStripMenuItem";
            this.habilitarDesabilitarAutoRefreshToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.habilitarDesabilitarAutoRefreshToolStripMenuItem.Text = "Habilitar / Desabilitar Auto Refresh";
            this.habilitarDesabilitarAutoRefreshToolStripMenuItem.Click += new System.EventHandler(this.habilitarDesabilitarAutoRefreshToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.padrãoToolStripMenuItem,
            this.gridToolStripMenuItem,
            this.excelToolStripMenuItem});
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir Relatório";
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
            // tmrSession
            // 
            this.tmrSession.Tick += new System.EventHandler(this.tmrSession_Tick);
            // 
            // frmConnections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 539);
            this.Controls.Add(this.pnlBG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConnections";
            this.Text = "frmConnections";
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.pnlBG.ResumeLayout(false);
            this.pnlBG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSessios)).EndInit();
            this.mnuGridView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroPanel pnlBG;
        private MetroFramework.Controls.MetroButton btnFiltrar;
        private MetroFramework.Controls.MetroTextBox txtFiltro;
        private MetroFramework.Controls.MetroComboBox cbxFiltro;
        private MetroFramework.Controls.MetroGrid grdSessios;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Timer tmrSession;
        private System.Windows.Forms.CheckedListBox lbxCampos;
        private MetroFramework.Controls.MetroCheckBox chkMarcarTodos;
        private MetroFramework.Controls.MetroCheckBox chkIgnorarSQLConections;
        private MetroFramework.Controls.MetroCheckBox chkConexoesBloqueadas;
        private MetroFramework.Controls.MetroCheckBox chkRefresh;
        private MetroFramework.Controls.MetroContextMenu mnuGridView;
        private System.Windows.Forms.ToolStripMenuItem verDetalhesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem matarSessãoToolStripMenuItem1;
        private MetroFramework.Controls.MetroTrackBar tkbSegundos;
        private MetroFramework.Controls.MetroLabel lblSegundos;
        private System.Windows.Forms.ToolStripMenuItem habilitarDesabilitarAutoRefreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem padrãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
    }
}