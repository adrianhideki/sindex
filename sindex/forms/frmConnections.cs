using Dapper;
using MetroFramework.Components;
using sindex.repository;
using sindex.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace sindex.forms
{
    public partial class frmConnections : Form
    {
        private Configuration conf;
        private frmMain main;
        private DataTable dtSession = null;
        private string[] paramName = { "@pdb_name", "@phost_name", "@pstatus", "@preads", "@pwrites", "@pcpu" };
        private string[] paramAlias = { "Database name", "Host Name", "Status", "Reads", "Writes", "CPU" };
        private DbType[] paramType = { DbType.String, DbType.String, DbType.String, DbType.Int32, DbType.Int32, DbType.Int32 };
        private object[] paramValue = { "", "", "", 0, 0, 0 };

        public frmConnections(MetroStyleManager metroStyleManager, Configuration conf, frmMain main)
        {
            InitializeComponent();

            this.metroStyleManager.Theme = metroStyleManager.Theme;
            this.metroStyleManager.Style = metroStyleManager.Style;
            this.Refresh();

            this.conf = conf;
            this.main = main;

            cbxFiltro.Items.Clear();

            foreach (string s in paramAlias)
            {
                cbxFiltro.Items.Add(s);
            }

            cbxFiltro.SelectedIndex = 0;

            SetupListBox();
            LoadGrid();
        }

        private void SetupListBox()
        {
            lbxCampos.BackColor = Color.FromArgb(17, 17, 17);
            lbxCampos.ForeColor = Color.FromArgb(191, 191, 191);
        }

        private DataTable GetCheckedColumns()
        {
            DataTable dtCopySession = dtSession.Copy();
            List<DataColumn> columns = new List<DataColumn>();

            for (int i = 0; i < dtCopySession.Columns.Count; i++)
            {
                if (lbxCampos.GetItemCheckState(i) != CheckState.Checked)
                {
                    columns.Add(dtCopySession.Columns[i]);
                }
            }

            for (int i = 0; i < columns.Count; i++)
            {
                dtCopySession.Columns.Remove(columns[i]);
            }

            return dtCopySession;
        }

        public async void LoadGrid()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();

                param.Add("@puserConnections", chkIgnorarSQLConections.Checked, DbType.Boolean);
                param.Add("@ponly_blocked", chkConexoesBloqueadas.Checked, DbType.Boolean);

                if (!String.IsNullOrEmpty(cbxFiltro.Text) && !String.IsNullOrEmpty(txtFiltro.Text))
                {
                    param.Add(paramName[cbxFiltro.SelectedIndex], txtFiltro.Text, paramType[cbxFiltro.SelectedIndex]);
                } 
                else
                {
                    param.Add(paramName[cbxFiltro.SelectedIndex], paramValue[cbxFiltro.SelectedIndex], paramType[cbxFiltro.SelectedIndex]);
                }

                for (int i = 0; i < paramAlias.Length; i++)
                {
                    if (i == cbxFiltro.SelectedIndex) continue;

                    param.Add(paramName[i], paramValue[i], paramType[i]);
                }

                dtSession = dbTables.GetSessionInfo(main.cred, main.databaseSindex, param);

                if (lbxCampos.Items.Count == 0)
                {
                    for(int i = 0; i < dtSession.Columns.Count; i++)
                    {
                        lbxCampos.Items.Add(dtSession.Columns[i].ColumnName, true);
                    }

                }

                SetGridDataSource();
            }
            catch (Exception err)
            {
                main.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetGridDataSource()
        {
            grdSessios.DataSource = null;
            grdSessios.Refresh();
            grdSessios.DataSource = GetCheckedColumns();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void chkMarcarTodos_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbxCampos.Items.Count; i++)
            {
                lbxCampos.SetItemChecked(i, chkMarcarTodos.Checked);
            }

            SetGridDataSource();
        }

        private void lbxCampos_Enter(object sender, EventArgs e)
        {
            SetGridDataSource();
        }

        private void lbxCampos_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Enter)
            {
                SetGridDataSource();
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }
    }
}
