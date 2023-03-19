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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal i = numericUpDown1.Value;
            try
            {
                double a = Convert.ToDouble(maskedTextBox1.Text);
                double b = Convert.ToDouble(maskedTextBox2.Text);
                double c = 0;
                double x = Convert.ToDouble(maskedTextBox3.Text);
                if (i == 0)
                {
                    MessageBox.Show("1");
                }
                else
                {
                    c = a / Math.Abs(a - Math.Abs(b - x));
                    MessageBox.Show(c.ToString());
                }
            }
            catch
            {
                MessageBox.Show("Norm");
            }
            }

        private void Nazad_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }
    }
}
