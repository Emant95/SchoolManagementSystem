using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            txtemail.Text = "";
            txtfname.Text = "";
            txtlname.Text = "";
            txtpassword.Text = "";
            txtphone.Text = "";
            txtretypepw.Text = "";
            txtusername.Text = "";
            cbouesrtype.SelectedIndex = 0;
            rbtmale.Checked = true;
            txtfname.Focus();
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            rbtmale.Checked = true;
            cbouesrtype.SelectedIndex = 0;
        }

        private void Signup_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClearAll();
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        public AppSettingsReader aps = new AppSettingsReader();

        private void btnsignup_Click(object sender, EventArgs e)
        {
            if(txtpassword.Text != txtretypepw.Text)
            {
                MessageBox.Show("Password Mismatched");
                txtretypepw.Focus();
                return;   
            }
            if(txtusername.Text.Length < 5)
            {
                MessageBox.Show("Username must contain 5 Characters");
                txtusername.Focus();
                return;
            }
            if (txtfname.Text.Length > 2 && txtusername.Text.Length > 5)
            {
                string email = txtemail.Text;
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(email);
                if (match.Success)
                {
                    string Gender;
                    int i = 0;
                    if (rbtmale.Checked)
                        Gender = "M";
                    else if (rbtfemale.Checked)
                        Gender = "F";
                    else
                        Gender = "Others";

                    SqlConnection con = new SqlConnection(aps.GetValue("myconnection", typeof(System.String)).ToString());
                    string query = "INSERT INTO tblUsers VALUES(@FName,@LName,@Phone,@Gender,@Usertype,@Username,@Email,@Pasword,@CreatedDate,@UpdatedDate)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@FName", txtfname.Text);
                    cmd.Parameters.AddWithValue("@LName", txtlname.Text);
                    cmd.Parameters.AddWithValue("@Phone", txtphone.Text);
                    cmd.Parameters.AddWithValue("@Gender", Gender);
                    cmd.Parameters.AddWithValue("@Usertype", cbouesrtype.Text);
                    cmd.Parameters.AddWithValue("@Username", txtusername.Text);
                    cmd.Parameters.AddWithValue("@Email", txtemail.Text);
                    cmd.Parameters.AddWithValue("@Pasword", txtpassword.Text);
                    cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@UpdatedDate", DateTime.Now);

                    try
                    {
                        con.Open();
                        i = cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                        MessageBox.Show($"{i} Item added successfully");
                        ClearAll();
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Valid Email Address");
                    txtemail.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please Enter Valid First Name");
                txtfname.Focus();
            }

        }
    }
}
