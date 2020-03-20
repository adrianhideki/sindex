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

namespace sindex
{
    public partial class frmMain : MetroForm
    {
        public frmMain()
        {
            InitializeComponent();
            this.Theme = metroStyleManager.Theme;
            this.Style = metroStyleManager.Style;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            dbConnect db = new dbConnect(txtUser.Text, txtPassword.Text, txtServer.Text);
            var sqlVersion = db.executeQuery("SELECT @@VERSION AS Version", new Dapper.DynamicParameters(), "master");
            string version = "";

            foreach (dynamic row  in sqlVersion)
            {
                version = row.Version;
            }

            lblVersao.Text = version;
        }
    }
}
