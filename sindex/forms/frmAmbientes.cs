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
    public partial class frmAmbientes : Form
    {
        private ConfigurationFile conf;
        private frmMain main;
        List<Enviroment> enviroments = null;

        public frmAmbientes(MetroStyleManager metroStyleManager, ConfigurationFile conf, frmMain main)
        {
            InitializeComponent();
            this.metroStyleManager = metroStyleManager;
            this.Refresh();

            this.conf = conf;
            this.main = main;

            enviroments = this.conf.users[conf.currentUser].GetEnviroments();

            if(enviroments == null)
            {
                enviroments = new List<Enviroment>();
            }

            for (int i = 0; i < enviroments.Count; i++)
            {
                cbxAmbiente.Items.Add(enviroments[i].name);
            }
        }

        private void cbxAmbiente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (enviroments.Count > 0)
            {
                int index = cbxAmbiente.SelectedIndex;

                txtNome.Text = enviroments[index].name;
                txtServidor.Text = enviroments[index].server;
                txtUsuario.Text = enviroments[index].user;
                txtSenha.Text = enviroments[index].password;
                txtDatabase.Text = enviroments[index].database;
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
                enviroments.Add(env);

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
                    enviroments.Add(env);

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

                    enviroments.RemoveAt(index);
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
    }
}
