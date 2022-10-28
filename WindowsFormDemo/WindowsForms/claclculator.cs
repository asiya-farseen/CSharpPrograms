using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class claclculator : Form
    {
        public claclculator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int res = 0;
            int n1 = Convert.ToInt32(num1.Text);
            String opr1 = opr.Text;
            int n2 = Convert.ToInt32(num2.Text);
            if(opr1=="+")
            {
                res = n1 + n2;
            }
            else if (opr1 == "-")
            {
                res = n1 - n2;
            }
           else if (opr1 == "*")
            {
                res = n1 * n2;
            }
           else if (opr1 == "/")
            {
                res = n1 / n2;
            }
            else
            {
                res = -1;
            }
            result.Text = res.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
