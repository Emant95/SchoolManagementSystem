
namespace SchoolManagementSystem
{
    partial class UpdateStudent
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
            this.btnupload = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboclasslevel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtgardphone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.lblfname = new System.Windows.Forms.Label();
            this.studentphoto = new System.Windows.Forms.PictureBox();
            this.txtSN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentphoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnupload
            // 
            this.btnupload.Location = new System.Drawing.Point(728, 456);
            this.btnupload.Name = "btnupload";
            this.btnupload.Size = new System.Drawing.Size(125, 66);
            this.btnupload.TabIndex = 76;
            this.btnupload.Text = "Upload";
            this.btnupload.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(301, 614);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(202, 66);
            this.btnUpdate.TabIndex = 68;
            this.btnUpdate.Text = "Update Student";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(143, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 31);
            this.label7.TabIndex = 67;
            this.label7.Text = "Photo";
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(345, 360);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(299, 35);
            this.txtaddress.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(152, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 31);
            this.label6.TabIndex = 65;
            this.label6.Text = "Address";
            // 
            // cboclasslevel
            // 
            this.cboclasslevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboclasslevel.FormattingEnabled = true;
            this.cboclasslevel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cboclasslevel.Location = new System.Drawing.Point(345, 296);
            this.cboclasslevel.Name = "cboclasslevel";
            this.cboclasslevel.Size = new System.Drawing.Size(299, 37);
            this.cboclasslevel.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(159, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 31);
            this.label4.TabIndex = 61;
            this.label4.Text = "Class";
            // 
            // txtgardphone
            // 
            this.txtgardphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgardphone.Location = new System.Drawing.Point(345, 225);
            this.txtgardphone.MaxLength = 14;
            this.txtgardphone.Name = "txtgardphone";
            this.txtgardphone.Size = new System.Drawing.Size(299, 35);
            this.txtgardphone.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 31);
            this.label2.TabIndex = 58;
            this.label2.Text = "Guardian Phone";
            // 
            // txtlname
            // 
            this.txtlname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlname.Location = new System.Drawing.Point(345, 159);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(299, 35);
            this.txtlname.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 31);
            this.label1.TabIndex = 56;
            this.label1.Text = "Last Name";
            // 
            // txtfname
            // 
            this.txtfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfname.Location = new System.Drawing.Point(345, 96);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(299, 35);
            this.txtfname.TabIndex = 55;
            // 
            // lblfname
            // 
            this.lblfname.AutoSize = true;
            this.lblfname.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfname.Location = new System.Drawing.Point(152, 100);
            this.lblfname.Name = "lblfname";
            this.lblfname.Size = new System.Drawing.Size(142, 31);
            this.lblfname.TabIndex = 54;
            this.lblfname.Text = "First Name";
            // 
            // studentphoto
            // 
            this.studentphoto.Location = new System.Drawing.Point(387, 412);
            this.studentphoto.Name = "studentphoto";
            this.studentphoto.Size = new System.Drawing.Size(228, 171);
            this.studentphoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.studentphoto.TabIndex = 75;
            this.studentphoto.TabStop = false;
            // 
            // txtSN
            // 
            this.txtSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSN.Location = new System.Drawing.Point(345, 43);
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(299, 35);
            this.txtSN.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 31);
            this.label3.TabIndex = 77;
            this.label3.Text = "Symbol NO:";
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(763, 614);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(125, 66);
            this.btnclear.TabIndex = 69;
            this.btnclear.Text = "Close";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(551, 614);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(175, 66);
            this.btndelete.TabIndex = 79;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // UpdateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 833);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.txtSN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnupload);
            this.Controls.Add(this.studentphoto);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboclasslevel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtgardphone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.lblfname);
            this.Name = "UpdateStudent";
            this.Text = "UpdateStudent";
            ((System.ComponentModel.ISupportInitialize)(this.studentphoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblfname;
        public System.Windows.Forms.TextBox txtSN;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnupload;
        public System.Windows.Forms.PictureBox studentphoto;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.TextBox txtaddress;
        public System.Windows.Forms.ComboBox cboclasslevel;
        public System.Windows.Forms.TextBox txtgardphone;
        public System.Windows.Forms.TextBox txtlname;
        public System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btndelete;
    }
}