using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class zd3 : Form
    {
        public zd3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(maskedTextBox1.Text);
            double b = Convert.ToDouble(maskedTextBox2.Text);
            double c = Convert.ToDouble(maskedTextBox3.Text);

            double d = a + b + c;
            double g = a * b * c;
            if(d < g)
            {
                MessageBox.Show("1");

            }
         if (d > g)
            {
                MessageBox.Show("0");
            }



        }
    }
}
