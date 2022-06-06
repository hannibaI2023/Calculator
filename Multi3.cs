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
    public partial class Multi3 : Form
    {
        public Multi3()
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
            double A1 = double.Parse(x1.Text);
            double B1 = double.Parse(y1.Text);
            double C1 = double.Parse(z1.Text);
            double D1 = double.Parse(d1.Text);
            double A2 = double.Parse(x2.Text);
            double B2 = double.Parse(y2.Text);
            double C2 = double.Parse(z2.Text);
            double D2 = double.Parse(d2.Text);
            double A3 = double.Parse(x3.Text);
            double B3 = double.Parse(y3.Text);
            double C3 = double.Parse(z3.Text);
            double D3 = double.Parse(d3.Text);
            D1 = D1 * -1; D2 = D2 * -1; D3 = D3 * -1;
            double D = A1*B2*C3 + B1*C2*A3 + C1*A2*B3 - A3*B2*C1 - B3*C2*A1 - C3*A2*B1;
            double Dx = D1*B2*C3 + B1*C2*D3 + C1*D2*B3 - D3*B2*C1 - B3*C2*D1 - C3*D2*B1;
            double Dy = A1*D2*C3 + D1*C2*A3 + C1*A2*D3 - A3*D2*C1 - D3*C2*A1 - C3*A2*D1;
            double Dz = A1*B2*D3 + B1*D2*A3 + D1*A2*B3 - A3*B2*D1 - B3*D2*A1 - D3*A2*B1;
            if (D == 0)
            {
                if (Dx == 0 && Dy == 0 && Dz == 0)
                {
                    MessageBox.Show("INFINITE SOLUTIONS", "UNEXPECTED RESULT!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("NO SOLUTION", "UNEXPECTED RESULT!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    return;
                }

            }
            double X = Dx / D;
            double Y = Dy / D;
            double Z = Dz / D;
            xres.Text = X.ToString();
            yres.Text = Y.ToString();
            zres.Text = Z.ToString();
        }

        private void button_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkinput(sender, e);
        }
    }
}
