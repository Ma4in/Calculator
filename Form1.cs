using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool dotIsPress = false;

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dotIsPress == false)
            {
                if (Char.IsNumber(e.KeyChar) | (e.KeyChar == '.'))
                {
                    if (e.KeyChar == '.')
                    {
                        dotIsPress = true;
                    }
                    return;
                }
                else e.Handled = true;
            }
            if (dotIsPress == true)
            {
                if (Char.IsNumber(e.KeyChar)) return;
                else e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public double memory = 0.0; 

        public double memoryTemp = 0.0;

        public string operathion = "";

        public bool isNegative = false;
        
        private void buttonEq_Click(object sender, EventArgs e)
        {
            try
            {
                switch (operathion)
                {
                    case "":

                        break;
                    case "plus":
                        memoryTemp = memoryTemp + double.Parse(textBox.Text.Replace(".", ","));
                        textBox.Text = memoryTemp.ToString();
                        break;
                    case "minus":
                        memoryTemp = memoryTemp - double.Parse(textBox.Text.Replace(".", ","));
                        textBox.Text = memoryTemp.ToString();
                        break;
                    case "multiply":
                        memoryTemp = memoryTemp * double.Parse(textBox.Text.Replace(".", ","));
                        textBox.Text = memoryTemp.ToString();
                        break;
                    case "div":
                        memoryTemp = memoryTemp / double.Parse(textBox.Text.Replace(".", ","));
                        textBox.Text = memoryTemp.ToString();
                        break;
                }
            }
            catch { MessageBox.Show("Invalid, incorrect input!"); }
            dotIsPress = false;
        }

        private void buttonMemorySave_click(object sender, EventArgs e)
        {
            memory = double.Parse(textBox.Text.Replace(".", ","));
        }

        private void buttonMemoryRead_click(object sender, EventArgs e)
        {
            textBox.Text = memory.ToString();
        }

        private void buttonMemoryClear_click(object sender, EventArgs e)
        {
            memory = 0.0;
        }

        private void buttonMemoryPlus_click(object sender, EventArgs e)
        {
            memory += double.Parse(textBox.Text.Replace(".", ","));
        }

        private void buttonMemoryMinus_click(object sender, EventArgs e)
        {
            memory -= double.Parse(textBox.Text.Replace(".", ","));
        }

        private void buttonClearAll_click(object sender, EventArgs e)
        {
            textBox.Text = "";
            memoryTemp = 0.0;
            memory = 0.0;
            operathion = "";
        }

        private void buttonClear_click(object sender, EventArgs e)
        {
            textBox.Text = "";
            operathion = "";
            memoryTemp = 0.0;
        }

        private void buttonBack_click(object sender, EventArgs e)
        {
            if (textBox.Text.Length > 0)
            {
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
            }
        }

        private void buttonPercent_Click(object sender, EventArgs e)
        {
            if (double.Parse(textBox.Text.Replace(".", ",")) < 100.0)
            {
                memoryTemp = double.Parse(textBox.Text.Replace(".", ","));
                textBox.Text = (memoryTemp / 100).ToString();
                operathion = "";
            }
        }

        private void buttonDrob_Click(object sender, EventArgs e)
        {
            memoryTemp = double.Parse(textBox.Text.Replace(".", ","));
            textBox.Text = (1 / memoryTemp).ToString();
            operathion = "";
        }

        private void buttonSqr_Click(object sender, EventArgs e)
        {
            memoryTemp = double.Parse(textBox.Text.Replace(".", ","));
            textBox.Text = (memoryTemp * memoryTemp).ToString();
            operathion = "";
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            memoryTemp = double.Parse(textBox.Text.Replace(".", ","));
            textBox.Text = Math.Sqrt(memoryTemp).ToString();
            operathion = "";
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            memoryTemp = double.Parse(textBox.Text.Replace(".", ","));
            textBox.Text = "";
            operathion = "div";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            memoryTemp = double.Parse(textBox.Text.Replace(".", ","));
            textBox.Text = "";
            operathion = "multiply";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            memoryTemp = double.Parse(textBox.Text.Replace(".", ","));
            textBox.Text = "";
            operathion = "minus";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {

            memoryTemp = double.Parse(textBox.Text.Replace(".",","));
            textBox.Text = "";
            operathion = "plus";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox.Text += "1";
        }

        private void buttonPM_Click(object sender, EventArgs e)
        {
            if (!isNegative)
            {
                textBox.Text = "-" + textBox.Text;
                isNegative = true;
            } else
            {
                textBox.Text = textBox.Text[1..];
                isNegative = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox.Text += "0";
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (dotIsPress == false)
            {
                textBox.Text += ".";
                dotIsPress = true;
            }
            else return;
        }
    }
}