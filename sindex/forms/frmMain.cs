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
using sindex.model;
using sindex.forms;

namespace sindex
{
    public partial class frmMain : MetroForm
    {
        Credentials credentials;

        public frmMain()
        {
            InitializeComponent();
            this.Theme = metroStyleManager.Theme;
            this.Style = metroStyleManager.Style;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            credentials = new Credentials(txtUser.Text, txtPassword.Text, txtServer.Text);
            dbConnect db = new dbConnect(credentials);

            string errMsg = "";
            int errCode = 0;

            var sqlVersion = db.executeQuery("SELECT @@VERSION AS Version", new Dapper.DynamicParameters(), "master", out errMsg, out errCode);

            if (errCode != 0)
            {
                metroFunctions.ShowMessage(this, errMsg, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string version = "";

            foreach (dynamic row  in sqlVersion)
            {
                version = row.Version;
            }

            lblVersao.Text = version;

            await Task.Delay(1000);

            pnlLogin.Visible = false;

            LoadTables();
        }

        private void LoadForm(Form frm, Control parent)
        {
            frm.TopLevel = false;
            frm.TopMost = true;
            parent.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Show();
        }

        private async void LoadTables()
        {
            frmLoadTables frm = new frmLoadTables(metroStyleManager, credentials);
            frm.FormClosing += new FormClosingEventHandler(frmLoad_FormClosing);
            LoadForm(frm, this);
        }

        private void frmLoad_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoadDatabaseScreen();
        }

        private void LoadDatabaseScreen()
        {
            frmDatabases frm = new frmDatabases(metroStyleManager, credentials);
            LoadForm(frm, this);
        }

        private void frmMain_MaximumSizeChanged(object sender, EventArgs e)
        {

        }
    }
}
