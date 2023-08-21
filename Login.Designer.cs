
namespace SchoolManagementSystem
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblschool = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linklblforgetpw = new System.Windows.Forms.LinkLabel();
            this.linklblsignup = new System.Windows.Forms.LinkLabel();
            this.cboUsertype = new System.Windows.Forms.ComboBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblschool
            // 
            this.lblschool.AutoSize = true;
            this.lblschool.BackColor = System.Drawing.Color.Transparent;
            this.lblschool.Font = new System.Drawing.Font("Ravie", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblschool.ForeColor = System.Drawing.Color.Red;
            this.lblschool.Location = new System.Drawing.Point(28, 9);
            this.lblschool.Name = "lblschool";
            this.lblschool.Size = new System.Drawing.Size(1044, 49);
            this.lblschool.TabIndex = 0;
            this.lblschool.Text = "BHADRAKALI HIGHER SECONDARY SCHOOL";
            this.lblschool.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SchoolManagementSystem.Properties.Resources.login;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.linklblforgetpw);
            this.panel1.Controls.Add(this.linklblsignup);
            this.panel1.Controls.Add(this.cboUsertype);
            this.panel1.Controls.Add(this.txtpassword);
            this.panel1.Controls.Add(this.btnlogin);
            this.panel1.Controls.Add(this.txtusername);
            this.panel1.Location = new System.Drawing.Point(283, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 475);
            this.panel1.TabIndex = 1;
            // 
            // linklblforgetpw
            // 
            this.linklblforgetpw.AutoSize = true;
            this.linklblforgetpw.Location = new System.Drawing.Point(205, 439);
            this.linklblforgetpw.Name = "linklblforgetpw";
            this.linklblforgetpw.Size = new System.Drawing.Size(129, 20);
            this.linklblforgetpw.TabIndex = 6;
            this.linklblforgetpw.TabStop = true;
            this.linklblforgetpw.Text = "Forget Password";
            this.linklblforgetpw.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblforgetpw_LinkClicked);
            // 
            // linklblsignup
            // 
            this.linklblsignup.AutoSize = true;
            this.linklblsignup.Location = new System.Drawing.Point(117, 439);
            this.linklblsignup.Name = "linklblsignup";
            this.linklblsignup.Size = new System.Drawing.Size(66, 20);
            this.linklblsignup.TabIndex = 5;
            this.linklblsignup.TabStop = true;
            this.linklblsignup.Text = "Sign Up";
            this.linklblsignup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblsignup_LinkClicked);
            // 
            // cboUsertype
            // 
            this.cboUsertype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUsertype.FormattingEnabled = true;
            this.cboUsertype.Items.AddRange(new object[] {
            "User",
            "Admin"});
            this.cboUsertype.Location = new System.Drawing.Point(142, 338);
            this.cboUsertype.Name = "cboUsertype";
            this.cboUsertype.Size = new System.Drawing.Size(157, 37);
            this.cboUsertype.TabIndex = 4;
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(147, 288);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(148, 35);
            this.txtpassword.TabIndex = 3;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(121, 385);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(199, 41);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(147, 237);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(148, 35);
            this.txtusername.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SchoolManagementSystem.Properties.Resources.MyWallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1092, 547);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblschool);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblschool;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtusername;
        public System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.LinkLabel linklblforgetpw;
        private System.Windows.Forms.LinkLabel linklblsignup;
        private System.Windows.Forms.ComboBox cboUsertype;
    }
}