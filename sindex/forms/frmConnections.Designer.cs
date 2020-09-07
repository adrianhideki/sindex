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
            this.grdSessios = new MetroFramework.Controls.MetroGrid();
            this.cbxFiltro = new MetroFramework.Controls.MetroComboBox();
            this.txtFiltro = new MetroFramework.Controls.MetroTextBox();
            this.btnFiltrar = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tmrSession = new System.Windows.Forms.Timer(this.components);
            this.lbxCampos = new System.Windows.Forms.CheckedListBox();
            this.chkMarcarTodos = new MetroFramework.Controls.MetroCheckBox();
            this.chkIgnorarSQLConections = new MetroFramework.Controls.MetroCheckBox();
            this.chkConexoesBloqueadas = new MetroFramework.Controls.MetroCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.pnlBG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSessios)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // pnlBG
            // 
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
            this.grdSessios.Size = new System.Drawing.Size(705, 298);
            this.grdSessios.TabIndex = 2;
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
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 11);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(47, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Filtrar:";
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
    }
}