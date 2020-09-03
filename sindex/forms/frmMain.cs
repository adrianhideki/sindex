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
using sindex.utils;
using sindex.forms;
using static System.Net.WebRequestMethods;
using System.IO;
using Newtonsoft.Json;

namespace sindex
{
    public partial class frmMain : MetroForm
    {
        Credentials credentials;
        public string jsonPath = "";
        private static string passPharse = "s1nd3x@hideki";
        public Configuration configuration = null;
        public string databaseSindex = "";
        public dbConnect dbCon;
        public Credentials cred;

        public void SetConnectionSettings()
        {
            databaseSindex = configuration.users[configuration.currentUser].enviroments[configuration.currentConfiguration].GetDatabase();
            cred = configuration.users[configuration.currentUser].enviroments[configuration.currentConfiguration].GetCredentials();
            dbCon = new dbConnect(cred);
        }

        public Credentials GetCredentials()
        {
            return this.cred;
        }

        public dbConnect GetDbConnect()
        {
            return this.dbCon;
        }

        public string GetDatabaseName()
        {
            return this.databaseSindex;
        }

        public frmMain()
        {
            InitializeComponent();
            configuration = new Configuration();
            this.Theme = metroStyleManager.Theme;
            this.Style = metroStyleManager.Style;
            jsonPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            jsonPath += "\\sindex.config";

            LoadConfig();
            Form frm = new frmLogin(this.metroStyleManager, configuration, this);
            LoadForm(frm, pnlLogin);
        }

        public void SaveConfig()
        {
            string json = JsonConvert.SerializeObject(configuration, Formatting.Indented);
            json = StringCrypt.Encrypt(json, passPharse);

            System.IO.File.WriteAllText(jsonPath, json);
        }

        public void LoadConfig()
        {
            if (System.IO.File.Exists(jsonPath))
            {
                StreamReader sr = new StreamReader(jsonPath);
                string configFile = sr.ReadToEnd();
                configFile = StringCrypt.Decrypt(configFile, passPharse);
                configuration.LoadFromJson(configFile);
                sr.Close();
                sr.Dispose();
            }
        }

        public void SetVisiblePanelLogin (bool val){
            pnlLogin.Visible = val;
        }

        public void ShowMessage(string message, string title, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            metroFunctions.ShowMessage(this, message, title, buttons, icon);
        }

        public void LoadEnviroment()
        {
            Form frm = new frmAmbientes(this.metroStyleManager, configuration, this);
            LoadForm(frm, this);
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

        public void LoadDatabase()
        {
            frmDatabases frm = new frmDatabases(metroStyleManager, configuration,this);
            LoadForm(frm, this);
        }

        private void frmMain_MaximumSizeChanged(object sender, EventArgs e)
        {

        }
    }
}
