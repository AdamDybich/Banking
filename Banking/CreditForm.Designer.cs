namespace Banking
{
    partial class CreditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_enterAccountNumber = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_oldBalance = new System.Windows.Forms.TextBox();
            this.txt_depositAmonut = new System.Windows.Forms.TextBox();
            this.box_mode = new System.Windows.Forms.ComboBox();
            this.btn_getDetails = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Date:";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(250, 58);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(0, 16);
            this.lbl_date.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Account Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Old Balance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mode";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Deposit Amonut";
            // 
            // txt_enterAccountNumber
            // 
            this.txt_enterAccountNumber.Location = new System.Drawing.Point(202, 106);
            this.txt_enterAccountNumber.Name = "txt_enterAccountNumber";
            this.txt_enterAccountNumber.Size = new System.Drawing.Size(340, 22);
            this.txt_enterAccountNumber.TabIndex = 7;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(202, 148);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(340, 22);
            this.txt_name.TabIndex = 8;
            // 
            // txt_oldBalance
            // 
            this.txt_oldBalance.Location = new System.Drawing.Point(202, 187);
            this.txt_oldBalance.Name = "txt_oldBalance";
            this.txt_oldBalance.Size = new System.Drawing.Size(340, 22);
            this.txt_oldBalance.TabIndex = 9;
            // 
            // txt_depositAmonut
            // 
            this.txt_depositAmonut.Location = new System.Drawing.Point(202, 282);
            this.txt_depositAmonut.Name = "txt_depositAmonut";
            this.txt_depositAmonut.Size = new System.Drawing.Size(340, 22);
            this.txt_depositAmonut.TabIndex = 10;
            // 
            // box_mode
            // 
            this.box_mode.FormattingEnabled = true;
            this.box_mode.Location = new System.Drawing.Point(202, 235);
            this.box_mode.Name = "box_mode";
            this.box_mode.Size = new System.Drawing.Size(340, 24);
            this.box_mode.TabIndex = 11;
            // 
            // btn_getDetails
            // 
            this.btn_getDetails.Location = new System.Drawing.Point(599, 104);
            this.btn_getDetails.Name = "btn_getDetails";
            this.btn_getDetails.Size = new System.Drawing.Size(113, 23);
            this.btn_getDetails.TabIndex = 12;
            this.btn_getDetails.Text = "Get Details";
            this.btn_getDetails.UseVisualStyleBackColor = true;
            this.btn_getDetails.Click += new System.EventHandler(this.btn_getDetails_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(202, 339);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(136, 51);
            this.btn_update.TabIndex = 13;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // CreditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_getDetails);
            this.Controls.Add(this.box_mode);
            this.Controls.Add(this.txt_depositAmonut);
            this.Controls.Add(this.txt_oldBalance);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_enterAccountNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.label1);
            this.Name = "CreditForm";
            this.Text = "CreditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_enterAccountNumber;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_oldBalance;
        private System.Windows.Forms.TextBox txt_depositAmonut;
        private System.Windows.Forms.ComboBox box_mode;
        private System.Windows.Forms.Button btn_getDetails;
        private System.Windows.Forms.Button btn_update;
    }
}