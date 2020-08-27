using DoddleReport.Configuration;
using MetroFramework.Components;
using sindex.model;
using sindex.repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sindex.forms
{
    public partial class frmDatabases : Form
    {
        string path;
        string [] arquivos;
        private object dbConnect;
        Configuration conf;
        frmMain main;

        public frmDatabases(MetroStyleManager metroStyleManager, Configuration conf, frmMain main)
        {
            InitializeComponent();
            this.metroStyleManager = metroStyleManager;
            this.Refresh();

            this.conf = conf;
            this.main = main;

            try
            {
                path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\scripts";

                arquivos = Directory.GetFiles(path);

                if (arquivos.Length == 0)
                {
                    throw new Exception("Não foi possível localizar os scripts de criação da base.");
                }

                CreateObjects();
            }
            catch (Exception err)
            {
                main.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //grdDatabases.DataSource = dbTables.GetDatabases(cred);
        }

        public void CreateObjects()
        {
            string database = conf.users[conf.currentUser].enviroments[conf.currentConfiguration].GetDatabase();
            dbConnect db = new dbConnect(conf.users[conf.currentUser].enviroments[conf.currentConfiguration].GetCredentials());

            DataTable dt = db.executeDataTable("SELECT * FROM sys.tables WHERE name = 'index'", new Dapper.DynamicParameters(), database, out string errMsg, out int errCode);

            if (errCode != 0)
            {
                throw new Exception(errMsg);
            }

            //Cria tabelas
            if (dt.Rows.Count == 0)
            {

            }
        }
    }
}
