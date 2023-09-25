using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagementBLL;
namespace SchoolManagementSystem
{
    public partial class Admission : Form
    {
        public Admission()
        {
            InitializeComponent();
        }

        private void btnupload_Click(object sender, EventArgs e)
        {
            Stream mystream = null;
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    if ((mystream = opnfd.OpenFile()) != null)
                    {
                        string FileName = opnfd.FileName;
                        if (mystream.Length > 512000)
                        {
                            MessageBox.Show("File Size Limit Exceed");
                        }
                        else
                        {
                            studentphoto.Load(FileName);
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        public AppSettingsReader aps = new AppSettingsReader();
        private void btnAdmit_Click(object sender, EventArgs e)
        {
            AdmissionBLL chkstd = new AdmissionBLL();
            bool exists = chkstd.checkStudent(txtfname.Text, txtlname.Text, txtemail.Text);
            if (exists)
            {
                MessageBox.Show("Student already exists");
                txtfname.Text = "";
                txtemail.Text = "";
                txtemail.Focus();

            }
            //else
            else if (txtfname.Text == "" || txtlname.Text == "" || cboclasslevel.Text == "" || txtguardname.Text == "" || txtemail.Text == "")
            {
                MessageBox.Show("Please Enter Mandatory Fields");
            }

            else if (studentphoto == null || studentphoto.Image == null)
            {
                MessageBox.Show("Please select Image");

            }

            else
            {
                AdmissionBLL admission = new AdmissionBLL();
                MemoryStream ms = new MemoryStream();
                studentphoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] pic = ms.ToArray();
                string gender;
                if (rbtmale.Checked)
                    gender = "M";
                else if (rbtfemale.Checked)
                    gender = "F";
                else
                    gender = "Others";
                admission.FirstName = txtfname.Text;
                admission.LastName = txtlname.Text;
                admission.GuardianPhone = txtgardphone.Text;
                admission.Gender = gender;
                admission.ClassLevel = Convert.ToInt32(cboclasslevel.SelectedItem);
                admission.GuardianName = txtguardname.Text;
                admission.Email = txtemail.Text;
                admission.Address = txtaddress.Text;
                admission.RollNo = 1;
                admission.AdmissionDate = DateTime.Now;
                admission.AdmissionStatus = 0;
                admission.Photo = pic;

                try
                {
                    int i= admission.AddStudentBLL();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    MessageBox.Show("Student Admitted successfully");

                }
            }
        }
    }
}
