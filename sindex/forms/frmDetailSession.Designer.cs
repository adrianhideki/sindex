namespace sindex.forms
{
    partial class frmDetailSession
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetailSession));
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlBG = new MetroFramework.Controls.MetroPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblBlockingSession = new MetroFramework.Controls.MetroLabel();
            this.lblQryPlan = new MetroFramework.Controls.MetroLabel();
            this.lblHost = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel36 = new MetroFramework.Controls.MetroLabel();
            this.lblDatabase = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtCmdSql = new System.Windows.Forms.RichTextBox();
            this.metroLabel34 = new MetroFramework.Controls.MetroLabel();
            this.txtCurrentStatement = new System.Windows.Forms.RichTextBox();
            this.metroLabel30 = new MetroFramework.Controls.MetroLabel();
            this.lblCommand = new MetroFramework.Controls.MetroLabel();
            this.metroLabel35 = new MetroFramework.Controls.MetroLabel();
            this.lblWaitResource = new MetroFramework.Controls.MetroLabel();
            this.metroLabel33 = new MetroFramework.Controls.MetroLabel();
            this.lblWaitTime = new MetroFramework.Controls.MetroLabel();
            this.metroLabel32 = new MetroFramework.Controls.MetroLabel();
            this.lblWaitType = new MetroFramework.Controls.MetroLabel();
            this.metroLabel31 = new MetroFramework.Controls.MetroLabel();
            this.lblStatus = new MetroFramework.Controls.MetroLabel();
            this.metroLabel29 = new MetroFramework.Controls.MetroLabel();
            this.lblStartTime = new MetroFramework.Controls.MetroLabel();
            this.metroLabel27 = new MetroFramework.Controls.MetroLabel();
            this.lblLogicalReads = new MetroFramework.Controls.MetroLabel();
            this.metroLabel26 = new MetroFramework.Controls.MetroLabel();
            this.lblWrites = new MetroFramework.Controls.MetroLabel();
            this.metroLabel25 = new MetroFramework.Controls.MetroLabel();
            this.lblReads = new MetroFramework.Controls.MetroLabel();
            this.metroLabel24 = new MetroFramework.Controls.MetroLabel();
            this.lblTotalElapsedTime = new MetroFramework.Controls.MetroLabel();
            this.metroLabel23 = new MetroFramework.Controls.MetroLabel();
            this.lblCpuTime = new MetroFramework.Controls.MetroLabel();
            this.metroLabel22 = new MetroFramework.Controls.MetroLabel();
            this.lblPercentCompleted = new MetroFramework.Controls.MetroLabel();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.lblOpenTrancount = new MetroFramework.Controls.MetroLabel();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.lblProgramName = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.lblSpid = new MetroFramework.Controls.MetroLabel();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.InfoTile = new MetroFramework.Controls.MetroTile();
            this.tileStatus = new MetroFramework.Controls.MetroTile();
            this.tileResource = new MetroFramework.Controls.MetroTile();
            this.tileWait = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.pnlBG.SuspendLayout();
            this.InfoTile.SuspendLayout();
            this.tileStatus.SuspendLayout();
            this.tileResource.SuspendLayout();
            this.tileWait.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            this.metroStyleManager.Style = MetroFramework.MetroColorStyle.Silver;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(620, 5);
            this.pnlTop.TabIndex = 1;
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBG_MouseMove);
            // 
            // pnlBG
            // 
            this.pnlBG.Controls.Add(this.tileWait);
            this.pnlBG.Controls.Add(this.tileResource);
            this.pnlBG.Controls.Add(this.tileStatus);
            this.pnlBG.Controls.Add(this.InfoTile);
            this.pnlBG.Controls.Add(this.lblQryPlan);
            this.pnlBG.Controls.Add(this.metroLabel36);
            this.pnlBG.Controls.Add(this.txtCmdSql);
            this.pnlBG.Controls.Add(this.metroLabel34);
            this.pnlBG.Controls.Add(this.txtCurrentStatement);
            this.pnlBG.Controls.Add(this.metroLabel30);
            this.pnlBG.Controls.Add(this.btnClose);
            this.pnlBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBG.HorizontalScrollbarBarColor = true;
            this.pnlBG.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlBG.HorizontalScrollbarSize = 10;
            this.pnlBG.Location = new System.Drawing.Point(0, 5);
            this.pnlBG.Name = "pnlBG";
            this.pnlBG.Size = new System.Drawing.Size(620, 545);
            this.pnlBG.TabIndex = 2;
            this.pnlBG.VerticalScrollbarBarColor = true;
            this.pnlBG.VerticalScrollbarHighlightOnWheel = false;
            this.pnlBG.VerticalScrollbarSize = 10;
            this.pnlBG.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBG_MouseMove);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnClose.Location = new System.Drawing.Point(593, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(27, 20);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblBlockingSession
            // 
            this.lblBlockingSession.AutoSize = true;
            this.lblBlockingSession.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblBlockingSession.Location = new System.Drawing.Point(124, 50);
            this.lblBlockingSession.Name = "lblBlockingSession";
            this.lblBlockingSession.Size = new System.Drawing.Size(17, 19);
            this.lblBlockingSession.TabIndex = 68;
            this.lblBlockingSession.Text = "0";
            // 
            // lblQryPlan
            // 
            this.lblQryPlan.AutoSize = true;
            this.lblQryPlan.Location = new System.Drawing.Point(91, 516);
            this.lblQryPlan.Name = "lblQryPlan";
            this.lblQryPlan.Size = new System.Drawing.Size(85, 19);
            this.lblQryPlan.TabIndex = 100;
            this.lblQryPlan.Text = "0x000000000";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblHost.Location = new System.Drawing.Point(124, 71);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(36, 19);
            this.lblHost.TabIndex = 55;
            this.lblHost.Text = "host";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(9, 71);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(75, 19);
            this.metroLabel4.TabIndex = 54;
            this.metroLabel4.Text = "Hostname:";
            // 
            // metroLabel36
            // 
            this.metroLabel36.AutoSize = true;
            this.metroLabel36.Location = new System.Drawing.Point(7, 516);
            this.metroLabel36.Name = "metroLabel36";
            this.metroLabel36.Size = new System.Drawing.Size(78, 19);
            this.metroLabel36.TabIndex = 99;
            this.metroLabel36.Text = "Query Plan:";
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDatabase.Location = new System.Drawing.Point(124, 91);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(51, 19);
            this.lblDatabase.TabIndex = 51;
            this.lblDatabase.Text = "master";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(9, 91);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(69, 19);
            this.metroLabel3.TabIndex = 49;
            this.metroLabel3.Text = "Database:";
            // 
            // txtCmdSql
            // 
            this.txtCmdSql.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.txtCmdSql.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCmdSql.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.txtCmdSql.Location = new System.Drawing.Point(7, 375);
            this.txtCmdSql.Name = "txtCmdSql";
            this.txtCmdSql.ReadOnly = true;
            this.txtCmdSql.Size = new System.Drawing.Size(608, 134);
            this.txtCmdSql.TabIndex = 98;
            this.txtCmdSql.Text = "";
            // 
            // metroLabel34
            // 
            this.metroLabel34.AutoSize = true;
            this.metroLabel34.Location = new System.Drawing.Point(7, 353);
            this.metroLabel34.Name = "metroLabel34";
            this.metroLabel34.Size = new System.Drawing.Size(99, 19);
            this.metroLabel34.TabIndex = 97;
            this.metroLabel34.Text = "Full Command:";
            // 
            // txtCurrentStatement
            // 
            this.txtCurrentStatement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.txtCurrentStatement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCurrentStatement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.txtCurrentStatement.Location = new System.Drawing.Point(7, 254);
            this.txtCurrentStatement.Name = "txtCurrentStatement";
            this.txtCurrentStatement.ReadOnly = true;
            this.txtCurrentStatement.Size = new System.Drawing.Size(608, 96);
            this.txtCurrentStatement.TabIndex = 96;
            this.txtCurrentStatement.Text = "";
            // 
            // metroLabel30
            // 
            this.metroLabel30.AutoSize = true;
            this.metroLabel30.Location = new System.Drawing.Point(7, 232);
            this.metroLabel30.Name = "metroLabel30";
            this.metroLabel30.Size = new System.Drawing.Size(119, 19);
            this.metroLabel30.TabIndex = 95;
            this.metroLabel30.Text = "Current Statement:";
            // 
            // lblCommand
            // 
            this.lblCommand.AutoSize = true;
            this.lblCommand.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblCommand.Location = new System.Drawing.Point(124, 137);
            this.lblCommand.Name = "lblCommand";
            this.lblCommand.Size = new System.Drawing.Size(61, 19);
            this.lblCommand.TabIndex = 94;
            this.lblCommand.Text = "BACKUP";
            // 
            // metroLabel35
            // 
            this.metroLabel35.AutoSize = true;
            this.metroLabel35.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel35.Location = new System.Drawing.Point(9, 137);
            this.metroLabel35.Name = "metroLabel35";
            this.metroLabel35.Size = new System.Drawing.Size(76, 19);
            this.metroLabel35.TabIndex = 93;
            this.metroLabel35.Text = "Command:";
            // 
            // lblWaitResource
            // 
            this.lblWaitResource.AutoSize = true;
            this.lblWaitResource.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblWaitResource.Location = new System.Drawing.Point(337, 5);
            this.lblWaitResource.Name = "lblWaitResource";
            this.lblWaitResource.Size = new System.Drawing.Size(84, 19);
            this.lblWaitResource.TabIndex = 92;
            this.lblWaitResource.Text = "0:000XX000";
            // 
            // metroLabel33
            // 
            this.metroLabel33.AutoSize = true;
            this.metroLabel33.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel33.Location = new System.Drawing.Point(229, 5);
            this.metroLabel33.Name = "metroLabel33";
            this.metroLabel33.Size = new System.Drawing.Size(98, 19);
            this.metroLabel33.TabIndex = 91;
            this.metroLabel33.Text = "Wait Resource:";
            // 
            // lblWaitTime
            // 
            this.lblWaitTime.AutoSize = true;
            this.lblWaitTime.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblWaitTime.Location = new System.Drawing.Point(532, 5);
            this.lblWaitTime.Name = "lblWaitTime";
            this.lblWaitTime.Size = new System.Drawing.Size(17, 19);
            this.lblWaitTime.TabIndex = 90;
            this.lblWaitTime.Text = "0";
            // 
            // metroLabel32
            // 
            this.metroLabel32.AutoSize = true;
            this.metroLabel32.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel32.Location = new System.Drawing.Point(454, 5);
            this.metroLabel32.Name = "metroLabel32";
            this.metroLabel32.Size = new System.Drawing.Size(72, 19);
            this.metroLabel32.TabIndex = 89;
            this.metroLabel32.Text = "Wait Time:";
            // 
            // lblWaitType
            // 
            this.lblWaitType.AutoSize = true;
            this.lblWaitType.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblWaitType.Location = new System.Drawing.Point(80, 5);
            this.lblWaitType.Name = "lblWaitType";
            this.lblWaitType.Size = new System.Drawing.Size(106, 19);
            this.lblWaitType.TabIndex = 88;
            this.lblWaitType.Text = "Some Wait Type";
            // 
            // metroLabel31
            // 
            this.metroLabel31.AutoSize = true;
            this.metroLabel31.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel31.Location = new System.Drawing.Point(9, 5);
            this.metroLabel31.Name = "metroLabel31";
            this.metroLabel31.Size = new System.Drawing.Size(71, 19);
            this.metroLabel31.TabIndex = 87;
            this.metroLabel31.Text = "Wait Type:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblStatus.Location = new System.Drawing.Point(124, 113);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(59, 19);
            this.lblStatus.TabIndex = 86;
            this.lblStatus.Text = "sleeping";
            // 
            // metroLabel29
            // 
            this.metroLabel29.AutoSize = true;
            this.metroLabel29.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel29.Location = new System.Drawing.Point(9, 113);
            this.metroLabel29.Name = "metroLabel29";
            this.metroLabel29.Size = new System.Drawing.Size(50, 19);
            this.metroLabel29.TabIndex = 85;
            this.metroLabel29.Text = "Status:";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblStartTime.Location = new System.Drawing.Point(137, 7);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(170, 19);
            this.lblStartTime.TabIndex = 84;
            this.lblStartTime.Text = "1900-01-01 00:00:00.000";
            // 
            // metroLabel27
            // 
            this.metroLabel27.AutoSize = true;
            this.metroLabel27.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel27.Location = new System.Drawing.Point(3, 7);
            this.metroLabel27.Name = "metroLabel27";
            this.metroLabel27.Size = new System.Drawing.Size(74, 19);
            this.metroLabel27.TabIndex = 83;
            this.metroLabel27.Text = "Start Time:";
            // 
            // lblLogicalReads
            // 
            this.lblLogicalReads.AutoSize = true;
            this.lblLogicalReads.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblLogicalReads.Location = new System.Drawing.Point(288, 4);
            this.lblLogicalReads.Name = "lblLogicalReads";
            this.lblLogicalReads.Size = new System.Drawing.Size(17, 19);
            this.lblLogicalReads.TabIndex = 82;
            this.lblLogicalReads.Text = "0";
            // 
            // metroLabel26
            // 
            this.metroLabel26.AutoSize = true;
            this.metroLabel26.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel26.Location = new System.Drawing.Point(188, 4);
            this.metroLabel26.Name = "metroLabel26";
            this.metroLabel26.Size = new System.Drawing.Size(94, 19);
            this.metroLabel26.TabIndex = 81;
            this.metroLabel26.Text = "Logical Reads:";
            // 
            // lblWrites
            // 
            this.lblWrites.AutoSize = true;
            this.lblWrites.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblWrites.Location = new System.Drawing.Point(105, 26);
            this.lblWrites.Name = "lblWrites";
            this.lblWrites.Size = new System.Drawing.Size(17, 19);
            this.lblWrites.TabIndex = 80;
            this.lblWrites.Text = "0";
            // 
            // metroLabel25
            // 
            this.metroLabel25.AutoSize = true;
            this.metroLabel25.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel25.Location = new System.Drawing.Point(6, 26);
            this.metroLabel25.Name = "metroLabel25";
            this.metroLabel25.Size = new System.Drawing.Size(51, 19);
            this.metroLabel25.TabIndex = 79;
            this.metroLabel25.Text = "Writes:";
            // 
            // lblReads
            // 
            this.lblReads.AutoSize = true;
            this.lblReads.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblReads.Location = new System.Drawing.Point(288, 30);
            this.lblReads.Name = "lblReads";
            this.lblReads.Size = new System.Drawing.Size(17, 19);
            this.lblReads.TabIndex = 78;
            this.lblReads.Text = "0";
            // 
            // metroLabel24
            // 
            this.metroLabel24.AutoSize = true;
            this.metroLabel24.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel24.Location = new System.Drawing.Point(188, 30);
            this.metroLabel24.Name = "metroLabel24";
            this.metroLabel24.Size = new System.Drawing.Size(48, 19);
            this.metroLabel24.TabIndex = 77;
            this.metroLabel24.Text = "Reads:";
            // 
            // lblTotalElapsedTime
            // 
            this.lblTotalElapsedTime.AutoSize = true;
            this.lblTotalElapsedTime.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTotalElapsedTime.Location = new System.Drawing.Point(137, 74);
            this.lblTotalElapsedTime.Name = "lblTotalElapsedTime";
            this.lblTotalElapsedTime.Size = new System.Drawing.Size(17, 19);
            this.lblTotalElapsedTime.TabIndex = 76;
            this.lblTotalElapsedTime.Text = "0";
            // 
            // metroLabel23
            // 
            this.metroLabel23.AutoSize = true;
            this.metroLabel23.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel23.Location = new System.Drawing.Point(4, 74);
            this.metroLabel23.Name = "metroLabel23";
            this.metroLabel23.Size = new System.Drawing.Size(91, 19);
            this.metroLabel23.TabIndex = 75;
            this.metroLabel23.Text = "Elapsed Time:";
            // 
            // lblCpuTime
            // 
            this.lblCpuTime.AutoSize = true;
            this.lblCpuTime.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblCpuTime.Location = new System.Drawing.Point(105, 4);
            this.lblCpuTime.Name = "lblCpuTime";
            this.lblCpuTime.Size = new System.Drawing.Size(17, 19);
            this.lblCpuTime.TabIndex = 74;
            this.lblCpuTime.Text = "0";
            // 
            // metroLabel22
            // 
            this.metroLabel22.AutoSize = true;
            this.metroLabel22.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel22.Location = new System.Drawing.Point(6, 4);
            this.metroLabel22.Name = "metroLabel22";
            this.metroLabel22.Size = new System.Drawing.Size(72, 19);
            this.metroLabel22.TabIndex = 73;
            this.metroLabel22.Text = "CPU Time:";
            // 
            // lblPercentCompleted
            // 
            this.lblPercentCompleted.AutoSize = true;
            this.lblPercentCompleted.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblPercentCompleted.Location = new System.Drawing.Point(137, 29);
            this.lblPercentCompleted.Name = "lblPercentCompleted";
            this.lblPercentCompleted.Size = new System.Drawing.Size(17, 19);
            this.lblPercentCompleted.TabIndex = 72;
            this.lblPercentCompleted.Text = "0";
            // 
            // metroLabel21
            // 
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel21.Location = new System.Drawing.Point(3, 29);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(128, 19);
            this.metroLabel21.TabIndex = 71;
            this.metroLabel21.Text = "Percent Completed:";
            // 
            // lblOpenTrancount
            // 
            this.lblOpenTrancount.AutoSize = true;
            this.lblOpenTrancount.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblOpenTrancount.Location = new System.Drawing.Point(137, 53);
            this.lblOpenTrancount.Name = "lblOpenTrancount";
            this.lblOpenTrancount.Size = new System.Drawing.Size(17, 19);
            this.lblOpenTrancount.TabIndex = 70;
            this.lblOpenTrancount.Text = "0";
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel20.Location = new System.Drawing.Point(3, 53);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(111, 19);
            this.metroLabel20.TabIndex = 69;
            this.metroLabel20.Text = "Open Trancount:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(6, 50);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(112, 19);
            this.metroLabel8.TabIndex = 66;
            this.metroLabel8.Text = "Blocking Session:";
            // 
            // lblProgramName
            // 
            this.lblProgramName.AutoSize = true;
            this.lblProgramName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblProgramName.Location = new System.Drawing.Point(124, 27);
            this.lblProgramName.Name = "lblProgramName";
            this.lblProgramName.Size = new System.Drawing.Size(62, 19);
            this.lblProgramName.TabIndex = 59;
            this.lblProgramName.Text = "program";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel12.Location = new System.Drawing.Point(6, 27);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(103, 19);
            this.metroLabel12.TabIndex = 58;
            this.metroLabel12.Text = "Program name:";
            // 
            // lblSpid
            // 
            this.lblSpid.AutoSize = true;
            this.lblSpid.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblSpid.Location = new System.Drawing.Point(124, 7);
            this.lblSpid.Name = "lblSpid";
            this.lblSpid.Size = new System.Drawing.Size(17, 19);
            this.lblSpid.TabIndex = 48;
            this.lblSpid.Text = "0";
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel18.Location = new System.Drawing.Point(6, 7);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(75, 19);
            this.metroLabel18.TabIndex = 47;
            this.metroLabel18.Text = "Session ID:";
            // 
            // InfoTile
            // 
            this.InfoTile.ActiveControl = null;
            this.InfoTile.Controls.Add(this.metroLabel18);
            this.InfoTile.Controls.Add(this.lblBlockingSession);
            this.InfoTile.Controls.Add(this.lblSpid);
            this.InfoTile.Controls.Add(this.metroLabel12);
            this.InfoTile.Controls.Add(this.lblHost);
            this.InfoTile.Controls.Add(this.lblProgramName);
            this.InfoTile.Controls.Add(this.metroLabel4);
            this.InfoTile.Controls.Add(this.lblDatabase);
            this.InfoTile.Controls.Add(this.metroLabel8);
            this.InfoTile.Controls.Add(this.metroLabel3);
            this.InfoTile.Controls.Add(this.lblCommand);
            this.InfoTile.Controls.Add(this.metroLabel29);
            this.InfoTile.Controls.Add(this.metroLabel35);
            this.InfoTile.Controls.Add(this.lblStatus);
            this.InfoTile.Location = new System.Drawing.Point(7, 27);
            this.InfoTile.Name = "InfoTile";
            this.InfoTile.Size = new System.Drawing.Size(249, 165);
            this.InfoTile.TabIndex = 101;
            this.InfoTile.UseSelectable = true;
            // 
            // tileStatus
            // 
            this.tileStatus.ActiveControl = null;
            this.tileStatus.Controls.Add(this.metroLabel27);
            this.tileStatus.Controls.Add(this.lblStartTime);
            this.tileStatus.Controls.Add(this.metroLabel21);
            this.tileStatus.Controls.Add(this.lblPercentCompleted);
            this.tileStatus.Controls.Add(this.metroLabel20);
            this.tileStatus.Controls.Add(this.lblOpenTrancount);
            this.tileStatus.Controls.Add(this.metroLabel23);
            this.tileStatus.Controls.Add(this.lblTotalElapsedTime);
            this.tileStatus.Location = new System.Drawing.Point(262, 27);
            this.tileStatus.Name = "tileStatus";
            this.tileStatus.Size = new System.Drawing.Size(353, 101);
            this.tileStatus.TabIndex = 102;
            this.tileStatus.UseSelectable = true;
            // 
            // tileResource
            // 
            this.tileResource.ActiveControl = null;
            this.tileResource.Controls.Add(this.metroLabel22);
            this.tileResource.Controls.Add(this.lblCpuTime);
            this.tileResource.Controls.Add(this.metroLabel24);
            this.tileResource.Controls.Add(this.lblReads);
            this.tileResource.Controls.Add(this.metroLabel25);
            this.tileResource.Controls.Add(this.lblWrites);
            this.tileResource.Controls.Add(this.metroLabel26);
            this.tileResource.Controls.Add(this.lblLogicalReads);
            this.tileResource.Location = new System.Drawing.Point(262, 134);
            this.tileResource.Name = "tileResource";
            this.tileResource.Size = new System.Drawing.Size(353, 58);
            this.tileResource.TabIndex = 103;
            this.tileResource.UseSelectable = true;
            // 
            // tileWait
            // 
            this.tileWait.ActiveControl = null;
            this.tileWait.Controls.Add(this.metroLabel31);
            this.tileWait.Controls.Add(this.lblWaitType);
            this.tileWait.Controls.Add(this.metroLabel33);
            this.tileWait.Controls.Add(this.lblWaitResource);
            this.tileWait.Controls.Add(this.metroLabel32);
            this.tileWait.Controls.Add(this.lblWaitTime);
            this.tileWait.Location = new System.Drawing.Point(7, 198);
            this.tileWait.Name = "tileWait";
            this.tileWait.Size = new System.Drawing.Size(608, 31);
            this.tileWait.TabIndex = 104;
            this.tileWait.UseSelectable = true;
            // 
            // frmDetailSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 550);
            this.Controls.Add(this.pnlBG);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDetailSession";
            this.Text = "frmDetailSession";
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.pnlBG.ResumeLayout(false);
            this.pnlBG.PerformLayout();
            this.InfoTile.ResumeLayout(false);
            this.InfoTile.PerformLayout();
            this.tileStatus.ResumeLayout(false);
            this.tileStatus.PerformLayout();
            this.tileResource.ResumeLayout(false);
            this.tileResource.PerformLayout();
            this.tileWait.ResumeLayout(false);
            this.tileWait.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private System.Windows.Forms.Panel pnlTop;
        private MetroFramework.Controls.MetroPanel pnlBG;
        private System.Windows.Forms.Button btnClose;
        private MetroFramework.Controls.MetroLabel lblBlockingSession;
        private MetroFramework.Controls.MetroLabel lblQryPlan;
        private MetroFramework.Controls.MetroLabel lblHost;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel36;
        private MetroFramework.Controls.MetroLabel lblDatabase;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.RichTextBox txtCmdSql;
        private MetroFramework.Controls.MetroLabel metroLabel34;
        private System.Windows.Forms.RichTextBox txtCurrentStatement;
        private MetroFramework.Controls.MetroLabel metroLabel30;
        private MetroFramework.Controls.MetroLabel lblCommand;
        private MetroFramework.Controls.MetroLabel metroLabel35;
        private MetroFramework.Controls.MetroLabel lblWaitResource;
        private MetroFramework.Controls.MetroLabel metroLabel33;
        private MetroFramework.Controls.MetroLabel lblWaitTime;
        private MetroFramework.Controls.MetroLabel metroLabel32;
        private MetroFramework.Controls.MetroLabel lblWaitType;
        private MetroFramework.Controls.MetroLabel metroLabel31;
        private MetroFramework.Controls.MetroLabel lblStatus;
        private MetroFramework.Controls.MetroLabel metroLabel29;
        private MetroFramework.Controls.MetroLabel lblStartTime;
        private MetroFramework.Controls.MetroLabel metroLabel27;
        private MetroFramework.Controls.MetroLabel lblLogicalReads;
        private MetroFramework.Controls.MetroLabel metroLabel26;
        private MetroFramework.Controls.MetroLabel lblWrites;
        private MetroFramework.Controls.MetroLabel metroLabel25;
        private MetroFramework.Controls.MetroLabel lblReads;
        private MetroFramework.Controls.MetroLabel metroLabel24;
        private MetroFramework.Controls.MetroLabel lblTotalElapsedTime;
        private MetroFramework.Controls.MetroLabel metroLabel23;
        private MetroFramework.Controls.MetroLabel lblCpuTime;
        private MetroFramework.Controls.MetroLabel metroLabel22;
        private MetroFramework.Controls.MetroLabel lblPercentCompleted;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private MetroFramework.Controls.MetroLabel lblOpenTrancount;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel lblProgramName;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel lblSpid;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroTile InfoTile;
        private MetroFramework.Controls.MetroTile tileStatus;
        private MetroFramework.Controls.MetroTile tileResource;
        private MetroFramework.Controls.MetroTile tileWait;
    }
}