using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;
using sindex.model;
using sindex.forms;
using static System.Net.WebRequestMethods;
using System.IO;

namespace sindex
{
    public partial class frmMain : MetroForm
    {
        Credentials credentials;
        public string jsonPath = "";
        private static string passPharse = "s1nd3x@hideki";
        public ConfigurationFile configuration = null; 

        public frmMain()
        {
            InitializeComponent();
            configuration = new ConfigurationFile();
            this.Theme = metroStyleManager.Theme;
            this.Style = metroStyleManager.Style;
            jsonPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            jsonPath += "\\sindex.config";

            if (System.IO.File.Exists(jsonPath))
            {
                StreamReader sr = new StreamReader(jsonPath);
                string configFile = sr.ReadToEnd();
                configFile = StringCrypt.Decrypt(configFile, passPharse);
                configuration.LoadFromJson(configFile);
            }

            Form frm = new frmLogin(this.metroStyleManager, configuration, this);
            LoadForm(frm, pnlLogin);
        }

        public void ShowMessage(string message, string title, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            metroFunctions.ShowMessage(this, message, title, buttons, icon);
        }

    private async void btnLogin_Click(object sender, EventArgs e)
        {
            //credentials = new Credentials(txtUser.Text, txtPassword.Text, txtServer.Text);
            //dbConnect db = new dbConnect(credentials);

            //string errMsg = "";
            //int errCode = 0;

            //var sqlVersion = db.executeQuery("SELECT @@VERSION AS Version", new Dapper.DynamicParameters(), "master", out errMsg, out errCode);

            //if (errCode != 0)
            //{
            //    metroFunctions.ShowMessage(this, errMsg, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}


            //string version = "";

            //foreach (dynamic row  in sqlVersion)
            //{
            //    version = row.Version;
            //}

            //lblVersao.Text = version;
            //pnlLogin.Visible = false;

            //LoadTables();
        }

        private void LoadForm(Form frm, Control parent)
        {
            frm.TopLevel = false;
            frm.TopMost = true;
            parent.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Show();
        }

        private async void LoadTables()
        {
            frmLoadTables frm = new frmLoadTables(metroStyleManager, credentials);
            frm.FormClosing += new FormClosingEventHandler(frmLoad_FormClosing);
            LoadForm(frm, this);
        }

        private void frmLoad_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoadDatabaseScreen();
        }

        private void LoadDatabaseScreen()
        {
            frmDatabases frm = new frmDatabases(metroStyleManager, credentials);
            LoadForm(frm, this);
        }

        private void frmMain_MaximumSizeChanged(object sender, EventArgs e)
        {

        }

        private void lblCriarConta_Click(object sender, EventArgs e)
        {

        }
    }
}
