
namespace SchoolManagementSystem
{
    partial class ForgetPassword
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
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lbluname = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnsendmail = new System.Windows.Forms.Button();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(284, 77);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(299, 35);
            this.txtusername.TabIndex = 35;
            // 
            // lbluname
            // 
            this.lbluname.AutoSize = true;
            this.lbluname.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluname.Location = new System.Drawing.Point(91, 81);
            this.lbluname.Name = "lbluname";
            this.lbluname.Size = new System.Drawing.Size(139, 31);
            this.lbluname.TabIndex = 34;
            this.lbluname.Text = "User Name";
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(458, 216);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(125, 66);
            this.btnclose.TabIndex = 33;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnsendmail
            // 
            this.btnsendmail.Location = new System.Drawing.Point(211, 216);
            this.btnsendmail.Name = "btnsendmail";
            this.btnsendmail.Size = new System.Drawing.Size(125, 66);
            this.btnsendmail.TabIndex = 32;
            this.btnsendmail.Text = "Send Mail";
            this.btnsendmail.UseVisualStyleBackColor = true;
            this.btnsendmail.Click += new System.EventHandler(this.btnsendmail_Click);
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(284, 132);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(299, 35);
            this.txtemail.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 31);
            this.label5.TabIndex = 30;
            this.label5.Text = "Email";
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(781, 358);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lbluname);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnsendmail);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ForgetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forget Password";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ForgetPassword_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label lbluname;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnsendmail;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label5;
    }
}