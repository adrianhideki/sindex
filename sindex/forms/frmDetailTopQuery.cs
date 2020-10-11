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
using System.IO;
using sindex.utils;
using System.Diagnostics;

namespace sindex.forms
{
    public partial class frmDetailTopQuery : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private TopQueryModel topQuery;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public frmDetailTopQuery(MetroStyleManager metroStyleManager, TopQueryModel topQuery)
        {
            InitializeComponent();

            this.topQuery = topQuery;
            this.metroStyleManager.Theme = metroStyleManager.Theme;
            //this.metroStyleManager.Style = metroStyleManager.Style;

            lblCreateTime.Text = topQuery.createTime.ToString();
            lblLastExecution.Text = topQuery.lastExecutionDateTime.ToString();
            lblTotalWorkerTime.Text = topQuery.totalWokerTime.ToString();
            lblAvgCPUTime.Text = topQuery.avgCpuTime.ToString();
            lblAvgPhysicalReads.Text = topQuery.avgPhysicalReads.ToString();
            lblAvgLogicalWrites.Text = topQuery.avgLogicalWrites.ToString();
            lblAvgElapsedTime.Text = topQuery.avgElapsedTime.ToString();
            lblExecutionCount.Text = topQuery.executionCount.ToString();
            lblDatabaseName.Text = topQuery.databaseName.ToString();
            lblAvgUsedThreads.Text = topQuery.avgUsedThreads.ToString();
            lblAvgMaxDop.Text = topQuery.avgMaxDop.ToString();
            txtCmdSql.Text = topQuery.query;
            txtCurrentStatement.Text = topQuery.statement;
            lblQryPlan.Text = topQuery.plan;

            lnkOpenSsms.Enabled = !(String.IsNullOrEmpty(topQuery.plan));
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

        private void lnkOpenSsms_Click(object sender, EventArgs e)
        {
            try
            {
                string file = Path.GetTempPath() + "sindexPlan_" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".sqlplan";

                System.IO.File.WriteAllText(file, topQuery.plan);

                var pi = new ProcessStartInfo(file)
                {
                    Arguments = "/dde " + Path.GetFileName(file),
                    UseShellExecute = true,
                    WorkingDirectory = Path.GetDirectoryName(file),
                    Verb = "OPEN"
                };
                Process.Start(pi);
            }
            catch (Exception err)
            {
                metroFunctions.ShowMessage(this, err.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
