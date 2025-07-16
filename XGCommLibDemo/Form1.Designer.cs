namespace XGCommLibDemo
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPlcWrtAddr = new System.Windows.Forms.TextBox();
            this.lblPlcWrtAddr = new System.Windows.Forms.Label();
            this.txtPlcRdAddr = new System.Windows.Forms.TextBox();
            this.lblPlcRdAddr = new System.Windows.Forms.Label();
            this.txtWriteNoPlc = new System.Windows.Forms.TextBox();
            this.lblPlcWrtNo = new System.Windows.Forms.Label();
            this.txtReadNoPlc = new System.Windows.Forms.TextBox();
            this.lblPlcRdNo = new System.Windows.Forms.Label();
            this.btnOpenPort = new System.Windows.Forms.Button();
            this.chkKeepAlive = new System.Windows.Forms.CheckBox();
            this.chkAliveStatus = new System.Windows.Forms.CheckBox();
            this.txtIpAddrPlc = new System.Windows.Forms.TextBox();
            this.txtPortNo = new System.Windows.Forms.TextBox();
            this.lblPortNo = new System.Windows.Forms.Label();
            this.lblPlcIP = new System.Windows.Forms.Label();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.tmKeepAlive = new System.Windows.Forms.Timer(this.components);
            this.tmUpdateCtrl = new System.Windows.Forms.Timer(this.components);
            this.tmLibTest = new System.Windows.Forms.Timer(this.components);
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblMain = new System.Windows.Forms.Label();
            this.process1 = new System.Diagnostics.Process();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnManual = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.btnIO = new System.Windows.Forms.Button();
            this.bntPlcComm = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bntPlcComm);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtPlcWrtAddr);
            this.groupBox1.Controls.Add(this.lblPlcWrtAddr);
            this.groupBox1.Controls.Add(this.txtPlcRdAddr);
            this.groupBox1.Controls.Add(this.lblPlcRdAddr);
            this.groupBox1.Controls.Add(this.txtWriteNoPlc);
            this.groupBox1.Controls.Add(this.lblPlcWrtNo);
            this.groupBox1.Controls.Add(this.txtReadNoPlc);
            this.groupBox1.Controls.Add(this.lblPlcRdNo);
            this.groupBox1.Controls.Add(this.btnOpenPort);
            this.groupBox1.Controls.Add(this.chkKeepAlive);
            this.groupBox1.Controls.Add(this.chkAliveStatus);
            this.groupBox1.Controls.Add(this.txtIpAddrPlc);
            this.groupBox1.Controls.Add(this.txtPortNo);
            this.groupBox1.Controls.Add(this.lblPortNo);
            this.groupBox1.Controls.Add(this.lblPlcIP);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPlcWrtAddr
            // 
            resources.ApplyResources(this.txtPlcWrtAddr, "txtPlcWrtAddr");
            this.txtPlcWrtAddr.Name = "txtPlcWrtAddr";
            // 
            // lblPlcWrtAddr
            // 
            resources.ApplyResources(this.lblPlcWrtAddr, "lblPlcWrtAddr");
            this.lblPlcWrtAddr.Name = "lblPlcWrtAddr";
            // 
            // txtPlcRdAddr
            // 
            resources.ApplyResources(this.txtPlcRdAddr, "txtPlcRdAddr");
            this.txtPlcRdAddr.Name = "txtPlcRdAddr";
            // 
            // lblPlcRdAddr
            // 
            resources.ApplyResources(this.lblPlcRdAddr, "lblPlcRdAddr");
            this.lblPlcRdAddr.Name = "lblPlcRdAddr";
            // 
            // txtWriteNoPlc
            // 
            resources.ApplyResources(this.txtWriteNoPlc, "txtWriteNoPlc");
            this.txtWriteNoPlc.Name = "txtWriteNoPlc";
            // 
            // lblPlcWrtNo
            // 
            resources.ApplyResources(this.lblPlcWrtNo, "lblPlcWrtNo");
            this.lblPlcWrtNo.Name = "lblPlcWrtNo";
            // 
            // txtReadNoPlc
            // 
            resources.ApplyResources(this.txtReadNoPlc, "txtReadNoPlc");
            this.txtReadNoPlc.Name = "txtReadNoPlc";
            // 
            // lblPlcRdNo
            // 
            resources.ApplyResources(this.lblPlcRdNo, "lblPlcRdNo");
            this.lblPlcRdNo.Name = "lblPlcRdNo";
            // 
            // btnOpenPort
            // 
            resources.ApplyResources(this.btnOpenPort, "btnOpenPort");
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.UseVisualStyleBackColor = true;
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
            // 
            // chkKeepAlive
            // 
            resources.ApplyResources(this.chkKeepAlive, "chkKeepAlive");
            this.chkKeepAlive.Name = "chkKeepAlive";
            this.chkKeepAlive.UseVisualStyleBackColor = true;
            this.chkKeepAlive.CheckedChanged += new System.EventHandler(this.chkKeepAlive_CheckedChanged);
            // 
            // chkAliveStatus
            // 
            resources.ApplyResources(this.chkAliveStatus, "chkAliveStatus");
            this.chkAliveStatus.Name = "chkAliveStatus";
            this.chkAliveStatus.UseVisualStyleBackColor = true;
            // 
            // txtIpAddrPlc
            // 
            resources.ApplyResources(this.txtIpAddrPlc, "txtIpAddrPlc");
            this.txtIpAddrPlc.Name = "txtIpAddrPlc";
            // 
            // txtPortNo
            // 
            resources.ApplyResources(this.txtPortNo, "txtPortNo");
            this.txtPortNo.Name = "txtPortNo";
            // 
            // lblPortNo
            // 
            resources.ApplyResources(this.lblPortNo, "lblPortNo");
            this.lblPortNo.Name = "lblPortNo";
            // 
            // lblPlcIP
            // 
            resources.ApplyResources(this.lblPlcIP, "lblPlcIP");
            this.lblPlcIP.Name = "lblPlcIP";
            // 
            // lstLog
            // 
            resources.ApplyResources(this.lstLog, "lstLog");
            this.lstLog.FormattingEnabled = true;
            this.lstLog.Name = "lstLog";
            this.lstLog.DoubleClick += new System.EventHandler(this.lstLog_DoubleClick);
            // 
            // tmKeepAlive
            // 
            this.tmKeepAlive.Interval = 1000;
            this.tmKeepAlive.Tick += new System.EventHandler(this.tmKeepAlive_Tick);
            // 
            // tmUpdateCtrl
            // 
            this.tmUpdateCtrl.Tick += new System.EventHandler(this.tmUpdateCtrl_Tick);
            // 
            // tmLibTest
            // 
            this.tmLibTest.Enabled = true;
            this.tmLibTest.Interval = 1000;
            this.tmLibTest.Tick += new System.EventHandler(this.tmLibTest_Tick);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.panelDesktop, "panelDesktop");
            this.panelDesktop.Name = "panelDesktop";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTitleBar.Controls.Add(this.lblMain);
            resources.ApplyResources(this.panelTitleBar, "panelTitleBar");
            this.panelTitleBar.Name = "panelTitleBar";
            // 
            // lblMain
            // 
            resources.ApplyResources(this.lblMain, "lblMain");
            this.lblMain.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMain.Name = "lblMain";
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Controls.Add(this.btnManual);
            this.panelMenu.Controls.Add(this.btnMain);
            this.panelMenu.Controls.Add(this.btnIO);
            resources.ApplyResources(this.panelMenu, "panelMenu");
            this.panelMenu.Name = "panelMenu";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btnHome, "btnHome");
            this.btnHome.Name = "btnHome";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnManual
            // 
            this.btnManual.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btnManual, "btnManual");
            this.btnManual.Name = "btnManual";
            this.btnManual.UseVisualStyleBackColor = true;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btnMain, "btnMain");
            this.btnMain.Name = "btnMain";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnIO
            // 
            this.btnIO.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btnIO, "btnIO");
            this.btnIO.Name = "btnIO";
            this.btnIO.UseVisualStyleBackColor = true;
            this.btnIO.Click += new System.EventHandler(this.btnIO_Click);
            // 
            // bntPlcComm
            // 
            resources.ApplyResources(this.bntPlcComm, "bntPlcComm");
            this.bntPlcComm.Image = global::XGCommLibDemo.Properties.Resources.ledGreen_29x29;
            this.bntPlcComm.Name = "bntPlcComm";
            this.bntPlcComm.UseVisualStyleBackColor = true;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "ledGreen_29x29.jpg");
            this.imageList2.Images.SetKeyName(1, "ledRed_29x29.jpg");
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPortNo;
        private System.Windows.Forms.Label lblPortNo;
        private System.Windows.Forms.Label lblPlcIP;
        private System.Windows.Forms.TextBox txtIpAddrPlc;
        private System.Windows.Forms.Button btnOpenPort;
        private System.Windows.Forms.CheckBox chkKeepAlive;
        private System.Windows.Forms.CheckBox chkAliveStatus;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.Timer tmKeepAlive;
        private System.Windows.Forms.Timer tmUpdateCtrl;
        private System.Windows.Forms.Timer tmLibTest;
        private System.Windows.Forms.TextBox txtWriteNoPlc;
        private System.Windows.Forms.Label lblPlcWrtNo;
        private System.Windows.Forms.TextBox txtReadNoPlc;
        private System.Windows.Forms.Label lblPlcRdNo;
        private System.Windows.Forms.TextBox txtPlcWrtAddr;
        private System.Windows.Forms.Label lblPlcWrtAddr;
        private System.Windows.Forms.TextBox txtPlcRdAddr;
        private System.Windows.Forms.Label lblPlcRdAddr;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblMain;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnIO;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button bntPlcComm;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Label label1;
    }
}

