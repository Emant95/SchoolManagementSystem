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
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void ForgetPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnsendmail_Click(object sender, EventArgs e)
        {
            //usernamedatabase

        }
    }
}
