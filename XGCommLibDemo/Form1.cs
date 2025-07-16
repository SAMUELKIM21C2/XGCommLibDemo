using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.Policy;
using System.Threading;

namespace XGCommLibDemo
{
    public delegate string WriteStringDelegate(string input);
    
    public partial class Form1 : Form
    {
        private XGCommSocket XGComm = new XGCommSocket();
        delegate bool SetTextCallBack(string strLog);
        private long lCountErrorRead = 0;
        private long lCountErrorWrite = 0;
        private long lCountErrorCheck = 0;
        private long lMaxAccessTimeRead = 0;
        private long lMaxAccessTimeWrite = 0;
        private bool threadRunflag = false;
        private bool Readflag = true;
        private bool Writeflag = false;
        private Thread XgkCommThread;
    
        //Fields
        private Button currentButton;
        private Form activeForm;
        public Color PrimaryColor { get; set; }
        public Color SecondColor { get; set; }

        private ChildForm.FormHome childFormHome;
        private ChildForm.MAIN childMain;
        private ChildForm.IO_View childIO_View;
        private ChildForm.Manual childManual;


        public Form1()
        {
            InitializeComponent();
            InitData();
            //            txtIpAddrPlc.Text = "127.0.0.1";
            //            txtPortNo.Text = "2004";

            tmUpdateCtrl.Enabled = true;
            //AccessTime.HiPerfTimer();


            //            this.panelDesktop.Controls.Add(childForm);
            //           this.panelDesktop.Tag = childForm;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtIpAddrPlc.Text = PV.PLCIP;
            
            txtPortNo.Text = PV.PLCPORT;
            txtPlcRdAddr.Text = PV.PLCReadAddr;
            txtPlcWrtAddr.Text = PV.PLCWriteAddr;
            txtReadNoPlc.Text = PV.PLCWordReadNo;
            txtWriteNoPlc.Text = PV.PLCWordWriteNo;
        
        }
        private void btnOpenPort_Click(object sender, EventArgs e)
        {
            if (XGComm.Connect(txtIpAddrPlc.Text, Convert.ToInt32(txtPortNo.Text)) != (uint)XGCOMM_FUNC_RESULT.RT_XGCOMM_SUCCESS)
            {
                AddLog("==> Connect Fail !! \n");
            }
            else
            {
                AddLog("Connect success... (IP: {0}, PORT: {1})", txtIpAddrPlc.Text, txtPortNo.Text);
                XgkCommThread = new Thread(GetSetPLCData);
                XgkCommThread.IsBackground = true;
                XgkCommThread.Start();
            }
        }

        private bool AddLog(string strLog)
        {
            string strTimeLog;

            DateTime dt = DateTime.Now;

            strTimeLog = dt.ToString("[hh:mm:ss.fff] ") + strLog;
            lstLog.SelectedIndex = lstLog.Items.Count - 1;

            if (lstLog.Items.Count > 100)
            {
                lstLog.Items.RemoveAt(0);
            }

            if (this.lstLog.InvokeRequired)
            {
                SetTextCallBack dele = new SetTextCallBack(AddLog);
                this.Invoke(dele, new object[] { strTimeLog });
            }
            else
            {
                this.lstLog.Items.Add(strTimeLog);
                this.lstLog.SelectedIndex = this.lstLog.Items.Count - 1;
            }

            return true;
        }

        private bool AddLog(string strLog, params object[] values)
        { 
            string strValue;

            strValue = string.Format(strLog, values);
            return AddLog(strValue);
        }

        private void lstLog_DoubleClick(object sender, EventArgs e)
        {
            lstLog.Items.Clear();
        }


        private void btnManual_Click(object sender, EventArgs e)
        {
            OpenChildForm(childManual, sender);
        }
        private void btnIO_Click(object sender, EventArgs e)
        {
            OpenChildForm(childIO_View, sender);
        }
        private void btnMain_Click(object sender, EventArgs e)
        {
            OpenChildForm(childMain, sender);
            
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(childFormHome, sender);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void chkKeepAlive_CheckedChanged(object sender, EventArgs e)
        {
            tmKeepAlive.Enabled = chkKeepAlive.Checked;
        }

        private void tmKeepAlive_Tick(object sender, EventArgs e)
        {
            uint uReturn;

            uReturn = XGComm.UpdateKeepAlive();
            if (uReturn == (uint)XGCOMM_FUNC_RESULT.RT_XGCOMM_SUCCESS)
            {
                chkAliveStatus.Checked = true;
            }
            else
            {
                chkAliveStatus.Checked = false;
            }
        }



   
        private void tmLibTest_Tick(object sender, EventArgs e)
        {
            if (threadRunflag)
            {
                PF.CalcOutData(0, 1);
                threadRunflag = false;
            }
            else
            {
                PF.CalcOutData(0, 0);
                threadRunflag = true;
            }
        }

        private void tmUpdateCtrl_Tick(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PF.Setinivalue("PLC_Data", "PLCIP", txtIpAddrPlc.Text);
            PF.Setinivalue("PLC_Data", "PLCPORT", txtPortNo.Text);
            PF.Setinivalue("PLC_Data", "PLCWriteAddr", txtPlcWrtAddr.Text);
            PF.Setinivalue("PLC_Data", "PLCReadAddr", txtPlcRdAddr.Text);
            PF.Setinivalue("PLC_Data", "PLCWordReadNo", txtReadNoPlc.Text);
            PF.Setinivalue("PLC_Data", "PLCWordWriteNo", txtWriteNoPlc.Text);
            PF.Setinivalue("PLC_Data", "PlcManualBtNo", childFormHome.txtPlcManualBtNo.Text);
            PF.Setinivalue("PLC_Data", "PlcIONo", childFormHome.txtPlcIONo.Text);
        }


        #region 버튼클릭이벤트

        public Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            //If correction factor is less than 0, darken color.
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }

            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }

