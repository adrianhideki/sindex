using MetroFramework;
using MetroFramework.Components;
using sindex.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sindex.forms
{
    public partial class frmLogin : Form
    {
        private Configuration conf;
        private frmMain main;
        private string userError = "";
        private int loginCount = 0;

        public frmLogin(MetroStyleManager metroStyleManager, Configuration conf, frmMain main)
        {
            InitializeComponent();

            this.metroStyleManager.Theme = metroStyleManager.Theme;
            this.metroStyleManager.Style = metroStyleManager.Style;

            this.Refresh();

            this.conf = conf;
            this.main = main;

            cbxPerfilAcesso.SelectedIndex = 0;
            tbLogin.SelectTab(tabLogin);
        }

        private void lnkVoltar_Click(object sender, EventArgs e)
        {
            tbLogin.SelectTab(tabLogin);
        }

        private void lnkCadastrarConta_Click(object sender, EventArgs e)
        {
            tbLogin.SelectTab(tabSingup);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                PerfilAcesso perf = PerfilAcesso.monitoria;

                if (cbxPerfilAcesso.Text == "Administrador")
                {
                    perf = PerfilAcesso.administrador;
                }

                if (cbxPerfilAcesso.Text == "Performance")
                {
                    perf = PerfilAcesso.performance;
                }

                conf.AddUser(new User(txtCadUser.Text, txtCadSenha.Text, txtCadConfirmarSenha.Text, txtCadEmail.Text, true, perf));
                tbLogin.SelectTab(tabLogin);
                main.SaveConfig();

                txtCadUser.Clear();
                txtCadSenha.Clear();
                txtCadConfirmarSenha.Clear();
                txtCadEmail.Clear();
            } catch (Exception err)
            {
                main.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (userError != txtUser.Text)
                {
                    userError = txtUser.Text;
                    loginCount = 0;
                }

                conf.Login(txtUser.Text, txtPassword.Text);
                main.HideMenu(true);
                main.SetUsuarioText(txtUser.Text);
                main.LoadEnviroment(true);
                main.SetPerfilAcesso(conf.users[conf.currentUser].perfil);

                this.Close();
            }
            catch (Exception err)
            {
                loginCount++;
                string errMsg = err.Message;

                if (loginCount >= 3)
                {
                    conf.SetBlockUser(true, userError);
                    main.SaveConfig();
                }

                main.ShowMessage(errMsg, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtPassword.Focus();
                e.Handled = true;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(null, null);
                e.Handled = true;
            }
        }
    }
}