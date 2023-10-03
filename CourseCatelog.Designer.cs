
namespace SchoolManagementSystem
{
    partial class CourseCatelog
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboclasslevel = new System.Windows.Forms.ComboBox();
            this.btnaddcatelog = new System.Windows.Forms.Button();
            this.lblclasslabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnaddcatelog);
            this.panel1.Controls.Add(this.cboclasslevel);
            this.panel1.Location = new System.Drawing.Point(170, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 58);
            this.panel1.TabIndex = 0;
            // 
            // cboclasslevel
            // 
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
            this.cboclasslevel.Location = new System.Drawing.Point(41, 15);
            this.cboclasslevel.Name = "cboclasslevel";
            this.cboclasslevel.Size = new System.Drawing.Size(382, 28);
            this.cboclasslevel.TabIndex = 0;
            // 
            // btnaddcatelog
            // 
            this.btnaddcatelog.Location = new System.Drawing.Point(577, 8);
            this.btnaddcatelog.Name = "btnaddcatelog";
            this.btnaddcatelog.Size = new System.Drawing.Size(296, 40);
            this.btnaddcatelog.TabIndex = 1;
            this.btnaddcatelog.Text = "Add Catelog";
            this.btnaddcatelog.UseVisualStyleBackColor = true;
            // 
            // lblclasslabel
            // 
            this.lblclasslabel.AutoSize = true;
            this.lblclasslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclasslabel.Location = new System.Drawing.Point(162, 123);
            this.lblclasslabel.Name = "lblclasslabel";
            this.lblclasslabel.Size = new System.Drawing.Size(120, 46);
            this.lblclasslabel.TabIndex = 1;
            this.lblclasslabel.Text = "Class";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(170, 188);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(803, 461);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // CourseCatelog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 807);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblclasslabel);
            this.Controls.Add(this.panel1);
            this.Name = "CourseCatelog";
            this.Text = "CourseCatelog";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnaddcatelog;
        private System.Windows.Forms.ComboBox cboclasslevel;
        private System.Windows.Forms.Label lblclasslabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}