        private void DisableButton()
        {
            foreach (Control btn in panelMenu.Controls)
            {
                if (btn.GetType() == typeof(Button))
                {
                    btn.BackColor = Color.FromArgb(51, 51, 76);
                    btn.ForeColor = Color.Gainsboro;
                    btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    Color color;
                    if (currentButton == btnHome) color = Color.FromArgb(0, 150, 136);
                    else if (currentButton == btnManual) color = Color.FromArgb(89, 120, 187);
                    else if (currentButton == btnIO) color = Color.FromArgb(199, 220, 91);
                    else if (currentButton == btnMain) color = Color.FromArgb(228, 18, 107);
                    else color = Color.FromArgb(0, 150, 136);

                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    if (currentButton != btnMain)
                        currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    btnMain.BackColor = ChangeColorBrightness(color, -0.3);
                    PrimaryColor = color;
                    SecondColor = ChangeColorBrightness(color, -0.3);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
 //           if (activeForm != null)
  //              activeForm.Close();

            ActiveButton(btnSender);
            activeForm = childForm;
            activeForm.TopLevel = false;
            activeForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblMain.Text = childForm.Text;
        }

        #endregion





        private void GetSetPLCData()
        {
            uint uReturn;
            long lOffset_r = long.Parse(PV.PLCReadAddr);
            long lSize_r = long.Parse(PV.PLCWordReadNo);
            
            long lOffset_w = long.Parse(PV.PLCWriteAddr);
            long lSize_w = long.Parse(PV.PLCWordWriteNo);
            
            long lCount;
            UInt16[] bWrite = new UInt16[lSize_w];
            UInt16[] bRead = new UInt16[lSize_r];
            //Stopwatch stopwatch = new Stopwatch();
            while (true)
            {
                uReturn = XGComm.ReadDataWord('M', lOffset_r, lSize_r, false, bRead);
                if (uReturn == (uint)XGCOMM_FUNC_RESULT.RT_XGCOMM_SUCCESS) //데이터 리딩 정상
                {
                    for (lCount = 0; lCount < lSize_r; lCount++)
                    {
                       PV.byRead[lCount] = bRead[lCount];
                    }
                }
                else //리딩 불량
                {
                    AddLog(XGComm.GetReturnCodeString(uReturn));
                }

                for (lCount = 0; lCount < lSize_w; lCount++)
                {
                     bWrite[lCount]=PV.byWrite[lCount];
                }
                uReturn = XGComm.WriteDataWord('M', lOffset_w, lSize_w, false, bWrite);
                if (uReturn == (uint)XGCOMM_FUNC_RESULT.RT_XGCOMM_SUCCESS) //데이터 리딩 정상
                {
                   
                }
                else //리딩 불량
                {
                    AddLog(XGComm.GetReturnCodeString(uReturn));
                }
                check_io();
                PlcGetInFromBuff();

            }
        }



        private void PlcGetInFromBuff()
        {
            int chkWord;
            int tempPlcInWord;
            for (int i = 0; i < int.Parse(PV.PLCWordReadNo); i++)  //20 --> PV.ReadNo.
            {
                tempPlcInWord = PV.byRead[i];
                chkWord = 1;
                for (int j = 0; j < 16; j++)
                {
                    if ((tempPlcInWord & chkWord) != 0)
                    {
                        PV.d_in[i * 16 + j] = true;
                    }
                    else
                    {
                        PV.d_in[i * 16 + j] = false;
                    }
                    chkWord <<= 1;
                }
            }
            for (int i = 0; i < int.Parse(PV.PLCWordWriteNo); i++)  //20 --> PV.WriteNo.
            {
                tempPlcInWord = PV.byWrite[i];
                chkWord = 1;
                for (int j = 0; j < 16; j++)
                {
                    if ((tempPlcInWord & chkWord) != 0)
                    {
                        PV.d_out[i * 16 + j] = true;
                    }
                    else
                    {
                        PV.d_out[i * 16 + j] = false;
                    }
                    chkWord <<= 1;
                }
            }
        }

        private void check_io()
        {
            if (PV.d_in[0] != PV.def_in[0]) //
            {
                if (PV.d_in[0])
                {
                    //childIO_View.btnLamp01.Image = childIO_View.imageList1.Images[1];
                }
                else
                {
                    //childIO_View.btnLamp01.Image = childIO_View.imageList1.Images[0];
                }
            }
            if (PV.d_in[1] != PV.def_in[1]) // %MX161
            {
                if (PV.d_in[1]) //ON일때
                {
                    bntPlcComm.Image = imageList2.Images[1];
                }
                else //OFF일때
                {
                    bntPlcComm.Image = imageList2.Images[0];
                }
            }


            for (int i = 0; i < 320; i++)
            {
                if (PV.d_in[i] != PV.def_in[i])
                    PV.def_in[i] = PV.d_in[i];


                if (PV.d_out[i] != PV.def_out[i])
                    PV.def_out[i] = PV.d_out[i];
            }
        }

    }
}
