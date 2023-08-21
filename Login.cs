using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public AppSettingsReader aps = new AppSettingsReader();

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text.Trim() != "" && txtpassword.Text.Trim() != "")
            {
                int i;
                SqlConnection con = new SqlConnection(aps.GetValue("myconnection", typeof(System.String)).ToString());
                string query = "Select * from tblUsers Where (Username=@Username OR Email=@Username) AND Usertype=@Usertype AND Password=@Pasword";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Username", txtusername.Text);
                cmd.Parameters.AddWithValue("@Pasword", txtpassword.Text);
                cmd.Parameters.AddWithValue("@Usertype", cboUsertype.Text);
                con.Open();
                //i = cmd.ExecuteNonQuery();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                DataSet ds1 = new DataSet();

                da1.Fill(ds1, "a");
                if (ds1.Tables["a"].Rows.Count > 0)
                {
                //}
                //if (i > 0)
                //{
                    MessageBox.Show($"WELCOME TO BHSS: {ds1.Tables["a"].Rows[0]["FName"] + " " + ds1.Tables["a"].Rows[0]["LName"]}");
                    Mainpage mpage = new Mainpage();
                    mpage.lblprofile.Text = txtusername.Text;
                    mpage.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Please Enter Correct Username and Password");
                    txtpassword.Clear();
                    txtusername.Clear();
                    txtusername.Focus();
                }

                //    if (txtusername.Text == Username)
                //    {
                //        if(txtpassword.Text == Password)
                //        {
                //            Mainpage mpage = new Mainpage();
                //            mpage.Show();
                //            this.Hide();
                //        }
                //        else
                //        {
                //            MessageBox.Show("Please Enter correct Password");                        
                //            txtpassword.Clear();
                //            txtpassword.Focus();
                //        }
                //    }
                //    else
                //    {
                //        MessageBox.Show("Please Enter correct Username");
                //        txtusername.Clear();
                //        txtpassword.Clear();
                //        txtusername.Focus();
                //    }
                //}
                //else
                //{
                //    MessageBox.Show("Please Enter Username and Password");
                //    txtusername.Focus();
                //}
            }
            else
            {
                MessageBox.Show("Please Enter Username and Password");
                txtusername.Focus();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to BHSS Login to Cotinue");
        }

        private void linklblsignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup spage = new Signup();
            spage.Show();
            this.Hide();
        }

        private void linklblforgetpw_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPassword spage = new ForgetPassword();
            spage.Show();
        }
    }
}
