namespace Banking
{
    partial class Debitform
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
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_enterAccountNo = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_oldBalance = new System.Windows.Forms.Label();
            this.lbl_mode = new System.Windows.Forms.Label();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.txt_enterAccountNo = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_oldBalance = new System.Windows.Forms.TextBox();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_getDetails = new System.Windows.Forms.Button();
            this.box_mode = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(50, 30);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(67, 29);
            this.lbl_Date.TabIndex = 0;
            this.lbl_Date.Text = "Date";
            // 
            // lbl_enterAccountNo
            // 
            this.lbl_enterAccountNo.AutoSize = true;
            this.lbl_enterAccountNo.Location = new System.Drawing.Point(50, 78);
            this.lbl_enterAccountNo.Name = "lbl_enterAccountNo";
            this.lbl_enterAccountNo.Size = new System.Drawing.Size(113, 16);
            this.lbl_enterAccountNo.TabIndex = 1;
            this.lbl_enterAccountNo.Text = "Enter Account No.";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(50, 122);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(44, 16);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Name";
            // 
            // lbl_oldBalance
            // 
            this.lbl_oldBalance.AutoSize = true;
            this.lbl_oldBalance.Location = new System.Drawing.Point(50, 169);
            this.lbl_oldBalance.Name = "lbl_oldBalance";
            this.lbl_oldBalance.Size = new System.Drawing.Size(81, 16);
            this.lbl_oldBalance.TabIndex = 3;
            this.lbl_oldBalance.Text = "Old Balance";
            // 
            // lbl_mode
            // 
            this.lbl_mode.AutoSize = true;
            this.lbl_mode.Location = new System.Drawing.Point(50, 215);
            this.lbl_mode.Name = "lbl_mode";
            this.lbl_mode.Size = new System.Drawing.Size(42, 16);
            this.lbl_mode.TabIndex = 4;
            this.lbl_mode.Text = "Mode";
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Location = new System.Drawing.Point(52, 258);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(52, 16);
            this.lbl_amount.TabIndex = 5;
            this.lbl_amount.Text = "Amount";
            // 
            // txt_enterAccountNo
            // 
            this.txt_enterAccountNo.Location = new System.Drawing.Point(225, 71);
            this.txt_enterAccountNo.Name = "txt_enterAccountNo";
            this.txt_enterAccountNo.Size = new System.Drawing.Size(287, 22);
            this.txt_enterAccountNo.TabIndex = 6;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(225, 119);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(287, 22);
            this.txt_name.TabIndex = 7;
            // 
            // txt_oldBalance
            // 
            this.txt_oldBalance.Location = new System.Drawing.Point(225, 166);
            this.txt_oldBalance.Name = "txt_oldBalance";
            this.txt_oldBalance.Size = new System.Drawing.Size(287, 22);
            this.txt_oldBalance.TabIndex = 8;
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(225, 255);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(287, 22);
            this.txt_amount.TabIndex = 10;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(225, 323);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 11;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_getDetails
            // 
            this.btn_getDetails.Location = new System.Drawing.Point(562, 70);
            this.btn_getDetails.Name = "btn_getDetails";
            this.btn_getDetails.Size = new System.Drawing.Size(120, 23);
            this.btn_getDetails.TabIndex = 12;
            this.btn_getDetails.Text = "Get Details";
            this.btn_getDetails.UseVisualStyleBackColor = true;
            this.btn_getDetails.Click += new System.EventHandler(this.btn_getDetails_Click);
            // 
            // box_mode
            // 
            this.box_mode.FormattingEnabled = true;
            this.box_mode.Location = new System.Drawing.Point(225, 206);
            this.box_mode.Name = "box_mode";
            this.box_mode.Size = new System.Drawing.Size(287, 24);
            this.box_mode.TabIndex = 13;
            // 
            // Debitform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.box_mode);
            this.Controls.Add(this.btn_getDetails);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.txt_oldBalance);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_enterAccountNo);
            this.Controls.Add(this.lbl_amount);
            this.Controls.Add(this.lbl_mode);
            this.Controls.Add(this.lbl_oldBalance);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_enterAccountNo);
            this.Controls.Add(this.lbl_Date);
            this.Name = "Debitform";
            this.Text = "Debitform";
            this.Load += new System.EventHandler(this.Debitform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_enterAccountNo;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_oldBalance;
        private System.Windows.Forms.Label lbl_mode;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.TextBox txt_enterAccountNo;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_oldBalance;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_getDetails;
        private System.Windows.Forms.ComboBox box_mode;
    }
}