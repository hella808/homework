using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class FormCalc : Form
    {
        public FormCalc()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void num1txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void num2txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void num3txt_TextChanged(object sender, EventArgs e)
        {

        }

        private double summ(double a, double b)
        {
            return a + b;
        }
        private double subtraction(double a, double b)
        {
            return a - b;
        }
        private double multiplication(double a, double b)
        {
            return a * b;
        }
        private double division(double a, double b)
        {
            return a / b;
        }
        private void summbtn_Click(object sender, EventArgs e)
        {
            if (num1txt.Text == "" || num2txt.Text == "")
            {
                MessageBox.Show("You need to write num1 or num2");
                return;
            }
            num3txt.Text = Convert.ToString(summ(Convert.ToDouble(num1txt.Text), Convert.ToDouble(num2txt.Text)));
        }
        private void subbtn_Click(object sender, EventArgs e)
        {
            if (num1txt.Text == "" || num2txt.Text == "")
            {
                MessageBox.Show("You need to write num1 or num2");
                return;
            }
            num3txt.Text = Convert.ToString(subtraction(Convert.ToDouble(num1txt.Text), Convert.ToDouble(num2txt.Text)));
        }
        private void multbtn_Click(object sender, EventArgs e)
        {
            if (num1txt.Text == "" || num2txt.Text == "")
            {
                MessageBox.Show("You need to write num1 or num2");
                return;
            }
            num3txt.Text = Convert.ToString(multiplication(Convert.ToDouble(num1txt.Text), Convert.ToDouble(num2txt.Text)));
        }
        private void divbtn_Click(object sender, EventArgs e)
        {
            if (num1txt.Text == "" || num2txt.Text == "")
            {
                MessageBox.Show("You need to write num1 or num2");
                return;
            }
            num3txt.Text = Convert.ToString(division(Convert.ToDouble(num1txt.Text), Convert.ToDouble(num2txt.Text)));
        }

    }
}
