using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
namespace calcu
{
    public partial class Form1 : Form
    {
        private ArrayList historyboi;

        public Form1()
        {
            InitializeComponent();
            historyboi = new ArrayList();
            HISTORY.Visible = false;
        }
        string Calcutotal;
        string option;
        double result;
        double num1;
        double num2;
        private void button1_Click(object sender, EventArgs e)
        {
            total.Text = total.Text + "1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            total.Text = total.Text + "2";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            total.Text = total.Text + "3";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            total.Text = total.Text + "4";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            total.Text = total.Text + "5";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            total.Text = total.Text + "6";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            total.Text = total.Text + "7";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            total.Text = total.Text + "8";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            total.Text = total.Text + "9";
        }
        private void button10_Click(object sender, EventArgs e)
        {
            total.Text = total.Text + "0";
        }
        private void add_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = double.Parse(total.Text);
            total.Clear();
        }
        private void sub_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = double.Parse(total.Text);
            total.Clear();
        }
        private void mul_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = double.Parse(total.Text);
            total.Clear();
        }
        private void div_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = double.Parse(total.Text);
            total.Clear();
        }
        private void equal_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(total.Text);
            if (option == "+")
            {
                result = num1 + num2;
            }
            else if (option == "-")
            {
                result = num1 - num2;
            }
            else if (option == "*")
            {
                result = num1 * num2;
            }
            else if (option == "/")
            {
                result = num1 / num2;
            }
            total.Text = result + "";

            string currentCalculation = $"{num1} {option} {num2} = {result}";
            historyboi.Add(currentCalculation);
            HISTORY.Items.Add(currentCalculation);
        }
        private void clr_Click(object sender, EventArgs e)
        {
            result = (0);
            num1 = (0);
            num2 = (0);
            total.Clear();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            HISTORY.Items.Clear();
            historyboi.Clear();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HISTORY.SelectedIndex != -1)
            {
                string selectedCalculation = HISTORY.SelectedItem.ToString();

                int equalsIndex = selectedCalculation.LastIndexOf('=');
                if (equalsIndex != -1 && equalsIndex < selectedCalculation.Length - 1)
                {
                    string resultValue = selectedCalculation.Substring(equalsIndex + 1).Trim();
                    total.Text = resultValue;
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (HISTORY.Visible)
            {
                HISTORY.Visible = false;
            }
            else
            {
                HISTORY.Items.Clear();
                foreach (string calculation in historyboi)
                {
                    HISTORY.Items.Add(calculation);
                }
                HISTORY.Visible = true;
            }
        }
    }
}