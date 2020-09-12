using MetroFramework.Components;
using sindex.repository;
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
    public partial class frmAmbientes : Form
    {
        private Configuration conf;
        private frmMain main;
        private bool login;
        List<Enviroment> enviroments = null;

        public frmAmbientes(MetroStyleManager metroStyleManager, Configuration conf, frmMain main, bool login = false)
        {
            try
            {
                InitializeComponent();

                this.metroStyleManager.Theme = metroStyleManager.Theme;
                this.metroStyleManager.Style = metroStyleManager.Style;
                this.login = login;

                this.Refresh();

                this.conf = conf;
                this.main = main;

                enviroments = this.conf.users[conf.currentUser].GetEnviroments();

                if (enviroments == null)
                {
                    enviroments = new List<Enviroment>();
                }

                for (int i = 0; i < enviroments.Count; i++)
                {
                    cbxAmbiente.Items.Add(enviroments[i].name);
                }

                if (enviroments.Count > 0)
                {
                    cbxAmbiente.SelectedIndex = 0;
                } else
                {
                    setEnabledButtons(false);
                }
            }
            catch (Exception err)
            {
                main.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validaNomeAmbiente(string nome)
        {
            bool _out = false;

            if (enviroments.Count > 0)
            {
                for (int i = 0; i < enviroments.Count; i++)
                {
                    if (enviroments[i].name == nome)
                    {
                        return true;
                    }
                }
            }

            return _out;
        }

        private void setEnabledButtons(bool val)
        {

            btnSelecionarAmbiente.Enabled = val;
            btnExcluir.Enabled = val;
            btnAtualizar.Enabled = val;
        }

        private void cbxAmbiente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (enviroments.Count > 0)
                {
                    int index = cbxAmbiente.SelectedIndex;

                    if (index >= 0)
                    {
                        txtNome.Text = enviroments[index].name;
                        txtServidor.Text = enviroments[index].server;
                        txtUsuario.Text = enviroments[index].user;
                        txtSenha.Text = enviroments[index].password;
                        txtDatabase.Text = enviroments[index].database;
                        txtUpdateChart.Text = enviroments[index].secondsToRefreshCharts.ToString();
                        txtUpdateTables.Text = enviroments[index].minutesToRefreshTables.ToString();

                        setEnabledButtons(true);
                    } else
                    { 
                        txtNome.Text = "";
                        txtServidor.Text = "";
                        txtUsuario.Text = "";
                        txtSenha.Text = "";
                        txtDatabase.Text = "";
                        txtUpdateChart.Text = "";
                        txtUpdateTables.Text = "";
                    }

                } else {
                    setEnabledButtons(false);
                }
            }
            catch (Exception err)
            {
                main.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void validarConfiguracoes()
        {
            string _out = "";
            int _num = 0;

            if (String.IsNullOrEmpty(txtNome.Text)) _out += "\nNome do ambiente inválido.";
            if (String.IsNullOrEmpty(txtServidor.Text)) _out += "\nNome do servidor inválido.";
            if (String.IsNullOrEmpty(txtUsuario.Text)) _out += "\nUsuário inválido.";
            if (String.IsNullOrEmpty(txtSenha.Text)) _out += "\nSenha inválida.";
            if (String.IsNullOrEmpty(txtDatabase.Text)) _out += "\nBanco de dados inválido.";

            Int32.TryParse(txtUpdateChart.Text, out _num);
            if (String.IsNullOrEmpty(txtUpdateChart.Text) || _num <= 0) _out += "\nSegundos para atualizar gráficos configurado incorretamente.";

            Int32.TryParse(txtUpdateTables.Text, out _num);
            if (String.IsNullOrEmpty(txtUpdateTables.Text) || _num <= 0) _out += "\nMinutos para atualizar tabelas configurado incorretamente.";

            if (_out != "")
                throw new Exception(_out);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                validarConfiguracoes();

                Enviroment env = new Enviroment();
                env.name = txtNome.Text;
                env.server = txtServidor.Text;
                env.user = txtUsuario.Text;
                env.password = txtSenha.Text;
                env.database = txtDatabase.Text;
                env.secondsToRefreshCharts = Int32.Parse(txtUpdateChart.Text);
                env.minutesToRefreshTables = Int32.Parse(txtUpdateTables.Text);

                conf.users[conf.currentUser].AddEnviroment(env);
                cbxAmbiente.Items.Add(env.name);
                main.SaveConfig();

                int index = cbxAmbiente.Items.Count - 1;
                cbxAmbiente.SelectedIndex = index;
                txtNome_TextChanged(null, null);
                cbxAmbiente_SelectedIndexChanged(null, null);
            } catch (Exception err)
            {
                main.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (enviroments.Count > 0 && cbxAmbiente.SelectedIndex >= 0)
                {
                    validarConfiguracoes();

                    int index = cbxAmbiente.SelectedIndex;

                    Enviroment env = new Enviroment();
                    env.name = txtNome.Text;
                    env.server = txtServidor.Text;
                    env.user = txtUsuario.Text;
                    env.password = txtSenha.Text;
                    env.database = txtDatabase.Text;
                    env.secondsToRefreshCharts = Int32.Parse(txtUpdateChart.Text);
                    env.minutesToRefreshTables = Int32.Parse(txtUpdateTables.Text);

                    conf.users[conf.currentUser].UpdateEnviroment(index, env);
                    cbxAmbiente.Items[index] = env.name;
                    main.SaveConfig();
                }
            } 
            catch (Exception err)
            {
                main.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (enviroments.Count > 0)
                {
                    int index = cbxAmbiente.SelectedIndex;

                    //enviroments.RemoveAt(index);
                    conf.users[conf.currentUser].RemoveEnviroment(index);
                    main.SaveConfig();

                    cbxAmbiente.Items.RemoveAt(index);
                    txtNome_TextChanged(null,null);
                    cbxAmbiente_SelectedIndexChanged(null, null);
                }
            }
            catch (Exception err)
            {
                main.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnTestarCon_Click(object sender, EventArgs e)
        {
            try
            {
                TestarCon();
                main.ShowMessage("Conexão válida!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                main.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TestarCon()
        {
            dbConnect dbConnect = new dbConnect(new Credentials(txtUsuario.Text, txtSenha.Text, txtServidor.Text));
            dbConnect.executeQuery("SELECT 1", new Dapper.DynamicParameters(), txtDatabase.Text, out string errMsg, out int errCode);

            if (errCode != 0)
            {
                throw new Exception(errMsg);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (enviroments.Count > 0 && cbxAmbiente.SelectedIndex >= 0)
                {
                    this.conf.currentConfiguration = cbxAmbiente.SelectedIndex;
                    TestarCon();

                    main.SetConnectionSettings();
                    main.SetAmbienteText(cbxAmbiente.Text);

                    DataTable dt = main.GetDbConnect().executeDataTable("SELECT * FROM sys.tables WHERE name = 'index'", new Dapper.DynamicParameters(), main.GetDatabaseName(), out string errMsg, out int errCode);

                    if (dt.Rows.Count > 0)
                    {
                        DataTable dtDatabases = dbServer.GetActiveDatabases(main.cred, main.databaseSindex);
                        int min = dbServer.GetMinLastUpdate(main.cred, main.databaseSindex);

                        if (dtDatabases.Rows.Count > 0)
                        {
                            if (min > main.minutesToUpdateTable)
                            {
                                main.LoadTables(login);
                            } else if (login)
                            {
                                main.LoadDashboard();
                            }
                        } else
                        {
                            main.LoadDatabase(login);
                        }
                    } 
                    else
                    {
                        main.LoadDatabase(login);
                    }

                    if (login)
                      this.Close();
                } 
                else 
                {
                    throw new Exception("Selecione um ambiente válido");
                }
            }
            catch (Exception err)
            {
                main.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            btnAdicionar.Enabled = !(validaNomeAmbiente(txtNome.Text));
        }

        private void txtServidor_TextChanged(object sender, EventArgs e)
        {
            btnTestarCon.Enabled = ValidaConexao();
        }

        public bool ValidaConexao()
        {
            if (!String.IsNullOrEmpty(txtDatabase.Text) && !String.IsNullOrEmpty(txtServidor.Text) && !String.IsNullOrEmpty(txtUsuario.Text) && !String.IsNullOrEmpty(txtServidor.Text))
                return true;

            return false;
        }

        private void txtUpdateTables_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
