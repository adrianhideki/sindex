using ClosedXML.Excel;
using Dapper;
using MetroFramework.Components;
using Microsoft.Reporting.WinForms;
using sindex.model;
using sindex.repository;
using sindex.utils;
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
using System.Windows.Input;

namespace sindex.forms
{
    public partial class frmConnections : Form
    {
        private Configuration conf;
        private frmMain main;
        private DataTable dtSession = null;
        private string[] paramName = { "@pdb_name", "@phost_name", "@pstatus", "@preads", "@pwrites", "@pcpu", "@pspid" };
        private string[] paramAlias = { "Database name", "Host Name", "Status", "Reads", "Writes", "CPU", "Session ID" };
        private DbType[] paramType = { DbType.String, DbType.String, DbType.String, DbType.Int32, DbType.Int32, DbType.Int32, DbType.Int32 };
        private object[] paramValue = { "", "", "", 0, 0, 0, 0 };

        public frmConnections(MetroStyleManager metroStyleManager, Configuration conf, frmMain main)
        {
            InitializeComponent();
            try
            {
                this.metroStyleManager.Theme = metroStyleManager.Theme;
                this.metroStyleManager.Style = metroStyleManager.Style;
                this.Refresh();

                this.conf = conf;
                this.main = main;

                cbxFiltro.Items.Clear();
                tkbSegundos.Value = 10;

                foreach (string s in paramAlias)
                {
                    cbxFiltro.Items.Add(s);
                }

                cbxFiltro.SelectedIndex = 0;

                SetupListBox();
                LoadGrid();
            }
            catch (Exception err)
            {
                main.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                if (lbxCampos.GetItemCheckState(i) != CheckState.Checked && i > 0)
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

                dtSession = dbServer.GetSessionInfo(main.cred, main.databaseSindex, param);

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

        private void verDetalhesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (grdSessios.SelectedRows.Count > 0)
                {
                    for (int i = 0; i < grdSessios.SelectedRows.Count; i++)
                    {
                        int spid = Int32.Parse(grdSessios.SelectedRows[i].Cells[0].Value.ToString());

                        DataTable dt = dbServer.GetSpidInfo(main.cred, main.databaseSindex, spid);

                        SessionModel session = new SessionModel();
                        session.sessionId = Int32.Parse(dt.Rows[0][0].ToString());
                        session.databaseName = dt.Rows[0][1].ToString();
                        session.hostName = dt.Rows[0][2].ToString();
                        session.programName = dt.Rows[0][3].ToString();
                        session.clientInterfaceName = dt.Rows[0][4].ToString();
                        session.blockingSessionId = Int32.Parse(dt.Rows[0][5].ToString());
                        session.openTransacionCount = Int32.Parse(dt.Rows[0][6].ToString());
                        session.percentComplete = Double.Parse(dt.Rows[0][7].ToString());
                        session.cpuTime = Int32.Parse(dt.Rows[0][8].ToString());
                        session.totalElapsedTime = Int32.Parse(dt.Rows[0][9].ToString());
                        session.reads = Int32.Parse(dt.Rows[0][10].ToString());
                        session.writes = Int32.Parse(dt.Rows[0][11].ToString());
                        session.logicalReads = Int32.Parse(dt.Rows[0][12].ToString());
                        session.startTime = DateTime.Parse(dt.Rows[0][13].ToString());
                        session.status = dt.Rows[0][14].ToString();
                        session.waitType = dt.Rows[0][15].ToString();
                        session.waitTime = Int32.Parse(dt.Rows[0][16].ToString());
                        session.waitResource = dt.Rows[0][17].ToString();
                        session.command = dt.Rows[0][18].ToString();
                        session.currentStatement = dt.Rows[0][19].ToString();
                        session.cmdSql = dt.Rows[0][20].ToString();
                        session.qryPlan = dt.Rows[0][21].ToString();

                        Form frm = new frmDetailSession(this.metroStyleManager, session);
                        frm.Show();
                    }
                }
            }
            catch (Exception err)
            {
                main.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tkbSegundos_ValueChanged(object sender, EventArgs e)
        {
            if (tkbSegundos.Value == 0)
                tkbSegundos.Value = 1;

            lblSegundos.Text = tkbSegundos.Value.ToString();
        }

        private void chkRefresh_CheckedChanged(object sender, EventArgs e)
        {
            if (tkbSegundos.Value == 0)
                tkbSegundos.Value = 1;

            tmrSession.Interval = tkbSegundos.Value * 1000;

            tmrSession.Enabled = chkRefresh.Checked;
        }

        private void tmrSession_Tick(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void habilitarDesabilitarAutoRefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chkRefresh.Checked = !chkRefresh.Checked;
        }

        private List<SessionModel> GetSessionList()
        {
            List<SessionModel> list = new List<SessionModel>();

            if (dtSession.Rows.Count > 0)
            {
                for (int i = 0; i < dtSession.Rows.Count; i++)
                {
                    SessionModel session = new SessionModel();
                    session.sessionId = Int32.Parse(dtSession.Rows[0][0].ToString());
                    session.databaseName = dtSession.Rows[0][1].ToString();
                    session.hostName = dtSession.Rows[0][2].ToString();
                    session.programName = dtSession.Rows[0][3].ToString();
                    session.clientInterfaceName = dtSession.Rows[0][4].ToString();
                    session.blockingSessionId = Int32.Parse(dtSession.Rows[0][5].ToString());
                    session.openTransacionCount = Int32.Parse(dtSession.Rows[0][6].ToString());
                    session.percentComplete = Double.Parse(dtSession.Rows[0][7].ToString());
                    session.cpuTime = Int32.Parse(dtSession.Rows[0][8].ToString());
                    session.totalElapsedTime = Int32.Parse(dtSession.Rows[0][9].ToString());
                    session.reads = Int32.Parse(dtSession.Rows[0][10].ToString());
                    session.writes = Int32.Parse(dtSession.Rows[0][11].ToString());
                    session.logicalReads = Int32.Parse(dtSession.Rows[0][12].ToString());
                    session.startTime = DateTime.Parse(dtSession.Rows[0][13].ToString());
                    session.status = dtSession.Rows[0][14].ToString();
                    session.waitType = dtSession.Rows[0][15].ToString();
                    session.waitTime = Int32.Parse(dtSession.Rows[0][16].ToString());
                    session.waitResource = dtSession.Rows[0][17].ToString();
                    session.command = dtSession.Rows[0][18].ToString();
                    session.currentStatement = dtSession.Rows[0][19].ToString();
                    session.cmdSql = dtSession.Rows[0][20].ToString();
                    session.qryPlan = dtSession.Rows[0][21].ToString();

                    list.Add(session);
                }
            }

            return list;
        }

        private void padrãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PrintSindex.PrintReportViewer(GetSessionList(), "DataSet1", "sindex.reports.Sessions.rdlc", true, DeviceInfoSindex.landscape);
            }
            catch (Exception err)
            {
                main.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void gridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                grdSessios.Theme = MetroFramework.MetroThemeStyle.Light;
                grdSessios.Style = MetroFramework.MetroColorStyle.Silver;

                PrintSindex.PrintGrid("Sessions", "", "", grdSessios);

                grdSessios.Theme = MetroFramework.MetroThemeStyle.Default;
                grdSessios.Style = MetroFramework.MetroColorStyle.Default;
            }
            catch (Exception err)
            {
                main.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try 
            {
                XLWorkbook wb = new XLWorkbook();
                wb.Worksheets.Add(dtSession, "Sessions");

                SaveFileDialog fileDialog = new SaveFileDialog();

                fileDialog.DefaultExt = "xlsx";
                fileDialog.Filter = "Excel (*.xlsx)|*.xlsx|All files (*.*)|*.*";

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    wb.SaveAs(fileDialog.FileName);
                }
            }
            catch (Exception err)
            {
                main.ShowMessage(err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void matarSessãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (grdSessios.SelectedRows.Count > 0)
            {
                string erros = "";

                DialogResult dialogResult = main.ShowMessage("Deseja realmente matar as conexões?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.No) return;

                for (int i = 0; i < grdSessios.SelectedRows.Count; i++)
                {
                    int spid = 0;

                    try
                    {
                        spid = Int32.Parse(grdSessios.SelectedRows[i].Cells[0].Value.ToString());
                        dbServer.KillSession(main.cred, main.databaseSindex, spid);
                    } catch (Exception err)
                    {
                        erros += "\nSPID: " + spid.ToString() + ". Erro: " + err.Message;
                    }
                }

                if (!String.IsNullOrEmpty(erros))
                {
                    main.ShowMessage(erros, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
