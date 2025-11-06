using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win1
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
        private double summ(double a, double b)
        {
            return a + b;
        }
        private void Summbtn_Click(object sender, EventArgs e)
        {
            num3txt.Text = Convert.ToString(summ(Convert.ToDouble(num1txt.Text), Convert.ToDouble(num2txt.Text)));
        }
        private double sub(double a, double b)
        {
            return a - b;
        }

        private void Subbtn_Click(object sender, EventArgs e)
        {
            num3txt.Text = Convert.ToString(sub(Convert.ToDouble(num1txt.Text), Convert.ToDouble(num2txt.Text)));
        }
        private double mult(double a, double b)
        {
            return a * b;
        }

        private void Multibtn_Click(object sender, EventArgs e)
        {
            num3txt.Text = Convert.ToString(mult(Convert.ToDouble(num1txt.Text), Convert.ToDouble(num2txt.Text)));
        }
        private double div(double a, double b)
        {
            return a / b;
        }
        private void Divbtn_Click(object sender, EventArgs e)
        {
            num3txt.Text = Convert.ToString(div(Convert.ToDouble(num1txt.Text), Convert.ToDouble(num2txt.Text)));
        }
    }
}
