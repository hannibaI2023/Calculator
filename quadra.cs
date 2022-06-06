using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_ver_2
{
    public partial class quadra : Form
    {
        public void checkinput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        public quadra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double A = double.Parse(a.Text);
                double B = double.Parse(b.Text);
                double C = double.Parse(c.Text);
                if (A == 0)
                {
                    if (B == 0)
                    {
                        if (C == 0) { ansqua.Text = "INFINITE SOLUTIONS"; } //INFINITE SOLUTIONS
                        else { ansqua.Text = "NO SOLUTION"; } //NO SOLUTION
                    }
                    else
                    {
                        //1 NGHIEM = -C/B
                        ansqua.Text = "X = " + (C / B).ToString();
                    }
                }
                else
                {
                    double delta = (B * B) - (4 * A * C), x1 = 0, x2 = 0;
                    if (delta >= 0)//1-2 SOLUTION
                    {
                        x1 = (-B + Math.Sqrt(delta)) / (2 * A);
                        x2 = (-B - Math.Sqrt(delta)) / (2 * A);
                        ansqua.Text = "X1 = " + x1.ToString() + "; X2 = " + x2.ToString() + ";";
                    }
                    else { ansqua.Text = "NO SOLUTION"; }//NO SOLUTION
                }
            }
            catch
            {
                MessageBox.Show( "Invalid input.","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void a_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkinput(sender, e);
        }

        private void b_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkinput(sender, e);
        }

        private void c_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkinput(sender, e);
        }
    }
}
