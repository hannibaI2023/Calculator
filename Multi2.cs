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
    public partial class Multi2 : Form
    {
        private double xmul2;
        private double ymul2;
        public Multi2()
        {
            InitializeComponent();
        }

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

        private void domaho_Click(object sender, EventArgs e)
        {
            try
            {//input set 1
                double a1 = double.Parse(ta1.Text);
                double b1 = double.Parse(tb1.Text);
                double c1 = double.Parse(tc1.Text);
                //set2
                double a2 = double.Parse(ta2.Text);
                double b2 = double.Parse(tb2.Text);
                double c2 = double.Parse(tc2.Text);
                //calculations
                double D = a1 * b2 - a2 * b1;
                double Dx = c1 * b2 - c2 * b1;
                double Dy = a1 * c2 - a2 * c1;
                if (D != 0)
                {
                    //YES SOLUTION
                    xmul2 = (Dx / D);
                    ymul2 = (Dy / D);
                    ansmul2.Text = "{ X = " + xmul2.ToString() + ", Y = " + ymul2.ToString() + " }";
                }
                else
                {
                    if ((Dx != 0) || (Dy != 0))
                    {
                        //NO SOLUTION
                        ansmul2.Text = "NO SOLUTION";
                    }
                    else
                    {
                        //INFINITE SOLUTION
                        ansmul2.Text = "INFINITE SOLUTIONS";
                    }
                }
            }
            catch
            {
                MessageBox.Show( "Invalid input.","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ta1_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkinput(sender, e);
        }

        private void tb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkinput(sender, e);
        }

        private void tc1_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkinput(sender, e);
        }

        private void ta2_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkinput(sender, e);
        }

        private void tb2_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkinput(sender, e);
        }

        private void tc2_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkinput(sender, e);
        }
    }
}
