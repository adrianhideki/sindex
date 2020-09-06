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
        List<Enviroment> enviroments = null;

        public frmAmbientes(MetroStyleManager metroStyleManager, Configuration conf, frmMain main)
        {
            try
            {
                InitializeComponent();

                this.metroStyleManager.Theme = metroStyleManager.Theme;
                this.metroStyleManager.Style = metroStyleManager.Style;

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

                    txtNome.Text = enviroments[index].name;
                    txtServidor.Text = enviroments[index].server;
                    txtUsuario.Text = enviroments[index].user;
                    txtSenha.Text = enviroments[index].password;
                    txtDatabase.Text = enviroments[index].database;
                    setEnabledButtons(true);

                } else {
                    setEnabledButtons(false);
                }
            }
            catch (Exception err)
            {
                main.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                Enviroment env = new Enviroment();
                env.name = txtNome.Text;
                env.server = txtServidor.Text;
                env.user = txtUsuario.Text;
                env.password = txtSenha.Text;
                env.database = txtDatabase.Text;

                conf.users[conf.currentUser].AddEnviroment(env);
                cbxAmbiente.Items.Add(env.name);
                main.SaveConfig();
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
                    int index = cbxAmbiente.SelectedIndex;

                    Enviroment env = new Enviroment();
                    env.name = txtNome.Text;
                    env.server = txtServidor.Text;
                    env.user = txtUsuario.Text;
                    env.password = txtSenha.Text;
                    env.database = txtDatabase.Text;

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
                dbConnect dbConnect = new dbConnect(new Credentials(txtUsuario.Text, txtSenha.Text, txtServidor.Text));
                dbConnect.executeQuery("SELECT 1", new Dapper.DynamicParameters(), txtDatabase.Text, out string errMsg, out int errCode);

                if (errCode != 0)
                {
                    throw new Exception(errMsg);
                }

                main.ShowMessage("Conexão válida!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                main.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (enviroments.Count > 0 && cbxAmbiente.SelectedIndex >= 0)
                {
                    this.conf.currentConfiguration = cbxAmbiente.SelectedIndex;

                    main.SetConnectionSettings();
                    main.SetAmbienteText(cbxAmbiente.Text);

                    DataTable dt = main.GetDbConnect().executeDataTable("SELECT * FROM sys.tables WHERE name = 'index'", new Dapper.DynamicParameters(), main.GetDatabaseName(), out string errMsg, out int errCode);

                    if (dt.Rows.Count > 0)
                    {
                        DataTable dtDatabases = dbTables.GetActiveDatabases(main.cred, main.databaseSindex);

                        if (dtDatabases.Rows.Count > 0)
                        {
                            main.LoadTables();
                        } else
                        {
                            main.LoadDatabase();
                        }
                    } 
                    else
                    {
                        main.LoadDatabase();
                    }

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
    }
}
