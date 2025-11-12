using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm;

namespace Win1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void MenuStrip1(object sender, EventArgs e)
        {
            /*frmtest _frmtest = new frmtest();
            _frmtest.MdiParent = this;
            _frmtest.Show();*/
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPaint _formpaint = new FormPaint();
            _formpaint.MdiParent = this;
            _formpaint.Show();
        }
        private void calcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCalc _frmtest = new FormCalc();
            _frmtest.MdiParent = this;
            _frmtest.Show();
        }
    }
}