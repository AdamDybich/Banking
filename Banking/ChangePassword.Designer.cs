namespace Banking
{
    partial class ChangePassword
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
            this.lbl_changePassword = new System.Windows.Forms.Label();
            this.lbl_oldPassword = new System.Windows.Forms.Label();
            this.lbl_newPassword = new System.Windows.Forms.Label();
            this.lbl_retypePassword = new System.Windows.Forms.Label();
            this.txt_oldPassword = new System.Windows.Forms.TextBox();
            this.txt_newPassword = new System.Windows.Forms.TextBox();
            this.txt_retypePassword = new System.Windows.Forms.TextBox();
            this.btn_changePassword = new System.Windows.Forms.Button();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_changePassword
            // 
            this.lbl_changePassword.AutoSize = true;
            this.lbl_changePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_changePassword.Location = new System.Drawing.Point(223, 34);
            this.lbl_changePassword.Name = "lbl_changePassword";
            this.lbl_changePassword.Size = new System.Drawing.Size(225, 29);
            this.lbl_changePassword.TabIndex = 0;
            this.lbl_changePassword.Text = "Change Password";
            // 
            // lbl_oldPassword
            // 
            this.lbl_oldPassword.AutoSize = true;
            this.lbl_oldPassword.Location = new System.Drawing.Point(43, 149);
            this.lbl_oldPassword.Name = "lbl_oldPassword";
            this.lbl_oldPassword.Size = new System.Drawing.Size(91, 16);
            this.lbl_oldPassword.TabIndex = 2;
            this.lbl_oldPassword.Text = "Old Password";
            // 
            // lbl_newPassword
            // 
            this.lbl_newPassword.AutoSize = true;
            this.lbl_newPassword.Location = new System.Drawing.Point(43, 192);
            this.lbl_newPassword.Name = "lbl_newPassword";
            this.lbl_newPassword.Size = new System.Drawing.Size(97, 16);
            this.lbl_newPassword.TabIndex = 3;
            this.lbl_newPassword.Text = "New Password";
            // 
            // lbl_retypePassword
            // 
            this.lbl_retypePassword.AutoSize = true;
            this.lbl_retypePassword.Location = new System.Drawing.Point(43, 235);
            this.lbl_retypePassword.Name = "lbl_retypePassword";
            this.lbl_retypePassword.Size = new System.Drawing.Size(114, 16);
            this.lbl_retypePassword.TabIndex = 4;
            this.lbl_retypePassword.Text = "Retype Password";
            // 
            // txt_oldPassword
            // 
            this.txt_oldPassword.Location = new System.Drawing.Point(228, 143);
            this.txt_oldPassword.Name = "txt_oldPassword";
            this.txt_oldPassword.Size = new System.Drawing.Size(240, 22);
            this.txt_oldPassword.TabIndex = 6;
            // 
            // txt_newPassword
            // 
            this.txt_newPassword.Location = new System.Drawing.Point(228, 186);
            this.txt_newPassword.Name = "txt_newPassword";
            this.txt_newPassword.Size = new System.Drawing.Size(240, 22);
            this.txt_newPassword.TabIndex = 7;
            // 
            // txt_retypePassword
            // 
            this.txt_retypePassword.Location = new System.Drawing.Point(228, 232);
            this.txt_retypePassword.Name = "txt_retypePassword";
            this.txt_retypePassword.Size = new System.Drawing.Size(240, 22);
            this.txt_retypePassword.TabIndex = 8;
            // 
            // btn_changePassword
            // 
            this.btn_changePassword.Location = new System.Drawing.Point(228, 302);
            this.btn_changePassword.Name = "btn_changePassword";
            this.btn_changePassword.Size = new System.Drawing.Size(145, 58);
            this.btn_changePassword.TabIndex = 9;
            this.btn_changePassword.Text = "Change Password";
            this.btn_changePassword.UseVisualStyleBackColor = true;
            this.btn_changePassword.Click += new System.EventHandler(this.btn_changePassword_Click);
            // 
            // lbl_userName
            // 
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.Location = new System.Drawing.Point(43, 105);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(76, 16);
            this.lbl_userName.TabIndex = 10;
            this.lbl_userName.Text = "User Name";
            // 
            // txt_userName
            // 
            this.txt_userName.Location = new System.Drawing.Point(228, 98);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(240, 22);
            this.txt_userName.TabIndex = 11;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_userName);
            this.Controls.Add(this.lbl_userName);
            this.Controls.Add(this.btn_changePassword);
            this.Controls.Add(this.txt_retypePassword);
            this.Controls.Add(this.txt_newPassword);
            this.Controls.Add(this.txt_oldPassword);
            this.Controls.Add(this.lbl_retypePassword);
            this.Controls.Add(this.lbl_newPassword);
            this.Controls.Add(this.lbl_oldPassword);
            this.Controls.Add(this.lbl_changePassword);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_changePassword;
        private System.Windows.Forms.Label lbl_oldPassword;
        private System.Windows.Forms.Label lbl_newPassword;
        private System.Windows.Forms.Label lbl_retypePassword;
        private System.Windows.Forms.TextBox txt_oldPassword;
        private System.Windows.Forms.TextBox txt_newPassword;
        private System.Windows.Forms.TextBox txt_retypePassword;
        private System.Windows.Forms.Button btn_changePassword;
        private System.Windows.Forms.Label lbl_userName;
        private System.Windows.Forms.TextBox txt_userName;
    }
}