﻿namespace sindex.forms
{
    partial class frmAmbientes
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
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.pnlBackground = new MetroFramework.Controls.MetroPanel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtUpdateChart = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtUpdateTables = new MetroFramework.Controls.MetroTextBox();
            this.btnSelecionarAmbiente = new MetroFramework.Controls.MetroButton();
            this.btnTestarCon = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtDatabase = new MetroFramework.Controls.MetroTextBox();
            this.btnExcluir = new MetroFramework.Controls.MetroButton();
            this.btnAtualizar = new MetroFramework.Controls.MetroButton();
            this.btnAdicionar = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtSenha = new MetroFramework.Controls.MetroTextBox();
            this.txtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.txtServidor = new MetroFramework.Controls.MetroTextBox();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbxAmbiente = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtMinLoadData = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.pnlBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // pnlBackground
            // 
            this.pnlBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBackground.Controls.Add(this.metroLabel9);
            this.pnlBackground.Controls.Add(this.txtMinLoadData);
            this.pnlBackground.Controls.Add(this.metroLabel8);
            this.pnlBackground.Controls.Add(this.txtUpdateChart);
            this.pnlBackground.Controls.Add(this.metroLabel7);
            this.pnlBackground.Controls.Add(this.txtUpdateTables);
            this.pnlBackground.Controls.Add(this.btnSelecionarAmbiente);
            this.pnlBackground.Controls.Add(this.btnTestarCon);
            this.pnlBackground.Controls.Add(this.metroLabel6);
            this.pnlBackground.Controls.Add(this.txtDatabase);
            this.pnlBackground.Controls.Add(this.btnExcluir);
            this.pnlBackground.Controls.Add(this.btnAtualizar);
            this.pnlBackground.Controls.Add(this.btnAdicionar);
            this.pnlBackground.Controls.Add(this.metroLabel5);
            this.pnlBackground.Controls.Add(this.metroLabel4);
            this.pnlBackground.Controls.Add(this.metroLabel3);
            this.pnlBackground.Controls.Add(this.metroLabel2);
            this.pnlBackground.Controls.Add(this.txtSenha);
            this.pnlBackground.Controls.Add(this.txtUsuario);
            this.pnlBackground.Controls.Add(this.txtServidor);
            this.pnlBackground.Controls.Add(this.txtNome);
            this.pnlBackground.Controls.Add(this.metroLabel1);
            this.pnlBackground.Controls.Add(this.cbxAmbiente);
            this.pnlBackground.HorizontalScrollbarBarColor = true;
            this.pnlBackground.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlBackground.HorizontalScrollbarSize = 10;
            this.pnlBackground.Location = new System.Drawing.Point(-1, -1);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(806, 506);
            this.pnlBackground.TabIndex = 0;
            this.pnlBackground.VerticalScrollbarBarColor = true;
            this.pnlBackground.VerticalScrollbarHighlightOnWheel = false;
            this.pnlBackground.VerticalScrollbarSize = 10;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(23, 345);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(203, 19);
            this.metroLabel8.TabIndex = 19;
            this.metroLabel8.Text = "Segundos para atualizar gráficos:";
            // 
            // txtUpdateChart
            // 
            this.txtUpdateChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtUpdateChart.CustomButton.Image = null;
            this.txtUpdateChart.CustomButton.Location = new System.Drawing.Point(730, 1);
            this.txtUpdateChart.CustomButton.Name = "";
            this.txtUpdateChart.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUpdateChart.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUpdateChart.CustomButton.TabIndex = 1;
            this.txtUpdateChart.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUpdateChart.CustomButton.UseSelectable = true;
            this.txtUpdateChart.CustomButton.Visible = false;
            this.txtUpdateChart.Lines = new string[0];
            this.txtUpdateChart.Location = new System.Drawing.Point(23, 367);
            this.txtUpdateChart.MaxLength = 32767;
            this.txtUpdateChart.Name = "txtUpdateChart";
            this.txtUpdateChart.PasswordChar = '\0';
            this.txtUpdateChart.PromptText = "Segundos para atualizar gráficos";
            this.txtUpdateChart.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUpdateChart.SelectedText = "";
            this.txtUpdateChart.SelectionLength = 0;
            this.txtUpdateChart.SelectionStart = 0;
            this.txtUpdateChart.ShortcutsEnabled = true;
            this.txtUpdateChart.Size = new System.Drawing.Size(752, 23);
            this.txtUpdateChart.TabIndex = 20;
            this.txtUpdateChart.UseSelectable = true;
            this.txtUpdateChart.WaterMark = "Segundos para atualizar gráficos";
            this.txtUpdateChart.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUpdateChart.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtUpdateChart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUpdateTables_KeyPress);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(23, 296);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(187, 19);
            this.metroLabel7.TabIndex = 17;
            this.metroLabel7.Text = "Minutos para atualizar tabelas:";
            // 
            // txtUpdateTables
            // 
            this.txtUpdateTables.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtUpdateTables.CustomButton.Image = null;
            this.txtUpdateTables.CustomButton.Location = new System.Drawing.Point(730, 1);
            this.txtUpdateTables.CustomButton.Name = "";
            this.txtUpdateTables.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUpdateTables.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUpdateTables.CustomButton.TabIndex = 1;
            this.txtUpdateTables.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUpdateTables.CustomButton.UseSelectable = true;
            this.txtUpdateTables.CustomButton.Visible = false;
            this.txtUpdateTables.Lines = new string[0];
            this.txtUpdateTables.Location = new System.Drawing.Point(23, 319);
            this.txtUpdateTables.MaxLength = 32767;
            this.txtUpdateTables.Name = "txtUpdateTables";
            this.txtUpdateTables.PasswordChar = '\0';
            this.txtUpdateTables.PromptText = "Minutos para atualizar as tabelas";
            this.txtUpdateTables.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUpdateTables.SelectedText = "";
            this.txtUpdateTables.SelectionLength = 0;
            this.txtUpdateTables.SelectionStart = 0;
            this.txtUpdateTables.ShortcutsEnabled = true;
            this.txtUpdateTables.Size = new System.Drawing.Size(752, 23);
            this.txtUpdateTables.TabIndex = 18;
            this.txtUpdateTables.UseSelectable = true;
            this.txtUpdateTables.WaterMark = "Minutos para atualizar as tabelas";
            this.txtUpdateTables.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUpdateTables.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtUpdateTables.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUpdateTables_KeyPress);
            // 
            // btnSelecionarAmbiente
            // 
            this.btnSelecionarAmbiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelecionarAmbiente.Location = new System.Drawing.Point(655, 467);
            this.btnSelecionarAmbiente.Name = "btnSelecionarAmbiente";
            this.btnSelecionarAmbiente.Size = new System.Drawing.Size(120, 23);
            this.btnSelecionarAmbiente.TabIndex = 0;
            this.btnSelecionarAmbiente.Text = "Selecionar Ambiente";
            this.btnSelecionarAmbiente.UseSelectable = true;
            this.btnSelecionarAmbiente.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnTestarCon
            // 
            this.btnTestarCon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTestarCon.Location = new System.Drawing.Point(151, 467);
            this.btnTestarCon.Name = "btnTestarCon";
            this.btnTestarCon.Size = new System.Drawing.Size(120, 23);
            this.btnTestarCon.TabIndex = 4;
            this.btnTestarCon.Text = "Testar Conexão";
            this.btnTestarCon.UseSelectable = true;
            this.btnTestarCon.Click += new System.EventHandler(this.btnTestarCon_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 247);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(39, 19);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "Base:";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtDatabase.CustomButton.Image = null;
            this.txtDatabase.CustomButton.Location = new System.Drawing.Point(730, 1);
            this.txtDatabase.CustomButton.Name = "";
            this.txtDatabase.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDatabase.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDatabase.CustomButton.TabIndex = 1;
            this.txtDatabase.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDatabase.CustomButton.UseSelectable = true;
            this.txtDatabase.CustomButton.Visible = false;
            this.txtDatabase.Lines = new string[0];
            this.txtDatabase.Location = new System.Drawing.Point(23, 269);
            this.txtDatabase.MaxLength = 32767;
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.PasswordChar = '\0';
            this.txtDatabase.PromptText = "Banco de dados default";
            this.txtDatabase.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDatabase.SelectedText = "";
            this.txtDatabase.SelectionLength = 0;
            this.txtDatabase.SelectionStart = 0;
            this.txtDatabase.ShortcutsEnabled = true;
            this.txtDatabase.Size = new System.Drawing.Size(752, 23);
            this.txtDatabase.TabIndex = 16;
            this.txtDatabase.UseSelectable = true;
            this.txtDatabase.WaterMark = "Banco de dados default";
            this.txtDatabase.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDatabase.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDatabase.TextChanged += new System.EventHandler(this.txtServidor_TextChanged);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.Location = new System.Drawing.Point(277, 467);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(120, 23);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseSelectable = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtualizar.Location = new System.Drawing.Point(403, 467);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(120, 23);
            this.btnAtualizar.TabIndex = 2;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseSelectable = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionar.Location = new System.Drawing.Point(529, 467);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(120, 23);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseSelectable = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 200);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(47, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Senha:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 152);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(56, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Usuário:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 104);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Servidor:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 56);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(130, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Nome do Ambiente:";
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtSenha.CustomButton.Image = null;
            this.txtSenha.CustomButton.Location = new System.Drawing.Point(730, 1);
            this.txtSenha.CustomButton.Name = "";
            this.txtSenha.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSenha.CustomButton.TabIndex = 1;
            this.txtSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSenha.CustomButton.UseSelectable = true;
            this.txtSenha.CustomButton.Visible = false;
            this.txtSenha.Lines = new string[0];
            this.txtSenha.Location = new System.Drawing.Point(23, 222);
            this.txtSenha.MaxLength = 32767;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.PromptText = "Senha";
            this.txtSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSenha.SelectedText = "";
            this.txtSenha.SelectionLength = 0;
            this.txtSenha.SelectionStart = 0;
            this.txtSenha.ShortcutsEnabled = true;
            this.txtSenha.Size = new System.Drawing.Size(752, 23);
            this.txtSenha.TabIndex = 15;
            this.txtSenha.UseSelectable = true;
            this.txtSenha.WaterMark = "Senha";
            this.txtSenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSenha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSenha.TextChanged += new System.EventHandler(this.txtServidor_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtUsuario.CustomButton.Image = null;
            this.txtUsuario.CustomButton.Location = new System.Drawing.Point(730, 1);
            this.txtUsuario.CustomButton.Name = "";
            this.txtUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsuario.CustomButton.TabIndex = 1;
            this.txtUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsuario.CustomButton.UseSelectable = true;
            this.txtUsuario.CustomButton.Visible = false;
            this.txtUsuario.Lines = new string[0];
            this.txtUsuario.Location = new System.Drawing.Point(23, 174);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.PromptText = "Usuário";
            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.ShortcutsEnabled = true;
            this.txtUsuario.Size = new System.Drawing.Size(752, 23);
            this.txtUsuario.TabIndex = 14;
            this.txtUsuario.UseSelectable = true;
            this.txtUsuario.WaterMark = "Usuário";
            this.txtUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtServidor_TextChanged);
            // 
            // txtServidor
            // 
            this.txtServidor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtServidor.CustomButton.Image = null;
            this.txtServidor.CustomButton.Location = new System.Drawing.Point(730, 1);
            this.txtServidor.CustomButton.Name = "";
            this.txtServidor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtServidor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtServidor.CustomButton.TabIndex = 1;
            this.txtServidor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtServidor.CustomButton.UseSelectable = true;
            this.txtServidor.CustomButton.Visible = false;
            this.txtServidor.Lines = new string[0];
            this.txtServidor.Location = new System.Drawing.Point(23, 126);
            this.txtServidor.MaxLength = 32767;
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.PasswordChar = '\0';
            this.txtServidor.PromptText = "Servidor";
            this.txtServidor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtServidor.SelectedText = "";
            this.txtServidor.SelectionLength = 0;
            this.txtServidor.SelectionStart = 0;
            this.txtServidor.ShortcutsEnabled = true;
            this.txtServidor.Size = new System.Drawing.Size(752, 23);
            this.txtServidor.TabIndex = 13;
            this.txtServidor.UseSelectable = true;
            this.txtServidor.WaterMark = "Servidor";
            this.txtServidor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtServidor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtServidor.TextChanged += new System.EventHandler(this.txtServidor_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtNome.CustomButton.Image = null;
            this.txtNome.CustomButton.Location = new System.Drawing.Point(730, 1);
            this.txtNome.CustomButton.Name = "";
            this.txtNome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNome.CustomButton.TabIndex = 1;
            this.txtNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNome.CustomButton.UseSelectable = true;
            this.txtNome.CustomButton.Visible = false;
            this.txtNome.Lines = new string[0];
            this.txtNome.Location = new System.Drawing.Point(23, 78);
            this.txtNome.MaxLength = 32767;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.PromptText = "Nome do ambiente";
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(752, 23);
            this.txtNome.TabIndex = 12;
            this.txtNome.UseSelectable = true;
            this.txtNome.WaterMark = "Nome do ambiente";
            this.txtNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(19, 25);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Ambiente:";
            // 
            // cbxAmbiente
            // 
            this.cbxAmbiente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxAmbiente.FormattingEnabled = true;
            this.cbxAmbiente.ItemHeight = 23;
            this.cbxAmbiente.Location = new System.Drawing.Point(112, 20);
            this.cbxAmbiente.Name = "cbxAmbiente";
            this.cbxAmbiente.Size = new System.Drawing.Size(663, 29);
            this.cbxAmbiente.TabIndex = 11;
            this.cbxAmbiente.UseSelectable = true;
            this.cbxAmbiente.SelectedIndexChanged += new System.EventHandler(this.cbxAmbiente_SelectedIndexChanged);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(23, 393);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(299, 19);
            this.metroLabel9.TabIndex = 21;
            this.metroLabel9.Text = "Minutos para monitoramento em segundo plano:";
            // 
            // txtMinLoadData
            // 
            this.txtMinLoadData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtMinLoadData.CustomButton.Image = null;
            this.txtMinLoadData.CustomButton.Location = new System.Drawing.Point(730, 1);
            this.txtMinLoadData.CustomButton.Name = "";
            this.txtMinLoadData.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMinLoadData.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMinLoadData.CustomButton.TabIndex = 1;
            this.txtMinLoadData.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMinLoadData.CustomButton.UseSelectable = true;
            this.txtMinLoadData.CustomButton.Visible = false;
            this.txtMinLoadData.Lines = new string[0];
            this.txtMinLoadData.Location = new System.Drawing.Point(23, 415);
            this.txtMinLoadData.MaxLength = 32767;
            this.txtMinLoadData.Name = "txtMinLoadData";
            this.txtMinLoadData.PasswordChar = '\0';
            this.txtMinLoadData.PromptText = "Minutos para monitoramento em segundo plano";
            this.txtMinLoadData.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMinLoadData.SelectedText = "";
            this.txtMinLoadData.SelectionLength = 0;
            this.txtMinLoadData.SelectionStart = 0;
            this.txtMinLoadData.ShortcutsEnabled = true;
            this.txtMinLoadData.Size = new System.Drawing.Size(752, 23);
            this.txtMinLoadData.TabIndex = 22;
            this.txtMinLoadData.UseSelectable = true;
            this.txtMinLoadData.WaterMark = "Minutos para monitoramento em segundo plano";
            this.txtMinLoadData.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMinLoadData.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmAmbientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.pnlBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAmbientes";
            this.Text = "frmAmbientes";
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroPanel pnlBackground;
        private MetroFramework.Controls.MetroButton btnSelecionarAmbiente;
        private MetroFramework.Controls.MetroButton btnTestarCon;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtDatabase;
        private MetroFramework.Controls.MetroButton btnExcluir;
        private MetroFramework.Controls.MetroButton btnAtualizar;
        private MetroFramework.Controls.MetroButton btnAdicionar;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtSenha;
        private MetroFramework.Controls.MetroTextBox txtUsuario;
        private MetroFramework.Controls.MetroTextBox txtServidor;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cbxAmbiente;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtUpdateTables;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtUpdateChart;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtMinLoadData;
    }
}