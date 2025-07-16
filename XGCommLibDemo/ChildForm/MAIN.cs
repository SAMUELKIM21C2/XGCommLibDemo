using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace XGCommLibDemo.ChildForm
{
    public partial class MAIN : Form
    {
        public MAIN()
        {
            InitializeComponent();
        }

        private void txtPlcDelayData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back))
            { 
                e.Handled = true;
            }
        }

        private void txtPlcDelayData_TextChanged(object sender, EventArgs e)
        {
            int bPos = 1;
            int data = int.Parse(txtPlcDelayData.Text);
            for (int i = 0; i < 32; i++)
            {
                if ((data & bPos)!=0)
                    PF.CalcOutData(2  * 16 + i, 1); // mw32~mw33  
                else
                    PF.CalcOutData(2 * 16 + i, 0);
                bPos <<= 1;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back))
            {
                e.Handled = true; 
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int bPos = 1;
            int data = int.Parse(textBox1.Text);
            for (int i = 0; i < 16; i++)
            {
                if ((data & bPos) != 0)
                    PF.CalcOutData(4 * 16 + i, 1); //mw34
                else
                    PF.CalcOutData(4 * 16 + i, 0); 
                bPos <<= 1; 
            }


        }
    }
}
