using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Forms;
using sindex.utils;
using sindex.repository;
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
    public partial class frmLoadTables : Form
    {
        Credentials cred;
        Configuration conf;
        frmMain main;
        string databaseName;
        bool login;

        public frmLoadTables(MetroStyleManager metroStyleManager, Configuration conf, frmMain main, bool login)
        {
            InitializeComponent();
            this.metroStyleManager.Theme = metroStyleManager.Theme;
            this.metroStyleManager.Style = metroStyleManager.Style;
            this.login = login;


            this.main = main;
            this.cred = main.cred;

            this.Refresh();
            LoadProcs();
        }

        private async void LoadProcs()
        {
            string status = "Carregando informações";
            string erro = "";

            Task t = Task.Run(() => {
                try
                {
                    this.databaseName = main.GetDatabaseName();

                    status = "Apagando dados...";
                    dbServer.DeleteDataFromDisabledDatabases(cred, databaseName);

                    status = "Carregando filegroups...";
                    dbServer.LoadFilegroups(cred, databaseName);

                    status = "Carregando files...";
                    dbServer.LoadFiles(cred, databaseName);

                    status = "Carregando tabelas...";
                    dbServer.LoadTables(cred, databaseName);

                    status = "Carregando restrições...";
                    dbServer.LoadConstraints(cred, databaseName);

                    status = "Carregando estatísticas...";
                    dbServer.LoadStats(cred, databaseName);

                    status = "Carregando índices...";
                    dbServer.LoadIndexes(cred, databaseName);
                    Task.Delay(500);
                } catch (Exception err)
                {
                    erro = err.Message;
                }
            });

            while (!t.IsCompleted)
            {
                await Task.Delay(300);
                lblTitulo.Text = status;
            }

            if (login)
            {
                if (!String.IsNullOrEmpty(erro))
                {
                    main.ShowMessage(erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
                else
                {
                    main.LoadDashboard();
                    this.Close();
                }
            } 
            else 
            {

                if (String.IsNullOrEmpty(erro))
                  lblTitulo.Text = "Tabelas atualizadas com sucesso!";
                else
                    lblTitulo.Text = "Erro ao atualizar tabelas: " + erro;

                spnLoading.Visible = false;
            }
        }
    }
}
