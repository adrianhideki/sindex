using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Forms;
using sindex.model;
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
        public frmLoadTables(MetroStyleManager metroStyleManager, Credentials cred)
        {
            InitializeComponent();
            this.metroStyleManager = metroStyleManager;

            this.cred = cred;
            this.Refresh();
            LoadProcs();
        }

        private async void LoadProcs()
        {
            Task t = Task.Run(() => {
                dbTables.LoadServer(cred);
                dbTables.LoadDatabases(cred);
                dbTables.LoadFilegroups(cred);
                dbTables.LoadFiles(cred);
                dbTables.LoadTables(cred);
                dbTables.LoadConstraints(cred);
                dbTables.LoadStats(cred);
                dbTables.LoadIndexes(cred);

            });

            t.Wait();

            await Task.Delay(1000);
            this.Close();
        }
    }
}
