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
using System.Runtime.InteropServices;


namespace XGCommLibDemo.ChildForm
{
    public partial class FormHome : Form
    {
        Form1 form1;
        public FormHome()
        {
            InitializeComponent();

        }
        //public string strPlcManualBtNo
        //{
        //    get { return txtPlcManualBtNo.Text; }
        //    set { txtPlcManualBtNo.Text=value; }
        //}
        //public string strPlcIONo
        //{
        //    get { return txtPlcIONo.Text; }
        //    set { txtPlcIONo.Text = value; }
        //}
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            txtPlcIONo.Text = PV.PlcIONo;
            txtPlcManualBtNo.Text = PV.PlcManualBtNo;
        }

    }
}
