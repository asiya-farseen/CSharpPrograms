using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecom
{
    public partial class ECom : Form
    {
        public ECom()
        {
            InitializeComponent();
        }

        private void result_Click(object sender, EventArgs e)
        {
            double netamt, dis;
            double amt = Convert.ToDouble(pa.Text);
            if (amt <= 10000)
            {
                //dis = (amt * 10) / 100;
                dis = 10;
            }
            else if (amt > 10000 && amt <= 20000)
            {
                //dis =( amt * 20) / 100;
                dis = 20;

            }
            else if (amt > 20000 && amt <= 30000)
            {
                //is = (amt * 30 )/ 100;
                dis = 30;

            }
            else 
            {
                //dis =( amt * 35) / 100;
                dis = 35;
            }
            
            netamt = amt - ((amt*dis)/100);
            string c = "";
            if (yes.Checked)
            {
                netamt = netamt-((netamt * 5) / 100);
            }
           else
            {
                netamt = netamt;
            }
            

            result1.Text = "PURCHASE AMOUNT : " + amt + "\n DISCOUNT : " + dis + "\n NET AMOUNT TO BE PAID : " + netamt;
        }
    }
}


