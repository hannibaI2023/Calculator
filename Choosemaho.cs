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
    public partial class Choosemaho : Form
    {
        public Choosemaho()
        {
            InitializeComponent();
        }

        public quadra qua;
        public Multi2 mul2;
        public Multi3 mul3;

        private void quadra_Click(object sender, EventArgs e)
        {
            quadra qua = new quadra();
            qua.Show();
            Close();
        }

        private void Multi2_Click(object sender, EventArgs e)
        {
            Multi2 mul2 = new Multi2();
            mul2.Show();
            Close();
        }

        private void Multi3_Click(object sender, EventArgs e)
        {
            Multi3 mul3 = new Multi3();
            mul3.Show();
            Close();
        }
    }
}
