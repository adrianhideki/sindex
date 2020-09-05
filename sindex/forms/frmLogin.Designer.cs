namespace sindex.forms
{
    partial class frmLogin
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
            this.pnlLogin = new MetroFramework.Controls.MetroPanel();
            this.tbLogin = new MetroFramework.Controls.MetroTabControl();
            this.tabLogin = new MetroFramework.Controls.MetroTabPage();
            this.lnkCadastrarConta = new MetroFramework.Controls.MetroLink();
            this.lblUsuario = new MetroFramework.Controls.MetroLabel();
            this.lblTitle = new MetroFramework.Controls.MetroLabel();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.lblSenha = new MetroFramework.Controls.MetroLabel();
            this.txtUser = new MetroFramework.Controls.MetroTextBox();
            this.tabSingup = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lnkVoltar = new MetroFramework.Controls.MetroLink();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnCadastrar = new MetroFramework.Controls.MetroButton();
            this.txtCadEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtCadConfirmarSenha = new MetroFramework.Controls.MetroTextBox();
            this.txtCadSenha = new MetroFramework.Controls.MetroTextBox();
            this.txtCadUser = new MetroFramework.Controls.MetroTextBox();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.pnlLogin.SuspendLayout();
            this.tbLogin.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabSingup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlLogin.Controls.Add(this.tbLogin);
            this.pnlLogin.HorizontalScrollbarBarColor = true;
            this.pnlLogin.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlLogin.HorizontalScrollbarSize = 10;
            this.pnlLogin.Location = new System.Drawing.Point(-7, -3);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(385, 693);
            this.pnlLogin.TabIndex = 12;
            this.pnlLogin.VerticalScrollbarBarColor = true;
            this.pnlLogin.VerticalScrollbarHighlightOnWheel = false;
            this.pnlLogin.VerticalScrollbarSize = 10;
            // 
            // tbLogin
            // 
            this.tbLogin.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLogin.Controls.Add(this.tabLogin);
            this.tbLogin.Controls.Add(this.tabSingup);
            this.tbLogin.Location = new System.Drawing.Point(7, 4);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.SelectedIndex = 0;
            this.tbLogin.Size = new System.Drawing.Size(378, 691);
            this.tbLogin.TabIndex = 13;
            this.tbLogin.UseSelectable = true;
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.lnkCadastrarConta);
            this.tabLogin.Controls.Add(this.lblUsuario);
            this.tabLogin.Controls.Add(this.lblTitle);
            this.tabLogin.Controls.Add(this.txtPassword);
            this.tabLogin.Controls.Add(this.btnLogin);
            this.tabLogin.Controls.Add(this.lblSenha);
            this.tabLogin.Controls.Add(this.txtUser);
            this.tabLogin.HorizontalScrollbarBarColor = true;
            this.tabLogin.HorizontalScrollbarHighlightOnWheel = false;
            this.tabLogin.HorizontalScrollbarSize = 10;
            this.tabLogin.Location = new System.Drawing.Point(4, 4);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Size = new System.Drawing.Size(370, 649);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = " ";
            this.tabLogin.VerticalScrollbarBarColor = true;
            this.tabLogin.VerticalScrollbarHighlightOnWheel = false;
            this.tabLogin.VerticalScrollbarSize = 10;
            // 
            // lnkCadastrarConta
            // 
            this.lnkCadastrarConta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lnkCadastrarConta.Location = new System.Drawing.Point(221, 398);
            this.lnkCadastrarConta.Name = "lnkCadastrarConta";
            this.lnkCadastrarConta.Size = new System.Drawing.Size(101, 23);
            this.lnkCadastrarConta.TabIndex = 6;
            this.lnkCadastrarConta.Text = "Cadastrar Conta";
            this.lnkCadastrarConta.UseSelectable = true;
            this.lnkCadastrarConta.Click += new System.EventHandler(this.lnkCadastrarConta_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(38, 235);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(56, 19);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuário:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTitle.Location = new System.Drawing.Point(145, 121);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(60, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "sindex";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(263, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(38, 312);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(285, 23);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnLogin.Location = new System.Drawing.Point(38, 363);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(285, 29);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(38, 290);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(47, 19);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha:";
            // 
            // txtUser
            // 
            this.txtUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.txtUser.CustomButton.Image = null;
            this.txtUser.CustomButton.Location = new System.Drawing.Point(263, 1);
            this.txtUser.CustomButton.Name = "";
            this.txtUser.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUser.CustomButton.TabIndex = 1;
            this.txtUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUser.CustomButton.UseSelectable = true;
            this.txtUser.CustomButton.Visible = false;
            this.txtUser.Lines = new string[0];
            this.txtUser.Location = new System.Drawing.Point(38, 256);
            this.txtUser.MaxLength = 32767;
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUser.SelectedText = "";
            this.txtUser.SelectionLength = 0;
            this.txtUser.SelectionStart = 0;
            this.txtUser.ShortcutsEnabled = true;
            this.txtUser.Size = new System.Drawing.Size(285, 23);
            this.txtUser.TabIndex = 2;
            this.txtUser.UseSelectable = true;
            this.txtUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tabSingup
            // 
            this.tabSingup.Controls.Add(this.metroLabel5);
            this.tabSingup.Controls.Add(this.metroLabel4);
            this.tabSingup.Controls.Add(this.metroLabel3);
            this.tabSingup.Controls.Add(this.metroLabel2);
            this.tabSingup.Controls.Add(this.lnkVoltar);
            this.tabSingup.Controls.Add(this.metroLabel1);
            this.tabSingup.Controls.Add(this.btnCadastrar);
            this.tabSingup.Controls.Add(this.txtCadEmail);
            this.tabSingup.Controls.Add(this.txtCadConfirmarSenha);
            this.tabSingup.Controls.Add(this.txtCadSenha);
            this.tabSingup.Controls.Add(this.txtCadUser);
            this.tabSingup.HorizontalScrollbarBarColor = true;
            this.tabSingup.HorizontalScrollbarHighlightOnWheel = false;
            this.tabSingup.HorizontalScrollbarSize = 10;
            this.tabSingup.Location = new System.Drawing.Point(4, 4);
            this.tabSingup.Name = "tabSingup";
            this.tabSingup.Size = new System.Drawing.Size(370, 649);
            this.tabSingup.TabIndex = 1;
            this.tabSingup.Text = " ";
            this.tabSingup.VerticalScrollbarBarColor = true;
            this.tabSingup.VerticalScrollbarHighlightOnWheel = false;
            this.tabSingup.VerticalScrollbarSize = 10;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(47, 375);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(50, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "e-mail:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(47, 327);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(111, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Confirmar Senha:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(47, 277);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(47, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Senha:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(47, 229);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(56, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Usuário:";
            // 
            // lnkVoltar
            // 
            this.lnkVoltar.Location = new System.Drawing.Point(47, 448);
            this.lnkVoltar.Name = "lnkVoltar";
            this.lnkVoltar.Size = new System.Drawing.Size(75, 23);
            this.lnkVoltar.TabIndex = 9;
            this.lnkVoltar.Text = "Voltar";
            this.lnkVoltar.UseSelectable = true;
            this.lnkVoltar.Click += new System.EventHandler(this.lnkVoltar_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(145, 121);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(60, 25);
            this.metroLabel1.TabIndex = 18;
            this.metroLabel1.Text = "sindex";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(242, 448);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseSelectable = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtCadEmail
            // 
            // 
            // 
            // 
            this.txtCadEmail.CustomButton.Image = null;
            this.txtCadEmail.CustomButton.Location = new System.Drawing.Point(248, 1);
            this.txtCadEmail.CustomButton.Name = "";
            this.txtCadEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCadEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCadEmail.CustomButton.TabIndex = 1;
            this.txtCadEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCadEmail.CustomButton.UseSelectable = true;
            this.txtCadEmail.CustomButton.Visible = false;
            this.txtCadEmail.Lines = new string[0];
            this.txtCadEmail.Location = new System.Drawing.Point(47, 398);
            this.txtCadEmail.MaxLength = 32767;
            this.txtCadEmail.Name = "txtCadEmail";
            this.txtCadEmail.PasswordChar = '\0';
            this.txtCadEmail.PromptText = "E-mail";
            this.txtCadEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCadEmail.SelectedText = "";
            this.txtCadEmail.SelectionLength = 0;
            this.txtCadEmail.SelectionStart = 0;
            this.txtCadEmail.ShortcutsEnabled = true;
            this.txtCadEmail.Size = new System.Drawing.Size(270, 23);
            this.txtCadEmail.TabIndex = 7;
            this.txtCadEmail.UseSelectable = true;
            this.txtCadEmail.WaterMark = "E-mail";
            this.txtCadEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCadEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCadConfirmarSenha
            // 
            // 
            // 
            // 
            this.txtCadConfirmarSenha.CustomButton.Image = null;
            this.txtCadConfirmarSenha.CustomButton.Location = new System.Drawing.Point(248, 1);
            this.txtCadConfirmarSenha.CustomButton.Name = "";
            this.txtCadConfirmarSenha.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCadConfirmarSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCadConfirmarSenha.CustomButton.TabIndex = 1;
            this.txtCadConfirmarSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCadConfirmarSenha.CustomButton.UseSelectable = true;
            this.txtCadConfirmarSenha.CustomButton.Visible = false;
            this.txtCadConfirmarSenha.Lines = new string[0];
            this.txtCadConfirmarSenha.Location = new System.Drawing.Point(47, 348);
            this.txtCadConfirmarSenha.MaxLength = 32767;
            this.txtCadConfirmarSenha.Name = "txtCadConfirmarSenha";
            this.txtCadConfirmarSenha.PasswordChar = '*';
            this.txtCadConfirmarSenha.PromptText = "Confirmar Senha";
            this.txtCadConfirmarSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCadConfirmarSenha.SelectedText = "";
            this.txtCadConfirmarSenha.SelectionLength = 0;
            this.txtCadConfirmarSenha.SelectionStart = 0;
            this.txtCadConfirmarSenha.ShortcutsEnabled = true;
            this.txtCadConfirmarSenha.Size = new System.Drawing.Size(270, 23);
            this.txtCadConfirmarSenha.TabIndex = 5;
            this.txtCadConfirmarSenha.UseSelectable = true;
            this.txtCadConfirmarSenha.WaterMark = "Confirmar Senha";
            this.txtCadConfirmarSenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCadConfirmarSenha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCadSenha
            // 
            // 
            // 
            // 
            this.txtCadSenha.CustomButton.Image = null;
            this.txtCadSenha.CustomButton.Location = new System.Drawing.Point(248, 1);
            this.txtCadSenha.CustomButton.Name = "";
            this.txtCadSenha.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCadSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCadSenha.CustomButton.TabIndex = 1;
            this.txtCadSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCadSenha.CustomButton.UseSelectable = true;
            this.txtCadSenha.CustomButton.Visible = false;
            this.txtCadSenha.Lines = new string[0];
            this.txtCadSenha.Location = new System.Drawing.Point(47, 299);
            this.txtCadSenha.MaxLength = 32767;
            this.txtCadSenha.Name = "txtCadSenha";
            this.txtCadSenha.PasswordChar = '*';
            this.txtCadSenha.PromptText = "Senha";
            this.txtCadSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCadSenha.SelectedText = "";
            this.txtCadSenha.SelectionLength = 0;
            this.txtCadSenha.SelectionStart = 0;
            this.txtCadSenha.ShortcutsEnabled = true;
            this.txtCadSenha.Size = new System.Drawing.Size(270, 23);
            this.txtCadSenha.TabIndex = 3;
            this.txtCadSenha.UseSelectable = true;
            this.txtCadSenha.WaterMark = "Senha";
            this.txtCadSenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCadSenha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCadUser
            // 
            // 
            // 
            // 
            this.txtCadUser.CustomButton.Image = null;
            this.txtCadUser.CustomButton.Location = new System.Drawing.Point(248, 1);
            this.txtCadUser.CustomButton.Name = "";
            this.txtCadUser.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCadUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCadUser.CustomButton.TabIndex = 1;
            this.txtCadUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCadUser.CustomButton.UseSelectable = true;
            this.txtCadUser.CustomButton.Visible = false;
            this.txtCadUser.Lines = new string[0];
            this.txtCadUser.Location = new System.Drawing.Point(47, 251);
            this.txtCadUser.MaxLength = 32767;
            this.txtCadUser.Name = "txtCadUser";
            this.txtCadUser.PasswordChar = '\0';
            this.txtCadUser.PromptText = "Usuário";
            this.txtCadUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCadUser.SelectedText = "";
            this.txtCadUser.SelectionLength = 0;
            this.txtCadUser.SelectionStart = 0;
            this.txtCadUser.ShortcutsEnabled = true;
            this.txtCadUser.Size = new System.Drawing.Size(270, 23);
            this.txtCadUser.TabIndex = 1;
            this.txtCadUser.UseSelectable = true;
            this.txtCadUser.WaterMark = "Usuário";
            this.txtCadUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCadUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            this.metroStyleManager.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 681);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.pnlLogin.ResumeLayout(false);
            this.tbLogin.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.tabSingup.ResumeLayout(false);
            this.tabSingup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlLogin;
        private MetroFramework.Controls.MetroLabel lblTitle;
        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroTextBox txtUser;
        private MetroFramework.Controls.MetroLabel lblSenha;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroLabel lblUsuario;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroTabControl tbLogin;
        private MetroFramework.Controls.MetroTabPage tabLogin;
        private MetroFramework.Controls.MetroTabPage tabSingup;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnCadastrar;
        private MetroFramework.Controls.MetroTextBox txtCadEmail;
        private MetroFramework.Controls.MetroTextBox txtCadConfirmarSenha;
        private MetroFramework.Controls.MetroTextBox txtCadSenha;
        private MetroFramework.Controls.MetroTextBox txtCadUser;
        private MetroFramework.Controls.MetroLink lnkVoltar;
        private MetroFramework.Controls.MetroLink lnkCadastrarConta;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}