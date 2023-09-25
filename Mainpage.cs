using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class Mainpage : Form
    {
        public Mainpage()
        {
            InitializeComponent();
        }

        private void staffsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void hELPToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void wordpadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Wordpad.exe");
        }

        private void Mainpage_Load(object sender, EventArgs e)
        {
            tssltime.Text = DateTime.Now.ToString();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Admission frm = new Admission();
            frm.Show();
        }
    }
}
