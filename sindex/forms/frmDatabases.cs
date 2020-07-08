using MetroFramework.Components;
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
    public partial class frmDatabases : Form
    {
        Credentials cred;
        public frmDatabases(MetroStyleManager metroStyleManager, Credentials cred)
        {
            InitializeComponent();
            this.metroStyleManager = metroStyleManager;

            this.cred = cred;
            this.Refresh();

            grdDatabases.DataSource = dbTables.GetDatabases(cred);
        }
    }
}
