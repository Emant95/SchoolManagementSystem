
namespace SchoolManagementSystem
{
    partial class Student_List
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
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.cboclasslvl = new System.Windows.Forms.ComboBox();
            this.lblfname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stddatalist = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.stddatalist)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(865, 49);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(173, 56);
            this.btnsearch.TabIndex = 0;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(70, 64);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(173, 26);
            this.txtfname.TabIndex = 1;
            this.txtfname.TextChanged += new System.EventHandler(this.txtfname_TextChanged);
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(293, 64);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(173, 26);
            this.txtlname.TabIndex = 2;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(523, 64);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(173, 26);
            this.txtemail.TabIndex = 3;
            // 
            // cboclasslvl
            // 
            this.cboclasslvl.FormattingEnabled = true;
            this.cboclasslvl.Items.AddRange(new object[] {
            "",
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
            this.cboclasslvl.Location = new System.Drawing.Point(713, 64);
            this.cboclasslvl.Name = "cboclasslvl";
            this.cboclasslvl.Size = new System.Drawing.Size(121, 28);
            this.cboclasslvl.TabIndex = 4;
            // 
            // lblfname
            // 
            this.lblfname.AutoSize = true;
            this.lblfname.Location = new System.Drawing.Point(102, 38);
            this.lblfname.Name = "lblfname";
            this.lblfname.Size = new System.Drawing.Size(86, 20);
            this.lblfname.TabIndex = 5;
            this.lblfname.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(577, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(738, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Grade";
            // 
            // stddatalist
            // 
            this.stddatalist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stddatalist.Location = new System.Drawing.Point(70, 175);
            this.stddatalist.Name = "stddatalist";
            this.stddatalist.RowHeadersWidth = 62;
            this.stddatalist.RowTemplate.Height = 28;
            this.stddatalist.Size = new System.Drawing.Size(1043, 560);
            this.stddatalist.TabIndex = 9;
            this.stddatalist.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.stddatalist_RowHeaderMouseDoubleClick);
            // 
            // Student_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 813);
            this.Controls.Add(this.stddatalist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblfname);
            this.Controls.Add(this.cboclasslvl);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.btnsearch);
            this.Name = "Student_List";
            this.Text = "Student List";
            ((System.ComponentModel.ISupportInitialize)(this.stddatalist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.ComboBox cboclasslvl;
        private System.Windows.Forms.Label lblfname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView stddatalist;
    }
}