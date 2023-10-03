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

namespace SchoolManagementSystem
{
    public partial class Student_List : Form
    {
        public Student_List()
        {
            InitializeComponent();
        }
        public AppSettingsReader aps = new AppSettingsReader();
        private void btnsearch_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(aps.GetValue("myconnection", typeof(System.String)).ToString());
            //string sql = "select * from tblStudents";
            string sql = "select * from tblStudents where 1=1 AND (@Fname = '' OR FirstName=@Fname) AND (@Lname='' OR LastName=@Lname) AND (@email='' OR Email = @email) AND (@Grade = '' OR ClassLevel = @Grade)";
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@Fname", txtfname.Text);
            cmd.Parameters.AddWithValue("@Lname", txtlname.Text);
            cmd.Parameters.AddWithValue("@email", txtemail.Text);
            cmd.Parameters.AddWithValue("@Grade", cboclasslvl.SelectedItem == null ? "" : cboclasslvl.SelectedItem);

            //works as mediator between datasource and dataset
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //  collection of tables
            DataSet ds = new DataSet();

            da.Fill(ds, "stu");

            if (ds.Tables["stu"].Rows.Count > 0)
            {
                stddatalist.DataSource = ds.Tables["stu"];
            }
            else
            {
                MessageBox.Show("No Records Found");
                stddatalist.DataSource = null;
            }

        }

        private void txtfname_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(aps.GetValue("myconnection", typeof(System.String)).ToString());
            //string sql = "select * from tblStudents";
            string sql = "select * from tblStudents where 1=1 AND (@Fname = '' OR FirstName LIKE @Fname) AND (@Lname = '' OR LastName LIKE @Lname) AND (@email = '' OR Email LIKE @email) AND (@Grade = '' OR ClassLevel = @Grade)";
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@Fname", txtfname.Text == "" ? "" : txtfname.Text + "%");
            cmd.Parameters.AddWithValue("@Lname", txtlname.Text == "" ? "" : txtlname.Text + "%");
            cmd.Parameters.AddWithValue("@email", txtemail.Text == "" ? "" : txtemail.Text + "%");
            cmd.Parameters.AddWithValue("@Grade", cboclasslvl.SelectedItem == null ? "" : cboclasslvl.SelectedItem);

            //works as mediator between datasource and dataset
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //  collection of tables
            DataSet ds = new DataSet();

            da.Fill(ds, "stu");

            if (ds.Tables["stu"].Rows.Count > 0)
            {
                stddatalist.DataSource = ds.Tables["stu"];
            }
            else
            {
                MessageBox.Show("No Records Found");
                stddatalist.DataSource = null;
            }

        }

        private void stddatalist_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            UpdateStudent updstd = new UpdateStudent();
            updstd.txtSN.Text = stddatalist.SelectedRows[0].Cells[0].Value.ToString();
            updstd.txtfname.Text = stddatalist.SelectedRows[0].Cells[1].Value.ToString();
            updstd.txtlname.Text = stddatalist.SelectedRows[0].Cells[2].Value.ToString();
            updstd.txtgardphone.Text = stddatalist.SelectedRows[0].Cells[3].Value.ToString();
            updstd.cboclasslevel.Text = stddatalist.SelectedRows[0].Cells[5].Value.ToString();
            updstd.txtaddress.Text = stddatalist.SelectedRows[0].Cells[8].Value.ToString();
            //updstd.studentphoto.Image=

            byte[] imageData = (Byte[])stddatalist.SelectedRows[0].Cells[9].Value;
            if (imageData != null && imageData.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    Image image = Image.FromStream(ms);
                    updstd.studentphoto.Image = image;
                }

            }
            updstd.txtSN.Enabled = false;
            updstd.Show();
            this.Hide();
        }
    }
}
