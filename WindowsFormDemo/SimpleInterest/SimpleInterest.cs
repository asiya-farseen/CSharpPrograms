using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleInterest
{
    public partial class SimpleInterest : Form
    {
        public SimpleInterest()
        {
            InitializeComponent();
        }

        private void SimpleInterest_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void result_Click(object sender, EventArgs e)
        {

            int p = Convert.ToInt32(principal.Text);
            double r = Convert.ToDouble(roi.Text);
            int t = Convert.ToInt32(time.Text);
            double si = (p * r * t) / 100;
            res.Text = Convert.ToString(si);

        }
    }
}
