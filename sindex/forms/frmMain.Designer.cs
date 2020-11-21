namespace sindex
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.pnlButtom = new System.Windows.Forms.Panel();
            this.lblLastUpdate = new MetroFramework.Controls.MetroLabel();
            this.lblAmbiente = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lblUsuario = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.pnlBgMenu = new System.Windows.Forms.Panel();
            this.pnlMenuLogo = new System.Windows.Forms.Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.btnMenuConfiguracoes = new System.Windows.Forms.Button();
            this.pnlSubMenuConfig = new System.Windows.Forms.Panel();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnAtualizarDados = new System.Windows.Forms.Button();
            this.btnBanco = new System.Windows.Forms.Button();
            this.btnAmbientes = new System.Windows.Forms.Button();
            this.btnMenuTuning = new System.Windows.Forms.Button();
            this.pnlSubMenuTuning = new System.Windows.Forms.Panel();
            this.btnEditarIndexes = new System.Windows.Forms.Button();
            this.btnDefrag = new System.Windows.Forms.Button();
            this.btnStatisticas = new System.Windows.Forms.Button();
            this.btnMissIndex = new System.Windows.Forms.Button();
            this.btnMenuMonitoramento = new System.Windows.Forms.Button();
            this.pnlSubMenuMonitoramento = new System.Windows.Forms.Panel();
            this.btnTopQueries = new System.Windows.Forms.Button();
            this.btnRecursos = new System.Windows.Forms.Button();
            this.btnConexoes = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlMenuSistema = new System.Windows.Forms.Panel();
            this.btnMenuLogout = new System.Windows.Forms.Button();
            this.btnMenuSair = new System.Windows.Forms.Button();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.btnMenuSistema = new System.Windows.Forms.Button();
            this.tmrNotification = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.mnuNotify = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.pnlButtom.SuspendLayout();
            this.pnlMenuLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.pnlSubMenuConfig.SuspendLayout();
            this.pnlSubMenuTuning.SuspendLayout();
            this.pnlSubMenuMonitoramento.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlMenuSistema.SuspendLayout();
            this.mnuNotify.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            this.metroStyleManager.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pnlButtom
            // 
            this.pnlButtom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.pnlButtom.Controls.Add(this.lblLastUpdate);
            this.pnlButtom.Controls.Add(this.lblAmbiente);
            this.pnlButtom.Controls.Add(this.metroLabel3);
            this.pnlButtom.Controls.Add(this.lblUsuario);
            this.pnlButtom.Controls.Add(this.metroLabel1);
            this.pnlButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtom.Location = new System.Drawing.Point(200, 579);
            this.pnlButtom.Name = "pnlButtom";
            this.pnlButtom.Size = new System.Drawing.Size(800, 33);
            this.pnlButtom.TabIndex = 1;
            // 
            // lblLastUpdate
            // 
            this.lblLastUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastUpdate.Location = new System.Drawing.Point(581, 8);
            this.lblLastUpdate.Name = "lblLastUpdate";
            this.lblLastUpdate.Size = new System.Drawing.Size(211, 19);
            this.lblLastUpdate.TabIndex = 4;
            this.lblLastUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAmbiente
            // 
            this.lblAmbiente.AutoSize = true;
            this.lblAmbiente.Location = new System.Drawing.Point(260, 8);
            this.lblAmbiente.Name = "lblAmbiente";
            this.lblAmbiente.Size = new System.Drawing.Size(66, 19);
            this.lblAmbiente.TabIndex = 3;
            this.lblAmbiente.Text = "Ambiente";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(185, 8);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(69, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Ambiente:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(72, 8);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(35, 19);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "User";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(10, 8);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Usuário:";
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(200, 60);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(800, 519);
            this.pnlForm.TabIndex = 2;
            // 
            // pnlBgMenu
            // 
            this.pnlBgMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlBgMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlBgMenu.Location = new System.Drawing.Point(-1, 5);
            this.pnlBgMenu.Name = "pnlBgMenu";
            this.pnlBgMenu.Size = new System.Drawing.Size(201, 625);
            this.pnlBgMenu.TabIndex = 3;
            // 
            // pnlMenuLogo
            // 
            this.pnlMenuLogo.Controls.Add(this.imgLogo);
            this.pnlMenuLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuLogo.Name = "pnlMenuLogo";
            this.pnlMenuLogo.Size = new System.Drawing.Size(183, 80);
            this.pnlMenuLogo.TabIndex = 0;
            // 
            // imgLogo
            // 
            this.imgLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgLogo.Image = global::sindex.Properties.Resources.performance__1_;
            this.imgLogo.Location = new System.Drawing.Point(58, 10);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(66, 55);
            this.imgLogo.TabIndex = 1;
            this.imgLogo.TabStop = false;
            // 
            // btnMenuConfiguracoes
            // 
            this.btnMenuConfiguracoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuConfiguracoes.FlatAppearance.BorderSize = 0;
            this.btnMenuConfiguracoes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnMenuConfiguracoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnMenuConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuConfiguracoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuConfiguracoes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMenuConfiguracoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuConfiguracoes.Location = new System.Drawing.Point(0, 80);
            this.btnMenuConfiguracoes.Name = "btnMenuConfiguracoes";
            this.btnMenuConfiguracoes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenuConfiguracoes.Size = new System.Drawing.Size(183, 38);
            this.btnMenuConfiguracoes.TabIndex = 1;
            this.btnMenuConfiguracoes.Text = "Configurações";
            this.btnMenuConfiguracoes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuConfiguracoes.UseVisualStyleBackColor = true;
            this.btnMenuConfiguracoes.Click += new System.EventHandler(this.btnMenuConfiguracoes_Click);
            // 
            // pnlSubMenuConfig
            // 
            this.pnlSubMenuConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pnlSubMenuConfig.Controls.Add(this.btnUsuarios);
            this.pnlSubMenuConfig.Controls.Add(this.btnAtualizarDados);
            this.pnlSubMenuConfig.Controls.Add(this.btnBanco);
            this.pnlSubMenuConfig.Controls.Add(this.btnAmbientes);
            this.pnlSubMenuConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuConfig.Location = new System.Drawing.Point(0, 118);
            this.pnlSubMenuConfig.Name = "pnlSubMenuConfig";
            this.pnlSubMenuConfig.Size = new System.Drawing.Size(183, 160);
            this.pnlSubMenuConfig.TabIndex = 2;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 114);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(183, 38);
            this.btnUsuarios.TabIndex = 5;
            this.btnUsuarios.Text = "Usuários";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnAtualizarDados
            // 
            this.btnAtualizarDados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAtualizarDados.FlatAppearance.BorderSize = 0;
            this.btnAtualizarDados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnAtualizarDados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnAtualizarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarDados.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAtualizarDados.Location = new System.Drawing.Point(0, 76);
            this.btnAtualizarDados.Name = "btnAtualizarDados";
            this.btnAtualizarDados.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAtualizarDados.Size = new System.Drawing.Size(183, 38);
            this.btnAtualizarDados.TabIndex = 4;
            this.btnAtualizarDados.Text = "Atualizar Dados";
            this.btnAtualizarDados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizarDados.UseVisualStyleBackColor = true;
            this.btnAtualizarDados.Click += new System.EventHandler(this.btnAtualizarDados_Click);
            // 
            // btnBanco
            // 
            this.btnBanco.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBanco.FlatAppearance.BorderSize = 0;
            this.btnBanco.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnBanco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanco.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBanco.Location = new System.Drawing.Point(0, 38);
            this.btnBanco.Name = "btnBanco";
            this.btnBanco.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnBanco.Size = new System.Drawing.Size(183, 38);
            this.btnBanco.TabIndex = 3;
            this.btnBanco.Text = "Bancos de dados";
            this.btnBanco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanco.UseVisualStyleBackColor = true;
            this.btnBanco.Click += new System.EventHandler(this.btnBanco_Click);
            // 
            // btnAmbientes
            // 
            this.btnAmbientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAmbientes.FlatAppearance.BorderSize = 0;
            this.btnAmbientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnAmbientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnAmbientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmbientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmbientes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAmbientes.Location = new System.Drawing.Point(0, 0);
            this.btnAmbientes.Name = "btnAmbientes";
            this.btnAmbientes.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAmbientes.Size = new System.Drawing.Size(183, 38);
            this.btnAmbientes.TabIndex = 2;
            this.btnAmbientes.Text = "Ambientes";
            this.btnAmbientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAmbientes.UseVisualStyleBackColor = true;
            this.btnAmbientes.Click += new System.EventHandler(this.btnAmbientes_Click);
            // 
            // btnMenuTuning
            // 
            this.btnMenuTuning.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuTuning.FlatAppearance.BorderSize = 0;
            this.btnMenuTuning.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnMenuTuning.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnMenuTuning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuTuning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuTuning.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMenuTuning.Location = new System.Drawing.Point(0, 278);
            this.btnMenuTuning.Name = "btnMenuTuning";
            this.btnMenuTuning.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenuTuning.Size = new System.Drawing.Size(183, 38);
            this.btnMenuTuning.TabIndex = 3;
            this.btnMenuTuning.Text = "Performance";
            this.btnMenuTuning.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuTuning.UseVisualStyleBackColor = true;
            this.btnMenuTuning.Click += new System.EventHandler(this.btnMenuTuning_Click);
            // 
            // pnlSubMenuTuning
            // 
            this.pnlSubMenuTuning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pnlSubMenuTuning.Controls.Add(this.btnEditarIndexes);
            this.pnlSubMenuTuning.Controls.Add(this.btnDefrag);
            this.pnlSubMenuTuning.Controls.Add(this.btnStatisticas);
            this.pnlSubMenuTuning.Controls.Add(this.btnMissIndex);
            this.pnlSubMenuTuning.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuTuning.Location = new System.Drawing.Point(0, 316);
            this.pnlSubMenuTuning.Name = "pnlSubMenuTuning";
            this.pnlSubMenuTuning.Size = new System.Drawing.Size(183, 161);
            this.pnlSubMenuTuning.TabIndex = 5;
            this.pnlSubMenuTuning.Visible = false;
            // 
            // btnEditarIndexes
            // 
            this.btnEditarIndexes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditarIndexes.FlatAppearance.BorderSize = 0;
            this.btnEditarIndexes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnEditarIndexes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnEditarIndexes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarIndexes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarIndexes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEditarIndexes.Location = new System.Drawing.Point(0, 114);
            this.btnEditarIndexes.Name = "btnEditarIndexes";
            this.btnEditarIndexes.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnEditarIndexes.Size = new System.Drawing.Size(183, 38);
            this.btnEditarIndexes.TabIndex = 5;
            this.btnEditarIndexes.Text = "Editar índices";
            this.btnEditarIndexes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarIndexes.UseVisualStyleBackColor = true;
            this.btnEditarIndexes.Click += new System.EventHandler(this.btnEditarIndexes_Click);
            // 
            // btnDefrag
            // 
            this.btnDefrag.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDefrag.FlatAppearance.BorderSize = 0;
            this.btnDefrag.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnDefrag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnDefrag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefrag.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDefrag.Location = new System.Drawing.Point(0, 76);
            this.btnDefrag.Name = "btnDefrag";
            this.btnDefrag.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnDefrag.Size = new System.Drawing.Size(183, 38);
            this.btnDefrag.TabIndex = 4;
            this.btnDefrag.Text = "Desfragmentação";
            this.btnDefrag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDefrag.UseVisualStyleBackColor = true;
            this.btnDefrag.Click += new System.EventHandler(this.btnDefrag_Click);
            // 
            // btnStatisticas
            // 
            this.btnStatisticas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStatisticas.FlatAppearance.BorderSize = 0;
            this.btnStatisticas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnStatisticas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnStatisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatisticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatisticas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStatisticas.Location = new System.Drawing.Point(0, 38);
            this.btnStatisticas.Name = "btnStatisticas";
            this.btnStatisticas.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnStatisticas.Size = new System.Drawing.Size(183, 38);
            this.btnStatisticas.TabIndex = 3;
            this.btnStatisticas.Text = "Estatísticas";
            this.btnStatisticas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatisticas.UseVisualStyleBackColor = true;
            this.btnStatisticas.Click += new System.EventHandler(this.btnStatisticas_Click);
            // 
            // btnMissIndex
            // 
            this.btnMissIndex.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMissIndex.FlatAppearance.BorderSize = 0;
            this.btnMissIndex.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnMissIndex.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnMissIndex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMissIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMissIndex.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMissIndex.Location = new System.Drawing.Point(0, 0);
            this.btnMissIndex.Name = "btnMissIndex";
            this.btnMissIndex.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnMissIndex.Size = new System.Drawing.Size(183, 38);
            this.btnMissIndex.TabIndex = 2;
            this.btnMissIndex.Text = "Índices Faltantes";
            this.btnMissIndex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMissIndex.UseVisualStyleBackColor = true;
            this.btnMissIndex.Click += new System.EventHandler(this.btnMissIndex_Click);
            // 
            // btnMenuMonitoramento
            // 
            this.btnMenuMonitoramento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuMonitoramento.FlatAppearance.BorderSize = 0;
            this.btnMenuMonitoramento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnMenuMonitoramento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnMenuMonitoramento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuMonitoramento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuMonitoramento.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMenuMonitoramento.Location = new System.Drawing.Point(0, 477);
            this.btnMenuMonitoramento.Name = "btnMenuMonitoramento";
            this.btnMenuMonitoramento.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenuMonitoramento.Size = new System.Drawing.Size(183, 38);
            this.btnMenuMonitoramento.TabIndex = 6;
            this.btnMenuMonitoramento.Text = "Monitoramento";
            this.btnMenuMonitoramento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuMonitoramento.UseVisualStyleBackColor = true;
            this.btnMenuMonitoramento.Click += new System.EventHandler(this.btnMenuMonitoramento_Click);
            // 
            // pnlSubMenuMonitoramento
            // 
            this.pnlSubMenuMonitoramento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pnlSubMenuMonitoramento.Controls.Add(this.btnTopQueries);
            this.pnlSubMenuMonitoramento.Controls.Add(this.btnRecursos);
            this.pnlSubMenuMonitoramento.Controls.Add(this.btnConexoes);
            this.pnlSubMenuMonitoramento.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuMonitoramento.Location = new System.Drawing.Point(0, 515);
            this.pnlSubMenuMonitoramento.Name = "pnlSubMenuMonitoramento";
            this.pnlSubMenuMonitoramento.Size = new System.Drawing.Size(183, 122);
            this.pnlSubMenuMonitoramento.TabIndex = 7;
            this.pnlSubMenuMonitoramento.Visible = false;
            // 
            // btnTopQueries
            // 
            this.btnTopQueries.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTopQueries.FlatAppearance.BorderSize = 0;
            this.btnTopQueries.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnTopQueries.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnTopQueries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopQueries.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopQueries.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTopQueries.Location = new System.Drawing.Point(0, 76);
            this.btnTopQueries.Name = "btnTopQueries";
            this.btnTopQueries.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnTopQueries.Size = new System.Drawing.Size(183, 38);
            this.btnTopQueries.TabIndex = 4;
            this.btnTopQueries.Text = "Consultas";
            this.btnTopQueries.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTopQueries.UseVisualStyleBackColor = true;
            this.btnTopQueries.Click += new System.EventHandler(this.btnTopQueries_Click);
            // 
            // btnRecursos
            // 
            this.btnRecursos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecursos.FlatAppearance.BorderSize = 0;
            this.btnRecursos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnRecursos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnRecursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecursos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRecursos.Location = new System.Drawing.Point(0, 38);
            this.btnRecursos.Name = "btnRecursos";
            this.btnRecursos.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnRecursos.Size = new System.Drawing.Size(183, 38);
            this.btnRecursos.TabIndex = 3;
            this.btnRecursos.Text = "DashBoard";
            this.btnRecursos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecursos.UseVisualStyleBackColor = true;
            this.btnRecursos.Click += new System.EventHandler(this.btnRecursos_Click);
            // 
            // btnConexoes
            // 
            this.btnConexoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConexoes.FlatAppearance.BorderSize = 0;
            this.btnConexoes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnConexoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnConexoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConexoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConexoes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnConexoes.Location = new System.Drawing.Point(0, 0);
            this.btnConexoes.Name = "btnConexoes";
            this.btnConexoes.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnConexoes.Size = new System.Drawing.Size(183, 38);
            this.btnConexoes.TabIndex = 2;
            this.btnConexoes.Text = "Conexões";
            this.btnConexoes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConexoes.UseVisualStyleBackColor = true;
            this.btnConexoes.Click += new System.EventHandler(this.btnConexoes_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.AutoScroll = true;
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlMenu.Controls.Add(this.pnlMenuSistema);
            this.pnlMenu.Controls.Add(this.btnMenuSistema);
            this.pnlMenu.Controls.Add(this.pnlSubMenuMonitoramento);
            this.pnlMenu.Controls.Add(this.btnMenuMonitoramento);
            this.pnlMenu.Controls.Add(this.pnlSubMenuTuning);
            this.pnlMenu.Controls.Add(this.btnMenuTuning);
            this.pnlMenu.Controls.Add(this.pnlSubMenuConfig);
            this.pnlMenu.Controls.Add(this.btnMenuConfiguracoes);
            this.pnlMenu.Controls.Add(this.pnlMenuLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 60);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 552);
            this.pnlMenu.TabIndex = 0;
            // 
            // pnlMenuSistema
            // 
            this.pnlMenuSistema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pnlMenuSistema.Controls.Add(this.btnMenuLogout);
            this.pnlMenuSistema.Controls.Add(this.btnMenuSair);
            this.pnlMenuSistema.Controls.Add(this.btnAjuda);
            this.pnlMenuSistema.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuSistema.Location = new System.Drawing.Point(0, 675);
            this.pnlMenuSistema.Name = "pnlMenuSistema";
            this.pnlMenuSistema.Size = new System.Drawing.Size(183, 122);
            this.pnlMenuSistema.TabIndex = 13;
            this.pnlMenuSistema.Visible = false;
            // 
            // btnMenuLogout
            // 
            this.btnMenuLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuLogout.FlatAppearance.BorderSize = 0;
            this.btnMenuLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnMenuLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnMenuLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMenuLogout.Location = new System.Drawing.Point(0, 76);
            this.btnMenuLogout.Name = "btnMenuLogout";
            this.btnMenuLogout.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnMenuLogout.Size = new System.Drawing.Size(183, 38);
            this.btnMenuLogout.TabIndex = 13;
            this.btnMenuLogout.Text = "Logout";
            this.btnMenuLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuLogout.UseVisualStyleBackColor = true;
            this.btnMenuLogout.Click += new System.EventHandler(this.btnMenuLogout_Click);
            // 
            // btnMenuSair
            // 
            this.btnMenuSair.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuSair.FlatAppearance.BorderSize = 0;
            this.btnMenuSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnMenuSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnMenuSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuSair.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMenuSair.Location = new System.Drawing.Point(0, 38);
            this.btnMenuSair.Name = "btnMenuSair";
            this.btnMenuSair.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnMenuSair.Size = new System.Drawing.Size(183, 38);
            this.btnMenuSair.TabIndex = 12;
            this.btnMenuSair.Text = "Sair";
            this.btnMenuSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuSair.UseVisualStyleBackColor = true;
            this.btnMenuSair.Click += new System.EventHandler(this.btnMenuSair_Click);
            // 
            // btnAjuda
            // 
            this.btnAjuda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAjuda.FlatAppearance.BorderSize = 0;
            this.btnAjuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnAjuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnAjuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjuda.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAjuda.Location = new System.Drawing.Point(0, 0);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAjuda.Size = new System.Drawing.Size(183, 38);
            this.btnAjuda.TabIndex = 11;
            this.btnAjuda.Text = "Ajuda";
            this.btnAjuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjuda.UseVisualStyleBackColor = true;
            this.btnAjuda.Visible = false;
            this.btnAjuda.Click += new System.EventHandler(this.btnAjuda_Click);
            // 
            // btnMenuSistema
            // 
            this.btnMenuSistema.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuSistema.FlatAppearance.BorderSize = 0;
            this.btnMenuSistema.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnMenuSistema.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnMenuSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuSistema.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMenuSistema.Location = new System.Drawing.Point(0, 637);
            this.btnMenuSistema.Name = "btnMenuSistema";
            this.btnMenuSistema.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenuSistema.Size = new System.Drawing.Size(183, 38);
            this.btnMenuSistema.TabIndex = 12;
            this.btnMenuSistema.Text = "Sistema";
            this.btnMenuSistema.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuSistema.UseVisualStyleBackColor = true;
            this.btnMenuSistema.Click += new System.EventHandler(this.btnMenuSistema_Click);
            // 
            // tmrNotification
            // 
            this.tmrNotification.Interval = 1000;
            this.tmrNotification.Tick += new System.EventHandler(this.tmrNotification_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.mnuNotify;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Visible = true;
            // 
            // mnuNotify
            // 
            this.mnuNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.mnuNotify.Name = "mnuNotify";
            this.mnuNotify.Size = new System.Drawing.Size(101, 48);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 630);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlButtom);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlBgMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 18);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.pnlButtom.ResumeLayout(false);
            this.pnlButtom.PerformLayout();
            this.pnlMenuLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.pnlSubMenuConfig.ResumeLayout(false);
            this.pnlSubMenuTuning.ResumeLayout(false);
            this.pnlSubMenuMonitoramento.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenuSistema.ResumeLayout(false);
            this.mnuNotify.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private System.Windows.Forms.Panel pnlButtom;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Panel pnlBgMenu;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlSubMenuMonitoramento;
        private System.Windows.Forms.Button btnRecursos;
        private System.Windows.Forms.Button btnConexoes;
        private System.Windows.Forms.Button btnMenuMonitoramento;
        private System.Windows.Forms.Panel pnlSubMenuTuning;
        private System.Windows.Forms.Button btnDefrag;
        private System.Windows.Forms.Button btnStatisticas;
        private System.Windows.Forms.Button btnMissIndex;
        private System.Windows.Forms.Button btnMenuTuning;
        private System.Windows.Forms.Panel pnlSubMenuConfig;
        private System.Windows.Forms.Button btnBanco;
        private System.Windows.Forms.Button btnAmbientes;
        private System.Windows.Forms.Button btnMenuConfiguracoes;
        private System.Windows.Forms.Panel pnlMenuLogo;
        private System.Windows.Forms.PictureBox imgLogo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblUsuario;
        private MetroFramework.Controls.MetroLabel lblAmbiente;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Button btnAtualizarDados;
        private System.Windows.Forms.Button btnTopQueries;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Panel pnlMenuSistema;
        private System.Windows.Forms.Button btnMenuLogout;
        private System.Windows.Forms.Button btnMenuSair;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.Button btnMenuSistema;
        private System.Windows.Forms.Button btnEditarIndexes;
        private System.Windows.Forms.Timer tmrNotification;
        private MetroFramework.Controls.MetroLabel lblLastUpdate;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private MetroFramework.Controls.MetroContextMenu mnuNotify;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

