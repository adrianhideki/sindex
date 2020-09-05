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
            Task t = Task.Run(() => {
                dbTables.LoadFilegroups(cred, databaseName);
                dbTables.LoadFiles(cred, databaseName);
                dbTables.LoadTables(cred, databaseName);
                dbTables.LoadConstraints(cred, databaseName);
                dbTables.LoadStats(cred, databaseName);
                dbTables.LoadIndexes(cred, databaseName);
                Task.Delay(500);
            });

            while (!t.IsCompleted)
            {
                await Task.Delay(300);
            }

            this.Close();
        }
    }
}
