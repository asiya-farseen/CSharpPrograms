using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SubmitForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void result_Click(object sender, EventArgs e)
        {
            String nam = name.Text;
            String ema = email.Text;
            long mob = Convert.ToInt64(phone.Text);
           String d = dob.Text;
           

            String l = location.Text;
            result.Text = "NAM : " + nam + "\nEMAIL : " + ema + "\nMOBILE :" +mob + "\nDOB : " + dob + "\nLOCATION : " + l;
        }
    }
}
