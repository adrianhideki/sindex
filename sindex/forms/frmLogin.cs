using MetroFramework;
using MetroFramework.Components;
using sindex.model;
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
        private ConfigurationFile conf;
        private frmMain main;
        public frmLogin(MetroStyleManager metroStyleManager, ConfigurationFile conf, frmMain main)
        {
            InitializeComponent();
            this.metroStyleManager = metroStyleManager;
            this.Refresh();
            this.conf = conf;
            this.main = main;
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
                conf.AddUser(new User(txtCadUser.Text, txtCadSenha.Text, txtCadConfirmarSenha.Text, txtCadEmail.Text, true));
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
                conf.Login(txtUser.Text, txtPassword.Text);
                main.SetVisiblePanelLogin(false);
                main.LoadEnviroment();
                this.Close();
            }
            catch (Exception err)
            {
                main.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
