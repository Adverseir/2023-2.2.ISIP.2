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
    public partial class zd21 : Form
    {
        public zd21()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            for (int j = 0; j < textBox1.TextLength; j++)
            {
                if (textBox1.Text[i] == '+')
                {
                    i++;
                }
                else if (textBox1.Text[i] == '-')
                {
                    i++;
                }
                else if (textBox1.Text[i] == '*')
                {
                    i++;
                }

            }
          
            MessageBox.Show($"КОЛ-ВО ЭТИХ ЗНАКОВ {i}");
        }
    }
}
