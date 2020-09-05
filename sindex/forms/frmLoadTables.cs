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

        public frmLoadTables(MetroStyleManager metroStyleManager, Configuration conf, frmMain main)
        {
            InitializeComponent();
            this.metroStyleManager.Theme = metroStyleManager.Theme;
            this.metroStyleManager.Style = metroStyleManager.Style;


            this.main = main;
            this.cred = main.cred;
            this.databaseName = main.GetDatabaseName();

            this.Refresh();
            LoadProcs();
        }

        private async void LoadProcs()
        {
            string status = "Carregando informações";

            Task t = Task.Run(() => {
                status = "Apagando dados...";
                dbTables.DeleteDataFromDisabledDatabases(cred, databaseName);

                status = "Carregando filegroups...";
                dbTables.LoadFilegroups(cred, databaseName);

                status = "Carregando files...";
                dbTables.LoadFiles(cred, databaseName);

                status = "Carregando tabelas...";
                dbTables.LoadTables(cred, databaseName);

                status = "Carregando restrições...";
                dbTables.LoadConstraints(cred, databaseName);

                status = "Carregando estatísticas...";
                dbTables.LoadStats(cred, databaseName);

                status = "Carregando índices...";
                dbTables.LoadIndexes(cred, databaseName);
                Task.Delay(500);
            });

            while (!t.IsCompleted)
            {
                await Task.Delay(300);
                lblTitulo.Text = status;
            }

            this.Close();
        }
    }
}
