using MetroFramework.Components;
using sindex.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace sindex.forms
{
    public partial class frmDetailSession : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public frmDetailSession(MetroStyleManager metroStyleManager, SessionModel session)
        {
            InitializeComponent();

            this.metroStyleManager.Theme = metroStyleManager.Theme;
            this.metroStyleManager.Style = metroStyleManager.Style;

            lblSpid.Text = session.sessionId.ToString();
            lblDatabase.Text = session.databaseName;
            lblHost.Text = session.hostName;
            lblProgramName.Text = session.programName;
            lblClientInterface.Text =  session.clientInterfaceName;
            lblBlockingSession.Text = session.blockingSessionId.ToString();
            lblOpenTrancount.Text = session.openTransacionCount.ToString();
            lblPercentCompleted.Text = session.percentComplete.ToString();
            lblCpuTime.Text = session.cpuTime.ToString();
            lblTotalElapsedTime.Text = session.totalElapsedTime.ToString();
            lblReads.Text = session.reads.ToString();
            lblWrites.Text = session.writes.ToString();
            lblLogicalReads.Text = session.logicalReads.ToString();
            lblStartTime.Text = session.startTime.ToString();
            lblStatus.Text = session.status;
            lblWaitType.Text = session.waitType;
            lblWaitTime.Text = session.waitTime.ToString();
            lblWaitResource.Text = session.waitResource;
            lblCommand.Text = session.command;
            txtCurrentStatement.Text = session.currentStatement;
            txtCmdSql.Text = session.cmdSql;
            lblQryPlan.Text = session.qryPlan;
        }

        private void pnlBG_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
