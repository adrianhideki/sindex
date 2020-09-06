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
        private Form CurrentForm;

        public frmMain()
        {
            InitializeComponent();
            configuration = new Configuration();
            this.Theme = metroStyleManager.Theme;
            this.Style = metroStyleManager.Style;

            jsonPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            jsonPath += "\\sindex.config";

            SetMenuDesing();
            LoadConfig();

            LoadLogin();
        }

        #region Configurações
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
        public void ShowMessage(string message, string title, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            metroFunctions.ShowMessage(this, message, title, buttons, icon);
        }
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
        #endregion

        #region LoadForms
        private void LoadForm(Form frm, Control parent, DockStyle dockStyle = DockStyle.Fill)
        {
            if (CurrentForm != null)
                CurrentForm.Close();

            CurrentForm = frm;
            CurrentForm.TopLevel = false;
            CurrentForm.TopMost = true;
            parent.Controls.Add(CurrentForm);
            CurrentForm.Dock = dockStyle;
            CurrentForm.StartPosition = FormStartPosition.CenterParent;
            CurrentForm.Show();
        }
        public void LoadLogin()
        {
            this.configuration.currentUser = -1;
            this.configuration.currentConfiguration = -1;

            HideMenu(false);
            LoadForm(new frmLogin(this.metroStyleManager, configuration, this), pnlForm, DockStyle.Left);
        }
        public void LoadEnviroment()
        {
            LoadForm(new frmAmbientes(this.metroStyleManager, configuration, this), pnlForm);
        }
        public void LoadTables()
        {
            LoadForm(new frmLoadTables(metroStyleManager, configuration, this), pnlForm);
        }
        public void LoadDatabase()
        {
            LoadForm(new frmDatabases(metroStyleManager, configuration, this), pnlForm);
        }
        public void LoadDashboard()
        {
            LoadForm(new frmDashboard(metroStyleManager, configuration, this), pnlForm);
        }
        #endregion

        #region menuItens
        private void hideSubMenu()
        {
            if (pnlSubMenuConfig.Visible) pnlSubMenuConfig.Visible = false;
            if (pnlSubMenuTuning.Visible) pnlSubMenuTuning.Visible = false;
            if (pnlSubMenuMonitoramento.Visible) pnlSubMenuMonitoramento.Visible = false;
        }

        public void HideMenu(bool val)
        {
            pnlMenu.Visible = val;
            pnlBgMenu.Visible = val;
            this.Refresh();
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void SetMenuDesing()
        {
            pnlSubMenuConfig.Visible = false;
            pnlSubMenuTuning.Visible = false;
            pnlSubMenuMonitoramento.Visible = false;
        }
        private void btnMenuConfiguracoes_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubMenuConfig);
        }
        private void btnMenuTuning_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubMenuTuning);
        }
        private void btnMenuMonitoramento_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubMenuMonitoramento);
        }
        #endregion

        private void btnMenuSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenuLogout_Click(object sender, EventArgs e)
        {
            LoadLogin();
        }

        private void btnAmbientes_Click(object sender, EventArgs e)
        {
            LoadEnviroment();
        }

        private void btnBanco_Click(object sender, EventArgs e)
        {
            LoadDatabase();
        }

        private void btnConexoes_Click(object sender, EventArgs e)
        {

        }

        private void btnRecursos_Click(object sender, EventArgs e)
        {
            LoadDashboard();
        }
    }
}