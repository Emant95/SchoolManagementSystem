using StudentManagementBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class UpdateStudent : Form
    {
        public UpdateStudent()
        {
            InitializeComponent();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtfname.Text == "" || txtlname.Text == "" || cboclasslevel.Text == "")
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
                //MemoryStream ms = new MemoryStream();
                //studentphoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                //byte[] pic = ms.ToArray();
                admission.SN = Convert.ToInt32(txtSN.Text);
                admission.FirstName = txtfname.Text;
                admission.LastName = txtlname.Text;
                admission.GuardianPhone = txtgardphone.Text;
                admission.ClassLevel = Convert.ToInt32(cboclasslevel.Text.ToString().Trim());
                admission.Address = txtaddress.Text;
                //admission.RollNo = 1;
                //admission.AdmissionDate = DateTime.Now;
                //admission.AdmissionStatus = 0;
                //admission.Photo = pic;


                try
                {
                    int i = admission.UpdateStudentBLL();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    MessageBox.Show("Student Updated successfully");

                }
            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {


            AdmissionBLL admission = new AdmissionBLL();
            admission.SN = Convert.ToInt32(txtSN.Text);

            try
            {
                int i = admission.DeleteStudentBLL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("Student Deleted successfully");

            }


        }
    }
}
