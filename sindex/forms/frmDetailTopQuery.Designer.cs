namespace sindex.forms
{
    partial class frmDetailTopQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetailTopQuery));
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlBG = new MetroFramework.Controls.MetroPanel();
            this.tileStatus = new MetroFramework.Controls.MetroTile();
            this.metroLabel27 = new MetroFramework.Controls.MetroLabel();
            this.lblExecutionCount = new MetroFramework.Controls.MetroLabel();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.lblDatabaseName = new MetroFramework.Controls.MetroLabel();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.lblAvgUsedThreads = new MetroFramework.Controls.MetroLabel();
            this.metroLabel23 = new MetroFramework.Controls.MetroLabel();
            this.lblAvgMaxDop = new MetroFramework.Controls.MetroLabel();
            this.InfoTile = new MetroFramework.Controls.MetroTile();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.lblTotalWorkerTime = new MetroFramework.Controls.MetroLabel();
            this.lblCreateTime = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.lblAvgCPUTime = new MetroFramework.Controls.MetroLabel();
            this.lblLastExecution = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lblAvgPhysicalReads = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lblAvgElapsedTime = new MetroFramework.Controls.MetroLabel();
            this.metroLabel29 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel35 = new MetroFramework.Controls.MetroLabel();
            this.lblAvgLogicalWrites = new MetroFramework.Controls.MetroLabel();
            this.lblQryPlan = new MetroFramework.Controls.MetroLabel();
            this.metroLabel36 = new MetroFramework.Controls.MetroLabel();
            this.txtCmdSql = new System.Windows.Forms.RichTextBox();
            this.metroLabel34 = new MetroFramework.Controls.MetroLabel();
            this.txtCurrentStatement = new System.Windows.Forms.RichTextBox();
            this.metroLabel30 = new MetroFramework.Controls.MetroLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lnkOpenSsms = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.pnlBG.SuspendLayout();
            this.tileStatus.SuspendLayout();
            this.InfoTile.SuspendLayout();
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
            this.pnlBG.Controls.Add(this.lnkOpenSsms);
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
            // tileStatus
            // 
            this.tileStatus.ActiveControl = null;
            this.tileStatus.Controls.Add(this.lblAvgCPUTime);
            this.tileStatus.Controls.Add(this.metroLabel20);
            this.tileStatus.Controls.Add(this.lblAvgUsedThreads);
            this.tileStatus.Controls.Add(this.metroLabel4);
            this.tileStatus.Controls.Add(this.lblAvgPhysicalReads);
            this.tileStatus.Controls.Add(this.metroLabel23);
            this.tileStatus.Controls.Add(this.lblAvgMaxDop);
            this.tileStatus.Controls.Add(this.metroLabel3);
            this.tileStatus.Controls.Add(this.lblAvgLogicalWrites);
            this.tileStatus.Controls.Add(this.lblAvgElapsedTime);
            this.tileStatus.Controls.Add(this.metroLabel35);
            this.tileStatus.Controls.Add(this.metroLabel29);
            this.tileStatus.Location = new System.Drawing.Point(331, 28);
            this.tileStatus.Name = "tileStatus";
            this.tileStatus.Size = new System.Drawing.Size(284, 163);
            this.tileStatus.TabIndex = 102;
            this.tileStatus.UseSelectable = true;
            // 
            // metroLabel27
            // 
            this.metroLabel27.AutoSize = true;
            this.metroLabel27.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel27.Location = new System.Drawing.Point(6, 97);
            this.metroLabel27.Name = "metroLabel27";
            this.metroLabel27.Size = new System.Drawing.Size(112, 19);
            this.metroLabel27.TabIndex = 83;
            this.metroLabel27.Text = "Execution Count:";
            // 
            // lblExecutionCount
            // 
            this.lblExecutionCount.AutoSize = true;
            this.lblExecutionCount.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblExecutionCount.Location = new System.Drawing.Point(143, 97);
            this.lblExecutionCount.Name = "lblExecutionCount";
            this.lblExecutionCount.Size = new System.Drawing.Size(17, 19);
            this.lblExecutionCount.TabIndex = 84;
            this.lblExecutionCount.Text = "0";
            // 
            // metroLabel21
            // 
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel21.Location = new System.Drawing.Point(6, 72);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(69, 19);
            this.metroLabel21.TabIndex = 71;
            this.metroLabel21.Text = "Database:";
            // 
            // lblDatabaseName
            // 
            this.lblDatabaseName.AutoSize = true;
            this.lblDatabaseName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDatabaseName.Location = new System.Drawing.Point(143, 72);
            this.lblDatabaseName.Name = "lblDatabaseName";
            this.lblDatabaseName.Size = new System.Drawing.Size(47, 19);
            this.lblDatabaseName.TabIndex = 72;
            this.lblDatabaseName.Text = "sindex";
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel20.Location = new System.Drawing.Point(4, 7);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(126, 19);
            this.metroLabel20.TabIndex = 69;
            this.metroLabel20.Text = "AVG Used Threads:";
            // 
            // lblAvgUsedThreads
            // 
            this.lblAvgUsedThreads.AutoSize = true;
            this.lblAvgUsedThreads.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblAvgUsedThreads.Location = new System.Drawing.Point(138, 7);
            this.lblAvgUsedThreads.Name = "lblAvgUsedThreads";
            this.lblAvgUsedThreads.Size = new System.Drawing.Size(17, 19);
            this.lblAvgUsedThreads.TabIndex = 70;
            this.lblAvgUsedThreads.Text = "0";
            // 
            // metroLabel23
            // 
            this.metroLabel23.AutoSize = true;
            this.metroLabel23.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel23.Location = new System.Drawing.Point(5, 27);
            this.metroLabel23.Name = "metroLabel23";
            this.metroLabel23.Size = new System.Drawing.Size(102, 19);
            this.metroLabel23.TabIndex = 75;
            this.metroLabel23.Text = "AVG Max DOP:";
            // 
            // lblAvgMaxDop
            // 
            this.lblAvgMaxDop.AutoSize = true;
            this.lblAvgMaxDop.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblAvgMaxDop.Location = new System.Drawing.Point(138, 27);
            this.lblAvgMaxDop.Name = "lblAvgMaxDop";
            this.lblAvgMaxDop.Size = new System.Drawing.Size(17, 19);
            this.lblAvgMaxDop.TabIndex = 76;
            this.lblAvgMaxDop.Text = "0";
            // 
            // InfoTile
            // 
            this.InfoTile.ActiveControl = null;
            this.InfoTile.Controls.Add(this.metroLabel27);
            this.InfoTile.Controls.Add(this.lblExecutionCount);
            this.InfoTile.Controls.Add(this.metroLabel18);
            this.InfoTile.Controls.Add(this.lblTotalWorkerTime);
            this.InfoTile.Controls.Add(this.metroLabel21);
            this.InfoTile.Controls.Add(this.lblDatabaseName);
            this.InfoTile.Controls.Add(this.lblCreateTime);
            this.InfoTile.Controls.Add(this.metroLabel12);
            this.InfoTile.Controls.Add(this.lblLastExecution);
            this.InfoTile.Controls.Add(this.metroLabel8);
            this.InfoTile.Location = new System.Drawing.Point(7, 28);
            this.InfoTile.Name = "InfoTile";
            this.InfoTile.Size = new System.Drawing.Size(318, 163);
            this.InfoTile.TabIndex = 101;
            this.InfoTile.UseSelectable = true;
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel18.Location = new System.Drawing.Point(6, 7);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(85, 19);
            this.metroLabel18.TabIndex = 47;
            this.metroLabel18.Text = "Create Time:";
            // 
            // lblTotalWorkerTime
            // 
            this.lblTotalWorkerTime.AutoSize = true;
            this.lblTotalWorkerTime.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTotalWorkerTime.Location = new System.Drawing.Point(143, 50);
            this.lblTotalWorkerTime.Name = "lblTotalWorkerTime";
            this.lblTotalWorkerTime.Size = new System.Drawing.Size(17, 19);
            this.lblTotalWorkerTime.TabIndex = 68;
            this.lblTotalWorkerTime.Text = "0";
            // 
            // lblCreateTime
            // 
            this.lblCreateTime.AutoSize = true;
            this.lblCreateTime.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblCreateTime.Location = new System.Drawing.Point(143, 7);
            this.lblCreateTime.Name = "lblCreateTime";
            this.lblCreateTime.Size = new System.Drawing.Size(170, 19);
            this.lblCreateTime.TabIndex = 48;
            this.lblCreateTime.Text = "1900-01-01 12:00:00.000";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel12.Location = new System.Drawing.Point(6, 27);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(99, 19);
            this.metroLabel12.TabIndex = 58;
            this.metroLabel12.Text = "Last Execution:";
            // 
            // lblAvgCPUTime
            // 
            this.lblAvgCPUTime.AutoSize = true;
            this.lblAvgCPUTime.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblAvgCPUTime.Location = new System.Drawing.Point(138, 50);
            this.lblAvgCPUTime.Name = "lblAvgCPUTime";
            this.lblAvgCPUTime.Size = new System.Drawing.Size(17, 19);
            this.lblAvgCPUTime.TabIndex = 55;
            this.lblAvgCPUTime.Text = "0";
            // 
            // lblLastExecution
            // 
            this.lblLastExecution.AutoSize = true;
            this.lblLastExecution.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblLastExecution.Location = new System.Drawing.Point(143, 27);
            this.lblLastExecution.Name = "lblLastExecution";
            this.lblLastExecution.Size = new System.Drawing.Size(170, 19);
            this.lblLastExecution.TabIndex = 59;
            this.lblLastExecution.Text = "1900-01-01 12:00:00.000";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(5, 50);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(103, 19);
            this.metroLabel4.TabIndex = 54;
            this.metroLabel4.Text = "AVG CPU Time:";
            // 
            // lblAvgPhysicalReads
            // 
            this.lblAvgPhysicalReads.AutoSize = true;
            this.lblAvgPhysicalReads.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblAvgPhysicalReads.Location = new System.Drawing.Point(138, 72);
            this.lblAvgPhysicalReads.Name = "lblAvgPhysicalReads";
            this.lblAvgPhysicalReads.Size = new System.Drawing.Size(17, 19);
            this.lblAvgPhysicalReads.TabIndex = 51;
            this.lblAvgPhysicalReads.Text = "0";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(6, 50);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(122, 19);
            this.metroLabel8.TabIndex = 66;
            this.metroLabel8.Text = "Total Worker Time:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(5, 72);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(131, 19);
            this.metroLabel3.TabIndex = 49;
            this.metroLabel3.Text = "AVG Physical Reads:";
            // 
            // lblAvgElapsedTime
            // 
            this.lblAvgElapsedTime.AutoSize = true;
            this.lblAvgElapsedTime.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblAvgElapsedTime.Location = new System.Drawing.Point(139, 122);
            this.lblAvgElapsedTime.Name = "lblAvgElapsedTime";
            this.lblAvgElapsedTime.Size = new System.Drawing.Size(17, 19);
            this.lblAvgElapsedTime.TabIndex = 94;
            this.lblAvgElapsedTime.Text = "0";
            // 
            // metroLabel29
            // 
            this.metroLabel29.AutoSize = true;
            this.metroLabel29.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel29.Location = new System.Drawing.Point(5, 97);
            this.metroLabel29.Name = "metroLabel29";
            this.metroLabel29.Size = new System.Drawing.Size(128, 19);
            this.metroLabel29.TabIndex = 85;
            this.metroLabel29.Text = "AVG Logical Writes:";
            // 
            // metroLabel35
            // 
            this.metroLabel35.AutoSize = true;
            this.metroLabel35.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel35.Location = new System.Drawing.Point(5, 122);
            this.metroLabel35.Name = "metroLabel35";
            this.metroLabel35.Size = new System.Drawing.Size(122, 19);
            this.metroLabel35.TabIndex = 93;
            this.metroLabel35.Text = "AVG Elapsed Time:";
            // 
            // lblAvgLogicalWrites
            // 
            this.lblAvgLogicalWrites.AutoSize = true;
            this.lblAvgLogicalWrites.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblAvgLogicalWrites.Location = new System.Drawing.Point(139, 97);
            this.lblAvgLogicalWrites.Name = "lblAvgLogicalWrites";
            this.lblAvgLogicalWrites.Size = new System.Drawing.Size(17, 19);
            this.lblAvgLogicalWrites.TabIndex = 86;
            this.lblAvgLogicalWrites.Text = "0";
            // 
            // lblQryPlan
            // 
            this.lblQryPlan.Location = new System.Drawing.Point(91, 516);
            this.lblQryPlan.Name = "lblQryPlan";
            this.lblQryPlan.Size = new System.Drawing.Size(395, 19);
            this.lblQryPlan.TabIndex = 100;
            this.lblQryPlan.Text = "0x000000000";
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
            // txtCmdSql
            // 
            this.txtCmdSql.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.txtCmdSql.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCmdSql.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCmdSql.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.txtCmdSql.Location = new System.Drawing.Point(7, 369);
            this.txtCmdSql.Name = "txtCmdSql";
            this.txtCmdSql.ReadOnly = true;
            this.txtCmdSql.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtCmdSql.Size = new System.Drawing.Size(608, 136);
            this.txtCmdSql.TabIndex = 98;
            this.txtCmdSql.Text = "";
            this.txtCmdSql.WordWrap = false;
            // 
            // metroLabel34
            // 
            this.metroLabel34.AutoSize = true;
            this.metroLabel34.Location = new System.Drawing.Point(13, 347);
            this.metroLabel34.Name = "metroLabel34";
            this.metroLabel34.Size = new System.Drawing.Size(99, 19);
            this.metroLabel34.TabIndex = 97;
            this.metroLabel34.Text = "Full Command:";
            // 
            // txtCurrentStatement
            // 
            this.txtCurrentStatement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.txtCurrentStatement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCurrentStatement.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentStatement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.txtCurrentStatement.Location = new System.Drawing.Point(7, 219);
            this.txtCurrentStatement.Name = "txtCurrentStatement";
            this.txtCurrentStatement.ReadOnly = true;
            this.txtCurrentStatement.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtCurrentStatement.Size = new System.Drawing.Size(608, 125);
            this.txtCurrentStatement.TabIndex = 96;
            this.txtCurrentStatement.Text = "";
            this.txtCurrentStatement.WordWrap = false;
            // 
            // metroLabel30
            // 
            this.metroLabel30.AutoSize = true;
            this.metroLabel30.Location = new System.Drawing.Point(7, 197);
            this.metroLabel30.Name = "metroLabel30";
            this.metroLabel30.Size = new System.Drawing.Size(119, 19);
            this.metroLabel30.TabIndex = 95;
            this.metroLabel30.Text = "Current Statement:";
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
            // lnkOpenSsms
            // 
            this.lnkOpenSsms.Location = new System.Drawing.Point(494, 516);
            this.lnkOpenSsms.Name = "lnkOpenSsms";
            this.lnkOpenSsms.Size = new System.Drawing.Size(121, 23);
            this.lnkOpenSsms.TabIndex = 103;
            this.lnkOpenSsms.Text = "Open Plan In SSMS";
            this.lnkOpenSsms.UseSelectable = true;
            this.lnkOpenSsms.Click += new System.EventHandler(this.lnkOpenSsms_Click);
            // 
            // frmDetailTopQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 550);
            this.Controls.Add(this.pnlBG);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDetailTopQuery";
            this.Text = "frmDetailSession";
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.pnlBG.ResumeLayout(false);
            this.pnlBG.PerformLayout();
            this.tileStatus.ResumeLayout(false);
            this.tileStatus.PerformLayout();
            this.InfoTile.ResumeLayout(false);
            this.InfoTile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private System.Windows.Forms.Panel pnlTop;
        private MetroFramework.Controls.MetroPanel pnlBG;
        private System.Windows.Forms.Button btnClose;
        private MetroFramework.Controls.MetroLabel lblTotalWorkerTime;
        private MetroFramework.Controls.MetroLabel lblQryPlan;
        private MetroFramework.Controls.MetroLabel lblAvgCPUTime;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel36;
        private MetroFramework.Controls.MetroLabel lblAvgPhysicalReads;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.RichTextBox txtCmdSql;
        private MetroFramework.Controls.MetroLabel metroLabel34;
        private System.Windows.Forms.RichTextBox txtCurrentStatement;
        private MetroFramework.Controls.MetroLabel metroLabel30;
        private MetroFramework.Controls.MetroLabel lblAvgElapsedTime;
        private MetroFramework.Controls.MetroLabel metroLabel35;
        private MetroFramework.Controls.MetroLabel lblAvgLogicalWrites;
        private MetroFramework.Controls.MetroLabel metroLabel29;
        private MetroFramework.Controls.MetroLabel lblExecutionCount;
        private MetroFramework.Controls.MetroLabel metroLabel27;
        private MetroFramework.Controls.MetroLabel lblAvgMaxDop;
        private MetroFramework.Controls.MetroLabel metroLabel23;
        private MetroFramework.Controls.MetroLabel lblDatabaseName;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private MetroFramework.Controls.MetroLabel lblAvgUsedThreads;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel lblLastExecution;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel lblCreateTime;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroTile InfoTile;
        private MetroFramework.Controls.MetroTile tileStatus;
        private MetroFramework.Controls.MetroLink lnkOpenSsms;
    }
}