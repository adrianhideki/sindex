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
        public string jsonPath = "";
        private static string passPharse = "s1nd3x@hideki";
        public Configuration configuration = null;

        #region variáveis de status
        public string databaseSindex = "";
        public dbConnect dbCon;
        public Credentials cred;
        public int minutesToUpdateTable = 5;
        public int secondsToUpdateChart = 5;

        private Form CurrentForm;
        #endregion

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
        public DialogResult ShowMessage(string message, string title, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            return metroFunctions.ShowMessage(this, message, title, buttons, icon);
        }
        public void SetConnectionSettings()
        {
            databaseSindex = configuration.users[configuration.currentUser].enviroments[configuration.currentConfiguration].GetDatabase();
            cred = configuration.users[configuration.currentUser].enviroments[configuration.currentConfiguration].GetCredentials();
            dbCon = new dbConnect(cred);
            minutesToUpdateTable = configuration.users[configuration.currentUser].enviroments[configuration.currentConfiguration].minutesToRefreshTables;
            secondsToUpdateChart = configuration.users[configuration.currentUser].enviroments[configuration.currentConfiguration].secondsToRefreshCharts;
        }

        public Credentials GetCredentials()
        {
            if (ValidaAmbienteConfigurado())
                return this.cred;
            else
            {
                throw new Exception("Ambiente não selecionado/configurado!");
            }
        }

        public dbConnect GetDbConnect()
        {
            if (ValidaAmbienteConfigurado())
                return this.dbCon;
            else
            {
                throw new Exception("Ambiente não selecionado/configurado!");
            }
        }

        public string GetDatabaseName()
        {
            if (ValidaAmbienteConfigurado())
              return this.databaseSindex;
            else
            {
                throw new Exception("Ambiente não selecionado/configurado!");
            }
        }

        public bool ValidaAmbienteConfigurado()
        {
            return (configuration.currentConfiguration >= 0);
        }
        #endregion

        #region LoadForms
        private void LoadForm(Form frm, Control parent, DockStyle dockStyle = DockStyle.Fill, bool validaAmbiente = false)
        {
            try
            {
                if (CurrentForm != null)
                    CurrentForm.Close();

                if (validaAmbiente)
                {
                    if (configuration.currentConfiguration < 0 || configuration.currentUser < 0)
                    {
                        frm.Close();
                        throw new Exception("Ambiente não foi selecionãdo, não sendo possível conectar-se ao banco de dados!");
                    }
                }

                CurrentForm = frm;
                CurrentForm.TopLevel = false;
                CurrentForm.TopMost = true;
                parent.Controls.Add(CurrentForm);
                CurrentForm.Dock = dockStyle;
                CurrentForm.StartPosition = FormStartPosition.CenterParent;
                CurrentForm.Show();

            }
            catch (Exception err)
            {
                this.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadSessions()
        {
            LoadForm(new frmConnections(this.metroStyleManager, configuration, this), pnlForm);
        }

        private void LoadFragmentedIndexes()
        {
            LoadForm(new frmFragmentedIndexes(this.metroStyleManager, configuration, this), pnlForm);
        }

        public void LoadLogin()
        {
            this.configuration.currentUser = -1;
            this.configuration.currentConfiguration = -1;
            this.dbCon = null;
            this.cred = null;
            this.databaseSindex = null;
            lblAmbiente.Text = "";
            lblUsuario.Text = "";
            minutesToUpdateTable = 5;
            secondsToUpdateChart = 5;

            if (CurrentForm != null)
                CurrentForm.Close();

            HideMenu(false);
            LoadForm(new frmLogin(this.metroStyleManager, configuration, this), pnlForm, DockStyle.Left);
        }
        public void LoadEnviroment(bool login = false)
        {
            LoadForm(new frmAmbientes(this.metroStyleManager, configuration, this, login), pnlForm);
        }
        public void LoadMissingIndexes(bool login = false)
        {
            LoadForm(new frmMissingIndexes(this.metroStyleManager, configuration, this), pnlForm);
        }
        public void LoadTables(bool login = false)
        {
            LoadForm(new frmLoadTables(metroStyleManager, configuration, this, login), pnlForm);
        }
        public void LoadDatabase(bool login = false)
        {
            LoadForm(new frmDatabases(metroStyleManager, configuration, this, login), pnlForm);
        }
        public void LoadDashboard()
        {
            LoadForm(new frmDashboard(metroStyleManager, configuration, this), pnlForm);
        }
        public void LoadHelp()
        {
            LoadForm(new frmAjuda(metroStyleManager, configuration, this), pnlForm);
        }
        private void LoadUpdateStatistics()
        {
            LoadForm(new frmUpdateStatistics(metroStyleManager, configuration, this), pnlForm);
        }
        #endregion

        #region menuItens
        private void hideSubMenu()
        {
            if (pnlSubMenuConfig.Visible) pnlSubMenuConfig.Visible = false;
            if (pnlSubMenuTuning.Visible) pnlSubMenuTuning.Visible = false;
            if (pnlSubMenuMonitoramento.Visible) pnlSubMenuMonitoramento.Visible = false;
        }

        public void SetAmbienteText(string text)
        {
            lblAmbiente.Text = text;
        }
        public void SetUsuarioText(string text)
        {
            lblUsuario.Text = text;
        }

        public void HideMenu(bool val)
        {
            pnlMenu.Visible = val;
            pnlBgMenu.Visible = val;
            pnlButtom.Visible = val;
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
            LoadSessions();
        }

        private void btnRecursos_Click(object sender, EventArgs e)
        {
            LoadDashboard();
        }

        private void btnAtualizarDados_Click(object sender, EventArgs e)
        {
            LoadTables();
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            LoadHelp();
        }

        private void btnMissIndex_Click(object sender, EventArgs e)
        {
            LoadMissingIndexes();
        }

        private void btnDefrag_Click(object sender, EventArgs e)
        {
            LoadFragmentedIndexes();
        }

        private void btnStatisticas_Click(object sender, EventArgs e)
        {
            LoadUpdateStatistics();
        }
    }
}