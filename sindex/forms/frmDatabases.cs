using MetroFramework.Components;
using sindex.utils;
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

                arquivos = Directory.GetFiles(path,"*.sql",SearchOption.AllDirectories).OrderBy(f=>f).ToArray();

                if (arquivos.Length == 0)
                {
                    throw new Exception("Não foi possível localizar os scripts de criação da base.");
                }

                CreateObjects();
                LoadDatabases();
            }
            catch (Exception err)
            {
                main.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //grdDatabases.DataSource = dbTables.GetDatabases(cred);
        }

        public void LoadDatabases()
        {
            dbTables.LoadServer(main.GetCredentials(), main.GetDatabaseName());
            dbTables.LoadDatabases(main.GetCredentials(), main.GetDatabaseName());
        }

        public void CreateObjects()
        {

            DataTable dt = main.GetDbConnect().executeDataTable("SELECT * FROM sys.tables WHERE name = 'index'", new Dapper.DynamicParameters(), main.GetDatabaseName(), out string errMsg, out int errCode);

            if (errCode != 0)
            {
                throw new Exception(errMsg);
            }

            //Cria tabelas
            if (dt.Rows.Count == 0)
            {
                foreach(string f in arquivos)
                {
                    StreamReader sr = new StreamReader(f);
                    string script = sr.ReadToEnd();

                    errMsg = "";
                    errCode = 0;

                    main.dbCon.executeCommand(script, new Dapper.DynamicParameters(), main.databaseSindex, out errMsg, out errCode);

                    if (errCode != 0)
                    {
                        throw new Exception(errMsg);
                    }
                }
            }
        }

        private void frmDatabases_Load(object sender, EventArgs e)
        {

        }
    }
}
