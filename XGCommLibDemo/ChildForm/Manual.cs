using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XGCommLibDemo.ChildForm
{
    public partial class Manual : Form
    {
        public Manual()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0; int j = 1;
            PF.CalcOutData(0, 1);
        }



        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0; int j = 1;
            PF.CalcOutData(0, 0);
        }
    }
}
