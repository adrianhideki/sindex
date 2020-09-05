namespace sindex.forms
{
    partial class frmDatabases
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
            this.pnlBackground = new MetroFramework.Controls.MetroPanel();
            this.lnkSalvarFechar = new MetroFramework.Controls.MetroLink();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtFiltrar = new MetroFramework.Controls.MetroTextBox();
            this.chkMarcarTodos = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.grdDatabases = new MetroFramework.Controls.MetroGrid();
            this.mnuGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.marcarSelecionadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desmarcarSelecionadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.database_uid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.database_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.server_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatabases)).BeginInit();
            this.mnuGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBackground.Controls.Add(this.lnkSalvarFechar);
            this.pnlBackground.Controls.Add(this.metroLabel2);
            this.pnlBackground.Controls.Add(this.txtFiltrar);
            this.pnlBackground.Controls.Add(this.chkMarcarTodos);
            this.pnlBackground.Controls.Add(this.metroLabel1);
            this.pnlBackground.Controls.Add(this.grdDatabases);
            this.pnlBackground.HorizontalScrollbarBarColor = true;
            this.pnlBackground.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlBackground.HorizontalScrollbarSize = 10;
            this.pnlBackground.Location = new System.Drawing.Point(0, -2);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(984, 592);
            this.pnlBackground.TabIndex = 0;
            this.pnlBackground.VerticalScrollbarBarColor = true;
            this.pnlBackground.VerticalScrollbarHighlightOnWheel = false;
            this.pnlBackground.VerticalScrollbarSize = 10;
            // 
            // lnkSalvarFechar
            // 
            this.lnkSalvarFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkSalvarFechar.Location = new System.Drawing.Point(822, 553);
            this.lnkSalvarFechar.Name = "lnkSalvarFechar";
            this.lnkSalvarFechar.Size = new System.Drawing.Size(145, 23);
            this.lnkSalvarFechar.TabIndex = 7;
            this.lnkSalvarFechar.Text = "Salvar e Fechar";
            this.lnkSalvarFechar.UseSelectable = true;
            this.lnkSalvarFechar.Click += new System.EventHandler(this.lnkSalvarFechar_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(12, 517);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(67, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Pesquisar:";
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.txtFiltrar.CustomButton.Image = null;
            this.txtFiltrar.CustomButton.Location = new System.Drawing.Point(321, 1);
            this.txtFiltrar.CustomButton.Name = "";
            this.txtFiltrar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFiltrar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFiltrar.CustomButton.TabIndex = 1;
            this.txtFiltrar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFiltrar.CustomButton.UseSelectable = true;
            this.txtFiltrar.CustomButton.Visible = false;
            this.txtFiltrar.Lines = new string[0];
            this.txtFiltrar.Location = new System.Drawing.Point(85, 516);
            this.txtFiltrar.MaxLength = 32767;
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.PasswordChar = '\0';
            this.txtFiltrar.PromptText = "Pesquisar...";
            this.txtFiltrar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFiltrar.SelectedText = "";
            this.txtFiltrar.SelectionLength = 0;
            this.txtFiltrar.SelectionStart = 0;
            this.txtFiltrar.ShortcutsEnabled = true;
            this.txtFiltrar.Size = new System.Drawing.Size(343, 23);
            this.txtFiltrar.TabIndex = 5;
            this.txtFiltrar.UseSelectable = true;
            this.txtFiltrar.WaterMark = "Pesquisar...";
            this.txtFiltrar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFiltrar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFiltrar.TextChanged += new System.EventHandler(this.txtFiltrar_TextChanged);
            // 
            // chkMarcarTodos
            // 
            this.chkMarcarTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkMarcarTodos.AutoSize = true;
            this.chkMarcarTodos.Location = new System.Drawing.Point(873, 521);
            this.chkMarcarTodos.Name = "chkMarcarTodos";
            this.chkMarcarTodos.Size = new System.Drawing.Size(94, 15);
            this.chkMarcarTodos.TabIndex = 4;
            this.chkMarcarTodos.Text = "Marcar Todos";
            this.chkMarcarTodos.UseSelectable = true;
            this.chkMarcarTodos.Click += new System.EventHandler(this.chkMarcarTodos_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(12, 11);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(432, 25);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Selecione o(s) banco(s) de dados que deseja monitorar:";
            // 
            // grdDatabases
            // 
            this.grdDatabases.AllowUserToAddRows = false;
            this.grdDatabases.AllowUserToDeleteRows = false;
            this.grdDatabases.AllowUserToResizeRows = false;
            this.grdDatabases.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDatabases.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdDatabases.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdDatabases.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdDatabases.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatabases.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdDatabases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatabases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.database_uid,
            this.database_name,
            this.update_date,
            this.ativo,
            this.server_id});
            this.grdDatabases.ContextMenuStrip = this.mnuGrid;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDatabases.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdDatabases.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdDatabases.EnableHeadersVisualStyles = false;
            this.grdDatabases.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdDatabases.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdDatabases.Location = new System.Drawing.Point(11, 44);
            this.grdDatabases.Name = "grdDatabases";
            this.grdDatabases.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatabases.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdDatabases.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdDatabases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatabases.ShowCellErrors = false;
            this.grdDatabases.ShowCellToolTips = false;
            this.grdDatabases.ShowEditingIcon = false;
            this.grdDatabases.ShowRowErrors = false;
            this.grdDatabases.Size = new System.Drawing.Size(956, 460);
            this.grdDatabases.TabIndex = 2;
            this.grdDatabases.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatabases_CellContentClick);
            this.grdDatabases.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdDatabases_CellMouseDoubleClick);
            // 
            // mnuGrid
            // 
            this.mnuGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcarSelecionadosToolStripMenuItem,
            this.desmarcarSelecionadosToolStripMenuItem});
            this.mnuGrid.Name = "mnuGrid";
            this.mnuGrid.Size = new System.Drawing.Size(203, 48);
            // 
            // marcarSelecionadosToolStripMenuItem
            // 
            this.marcarSelecionadosToolStripMenuItem.Name = "marcarSelecionadosToolStripMenuItem";
            this.marcarSelecionadosToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.marcarSelecionadosToolStripMenuItem.Text = "Marcar Selecionados";
            this.marcarSelecionadosToolStripMenuItem.Click += new System.EventHandler(this.marcarSelecionadosToolStripMenuItem_Click);
            // 
            // desmarcarSelecionadosToolStripMenuItem
            // 
            this.desmarcarSelecionadosToolStripMenuItem.Name = "desmarcarSelecionadosToolStripMenuItem";
            this.desmarcarSelecionadosToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.desmarcarSelecionadosToolStripMenuItem.Text = "Desmarcar Selecionados";
            this.desmarcarSelecionadosToolStripMenuItem.Click += new System.EventHandler(this.desmarcarSelecionadosToolStripMenuItem_Click);
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // database_uid
            // 
            this.database_uid.DataPropertyName = "database_uid";
            this.database_uid.HeaderText = "ID";
            this.database_uid.Name = "database_uid";
            // 
            // database_name
            // 
            this.database_name.DataPropertyName = "database_name";
            this.database_name.HeaderText = "Banco de Dados";
            this.database_name.Name = "database_name";
            this.database_name.Width = 300;
            // 
            // update_date
            // 
            this.update_date.DataPropertyName = "update_date";
            this.update_date.HeaderText = "Data Última Atualização";
            this.update_date.Name = "update_date";
            this.update_date.Width = 150;
            // 
            // ativo
            // 
            this.ativo.DataPropertyName = "ativo";
            this.ativo.HeaderText = "Monitorar";
            this.ativo.Name = "ativo";
            this.ativo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ativo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // server_id
            // 
            this.server_id.DataPropertyName = "server_id";
            this.server_id.HeaderText = "ID Servidor";
            this.server_id.Name = "server_id";
            this.server_id.Visible = false;
            // 
            // frmDatabases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 586);
            this.Controls.Add(this.pnlBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDatabases";
            this.Text = "frmDatabases";
            this.Load += new System.EventHandler(this.frmDatabases_Load);
            this.Resize += new System.EventHandler(this.frmDatabases_Resize);
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatabases)).EndInit();
            this.mnuGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlBackground;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroGrid grdDatabases;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtFiltrar;
        private MetroFramework.Controls.MetroCheckBox chkMarcarTodos;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ContextMenuStrip mnuGrid;
        private System.Windows.Forms.ToolStripMenuItem marcarSelecionadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desmarcarSelecionadosToolStripMenuItem;
        private MetroFramework.Controls.MetroLink lnkSalvarFechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn database_uid;
        private System.Windows.Forms.DataGridViewTextBoxColumn database_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn update_date;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn server_id;
    }
}