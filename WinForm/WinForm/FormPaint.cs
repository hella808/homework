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
    public partial class FormPaint : Form
    {
        public FormPaint()
        {
            InitializeComponent();
        }
        public bool Mouse = false;
        Pen pen = new Pen(Color.Black, 2);
        Point _startPoint = new Point();
        Point _endPoint = new Point();


        private void Draw(object sender, MouseEventArgs e)
        {

        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse = true;
            xclicklbl.Text = e.X.ToString();
            yclicklbl.Text = e.Y.ToString();
            _startPoint = new Point(e.X, e.Y);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Mouse = false;
            xuplbl.Text = e.X.ToString();
            yuplbl.Text = e.Y.ToString();
            _endPoint = new Point(e.X, e.Y);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            xlbl.Text = e.X.ToString();
            ylbl.Text = e.Y.ToString();

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.DrawLine(pen, _startPoint, _endPoint);
        }

        private void whitebtn_Click_1(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            pen.Color = btn.BackColor;
        }

    }
}
