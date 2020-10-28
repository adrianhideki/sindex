using MetroFramework.Components;
using sindex.model;
using sindex.repository;
using sindex.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace sindex.forms
{
    public partial class frmUsers : Form
    {
        Configuration conf;
        frmMain main;
        string[] gridColName = { "Usuário", "Senha", "Senha 2", "e-mail", "Tema Escuro", "Bloqueado", "Perfil", "Ambientes" };
        bool[] gridVisible = { true, false, false, true, false, true, true, false };
        int checkedColumn = 7;
        int scriptColumn = 6;
        DataTable dtStats;

        public frmUsers(MetroStyleManager metroStyleManager, Configuration conf, frmMain main)
        {
            this.main = main;
            this.conf = conf;

            InitializeComponent();

            try
            {
                this.metroStyleManager.Theme = metroStyleManager.Theme;
                this.metroStyleManager.Style = metroStyleManager.Style;

                SetTheme();
                GetDataGrid();
                BloqueiaComponentes();
            }
            catch (Exception err)
            {
                main.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BloqueiaComponentes()
        {
            switch (conf.users[conf.currentUser].perfil)
            {
                case PerfilAcesso.administrador:
                    cbxPerfil.Enabled = true;
                    break;
                case PerfilAcesso.monitoria:
                    cbxPerfil.Enabled = false;
                    break;
                case PerfilAcesso.performance:
                    cbxPerfil.Enabled = false;
                    break;
                default:
                    cbxPerfil.Enabled = false;
                    break;
            }
        }
        private void SetTheme()
        {
            Color bgColor = Color.FromArgb(17, 17, 17);
            Color frColor = Color.FromArgb(119, 119, 119);
            grdStats.MultiSelect = false;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                GetDataGrid();
            }
            catch (Exception err)
            {
                main.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResizeGrid(DataGridView grd)
        {
            if (grd.Rows.Count <= 0) return;

            for (int i = 0; i < grd.Columns.Count; i++)
            {
                grd.Columns[i].HeaderText = gridColName[i];
                grd.Columns[i].Visible = gridVisible[i];
            }

            int widthMedia = (grdStats.Width / (grdStats.Columns.GetColumnCount(DataGridViewElementStates.Visible))) - 10;

            for (int i = 0; i < grd.Columns.Count; i++)
            {
                if (grd.Columns[i].Visible)
                  grd.Columns[i].Width = widthMedia;
            }
        }
        private void GetDataGrid()
        {
            List<User> users = new List<User>();

            for (int i = 0; i < main.configuration.users.Count; i++) {

                User u = main.configuration.users[i];

                if (main.configuration.users[conf.currentUser].perfil != PerfilAcesso.administrador)
                {
                    if (i == conf.currentUser) users.Add(u);
                } else
                {
                    if (txtFiltro.Text == "" || u.user.IndexOf(txtFiltro.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                        users.Add(u);
                }
            }

            grdStats.DataSource = users;
            grdStats.Refresh();
            ResizeGrid(grdStats);

            lblLinhas.Text = grdStats.Rows.Count.ToString() + " linhas.";
        }
        private void grdIndexes_Resize(object sender, EventArgs e)
        {
            ResizeGrid(grdStats);
        }

        private void grdStats_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int userIndex = -1;

                if (grdStats.SelectedRows.Count > 0)
                {
                    string user = grdStats.SelectedRows[0].Cells[0].Value.ToString();
                     userIndex = conf.getUserIndex(user);
                }

                if (userIndex >= 0)
                {
                    lblUsuario.Text = conf.users[userIndex].user;
                    txtPassword.Text = conf.users[userIndex].password;
                    txtPassword2.Text = conf.users[userIndex].password;
                    chkBloqueado.Checked = conf.users[userIndex].bloqueado;
                    txtEmail.Text = conf.users[userIndex].email;

                    switch (conf.users[userIndex].perfil)
                    {
                        case PerfilAcesso.administrador:
                            cbxPerfil.SelectedIndex = 0;
                            break;
                        case PerfilAcesso.monitoria:
                            cbxPerfil.SelectedIndex = 1;
                            break;
                        case PerfilAcesso.performance:
                            cbxPerfil.SelectedIndex = 2;
                            break;
                        default:
                            cbxPerfil.SelectedIndex = 2;
                            break;
                    }
                }
            }
            catch (Exception err)
            {
                main.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string user = grdStats.SelectedRows[0].Cells[0].Value.ToString();
                int userIndex = conf.getUserIndex(user);
                PerfilAcesso perfil;

                switch (cbxPerfil.SelectedIndex)
                {
                    case 0:
                        perfil = PerfilAcesso.administrador;
                        break;
                    case 1:
                        perfil = PerfilAcesso.monitoria;
                        break;
                    case 2:
                        perfil = PerfilAcesso.performance;
                        break;
                    default:
                        perfil = PerfilAcesso.performance;
                        break;
                }

                if (perfil == PerfilAcesso.administrador && conf.users[conf.currentUser].perfil != PerfilAcesso.administrador)
                {
                    throw new Exception("Somente administradores podem trocar o privilégio para administrador, caso seja necessário contate o mesmo!");
                }

                User userUpdate = new User(lblUsuario.Text,txtPassword.Text, txtPassword2.Text, txtEmail.Text, conf.users[userIndex].darkTheme, perfil, chkBloqueado.Checked);

                conf.users[userIndex].UpdateUser(userUpdate);
                main.SaveConfig();
                GetDataGrid();
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
                string user = grdStats.SelectedRows[0].Cells[0].Value.ToString();
                int userIndex = conf.getUserIndex(user);

                if (userIndex == conf.currentUser)
                {
                    throw new Exception("Não é possível excluir o próprio usuário!");
                }

                conf.users.RemoveAt(userIndex);
                main.SaveConfig();
                GetDataGrid();
            }
            catch (Exception err)
            {
                main.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
