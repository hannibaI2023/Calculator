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
    public partial class Main : Form
    {
          
        public Choosemaho Choose;
        //
        Double ValueA = 0;
        Double ValueB = 0;
        //
        String operationPerformed = "";
        bool isoperationPerformed = false;
        //

        Double Giaithua(Double A)
        {
            Double KQ = 1;
            for (int i = 2; i <= A; ++i)
                KQ *= i;
            return KQ;
        }

        public Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (((textBox1.Text == "0") || (isoperationPerformed)) && (button.Text != "."))
                textBox1.Clear();
            if (labelCurrentOperation.Text.Contains("=") || 
                labelCurrentOperation.Text.Contains("!") || 
                labelCurrentOperation.Text.Contains("SQRT") ||
                labelCurrentOperation.Text.Contains("%"))
            {
                labelCurrentOperation.Text = "";
                textBox1.Clear();
            }    
            isoperationPerformed = false;
            if (button.Text==".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + button.Text;
            }
            else    
                textBox1.Text = textBox1.Text + button.Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("An error occured. Please try again", "SYNTAX ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Button button = (Button)sender;
                operationPerformed = button.Text;
                ValueA = Double.Parse(textBox1.Text);
                switch (operationPerformed)
                {
                    case "√":
                        labelCurrentOperation.Text = "SQRT(" + ValueA + ")";
                        ValueA = Math.Sqrt(ValueA);
                        textBox1.Text = ValueA.ToString();
                        operationPerformed = "";
                        break;

                    case "!":
                        labelCurrentOperation.Text = ValueA + "!";
                        if (ValueA <= 20)
                        {
                            ValueA = Giaithua(ValueA);
                            textBox1.Text = ValueA.ToString();
                            operationPerformed = "";
                        }
                        else
                        {
                            MessageBox.Show("Please enter a smaller number.", "MATH ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBox1.Text = "";
                            labelCurrentOperation.Text = "";
                            operationPerformed = "";
                        }
                        break;

                    case "%":
                        labelCurrentOperation.Text = ValueA + "%";
                        ValueA = ValueA / 100;
                        textBox1.Text = ValueA.ToString();
                        operationPerformed = "";
                        break;

                    default:
                        labelCurrentOperation.Text = ValueA + " " + operationPerformed;
                        isoperationPerformed = true;
                        break;
                }
            }
        }

        private void CC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            labelCurrentOperation.Text = "";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            if (labelCurrentOperation.Text.Contains("="))
            {
                MessageBox.Show("An error occured. Please try again", "SYNTAX ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelCurrentOperation.Text = "";
                textBox1.Text = "";
            }
            else
            {
                try
                {
                    ValueB = Double.Parse(textBox1.Text);
                    switch (operationPerformed)
                    {

                        case "+":
                            labelCurrentOperation.Text += " " + textBox1.Text + " =";
                            textBox1.Text = (ValueA + ValueB).ToString();
                            break;

                        case "-":
                            labelCurrentOperation.Text += " " + textBox1.Text + " =";
                            textBox1.Text = (ValueA - ValueB).ToString();
                            break;

                        case "*":
                            labelCurrentOperation.Text += " " + textBox1.Text + " =";
                            textBox1.Text = (ValueA * ValueB).ToString();
                            break;

                        case "/":
                            if (ValueB == 0)
                            {
                                MessageBox.Show("Division by 0.", "MATH ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                labelCurrentOperation.Text = "";
                                textBox1.Text = "";
                            }
                            else
                            {
                                labelCurrentOperation.Text += " " + textBox1.Text + "=";
                                textBox1.Text = (ValueA / ValueB).ToString();
                            }
                            break;

                        case "DIV":
                            if (ValueB == 0)
                            {
                                MessageBox.Show("Division by 0.", "MATH ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                labelCurrentOperation.Text = "";
                                textBox1.Text = "";
                            }
                            else
                            {
                                labelCurrentOperation.Text += " " + textBox1.Text + "=";
                                textBox1.Text = ((Int64)(ValueA / ValueB)).ToString();
                            }
                            break;

                        case "MOD":
                            if (ValueB == 0)
                            {
                                MessageBox.Show("Division by 0.", "MATH ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                labelCurrentOperation.Text = "";
                                textBox1.Text = "";
                            }
                            else
                            {
                                labelCurrentOperation.Text += " " + textBox1.Text + "=";
                                textBox1.Text = (ValueA % ValueB).ToString();
                            }
                            break;

                        case "^":
                            try
                            {
                                ValueB = (Int64)ValueB;
                                Double KQ = 1;
                                for (int i = 1; i <= ValueB; ++i)
                                    KQ *= ValueA;
                                //
                                labelCurrentOperation.Text += " " + ValueB.ToString() + "=";
                                textBox1.Text = KQ.ToString();
                            }
                            catch
                            {
                                MessageBox.Show("Please enter a smaller number.", "MATH ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                labelCurrentOperation.Text = "";
                                textBox1.Text = "";
                            }
                            break;

                        default:
                            break;

                    }
                    operationPerformed = "";
                }
                catch
                {
                    MessageBox.Show("An error occured. Please try again","SYNTAX ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    labelCurrentOperation.Text = "";
                    textBox1.Text = "";
                }
            }
        }

        private void C_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Choosemaho Choose = new Choosemaho();
            Choose.Show();
        }
    }
}