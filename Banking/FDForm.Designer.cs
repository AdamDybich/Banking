namespace Banking
{
    partial class FDForm
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
            this.lbl_accountNo = new System.Windows.Forms.Label();
            this.lbl_mode = new System.Windows.Forms.Label();
            this.lbl_rupees = new System.Windows.Forms.Label();
            this.lbl_period = new System.Windows.Forms.Label();
            this.lbl_interest = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_accountNo = new System.Windows.Forms.TextBox();
            this.txt_rupees = new System.Windows.Forms.TextBox();
            this.txt_period = new System.Windows.Forms.TextBox();
            this.txt_interest = new System.Windows.Forms.TextBox();
            this.box_mode = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(520, 38);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(67, 29);
            this.lbl_Date.TabIndex = 0;
            this.lbl_Date.Text = "Date";
            // 
            // lbl_accountNo
            // 
            this.lbl_accountNo.AutoSize = true;
            this.lbl_accountNo.Location = new System.Drawing.Point(47, 89);
            this.lbl_accountNo.Name = "lbl_accountNo";
            this.lbl_accountNo.Size = new System.Drawing.Size(79, 16);
            this.lbl_accountNo.TabIndex = 1;
            this.lbl_accountNo.Text = "Account No.";
            // 
            // lbl_mode
            // 
            this.lbl_mode.AutoSize = true;
            this.lbl_mode.Location = new System.Drawing.Point(47, 145);
            this.lbl_mode.Name = "lbl_mode";
            this.lbl_mode.Size = new System.Drawing.Size(42, 16);
            this.lbl_mode.TabIndex = 2;
            this.lbl_mode.Text = "Mode";
            // 
            // lbl_rupees
            // 
            this.lbl_rupees.AutoSize = true;
            this.lbl_rupees.Location = new System.Drawing.Point(47, 190);
            this.lbl_rupees.Name = "lbl_rupees";
            this.lbl_rupees.Size = new System.Drawing.Size(55, 16);
            this.lbl_rupees.TabIndex = 3;
            this.lbl_rupees.Text = "Ruppes";
            // 
            // lbl_period
            // 
            this.lbl_period.AutoSize = true;
            this.lbl_period.Location = new System.Drawing.Point(47, 242);
            this.lbl_period.Name = "lbl_period";
            this.lbl_period.Size = new System.Drawing.Size(78, 16);
            this.lbl_period.TabIndex = 4;
            this.lbl_period.Text = "Period(day)";
            // 
            // lbl_interest
            // 
            this.lbl_interest.AutoSize = true;
            this.lbl_interest.Location = new System.Drawing.Point(47, 293);
            this.lbl_interest.Name = "lbl_interest";
            this.lbl_interest.Size = new System.Drawing.Size(70, 16);
            this.lbl_interest.TabIndex = 5;
            this.lbl_interest.Text = "Interest(%)";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(190, 363);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_accountNo
            // 
            this.txt_accountNo.Location = new System.Drawing.Point(172, 82);
            this.txt_accountNo.Name = "txt_accountNo";
            this.txt_accountNo.Size = new System.Drawing.Size(175, 22);
            this.txt_accountNo.TabIndex = 7;
            // 
            // txt_rupees
            // 
            this.txt_rupees.Location = new System.Drawing.Point(172, 184);
            this.txt_rupees.Name = "txt_rupees";
            this.txt_rupees.Size = new System.Drawing.Size(175, 22);
            this.txt_rupees.TabIndex = 8;
            // 
            // txt_period
            // 
            this.txt_period.Location = new System.Drawing.Point(172, 239);
            this.txt_period.Name = "txt_period";
            this.txt_period.Size = new System.Drawing.Size(175, 22);
            this.txt_period.TabIndex = 9;
            // 
            // txt_interest
            // 
            this.txt_interest.Location = new System.Drawing.Point(172, 293);
            this.txt_interest.Name = "txt_interest";
            this.txt_interest.Size = new System.Drawing.Size(175, 22);
            this.txt_interest.TabIndex = 10;
            // 
            // box_mode
            // 
            this.box_mode.FormattingEnabled = true;
            this.box_mode.Location = new System.Drawing.Point(172, 136);
            this.box_mode.Name = "box_mode";
            this.box_mode.Size = new System.Drawing.Size(175, 24);
            this.box_mode.TabIndex = 11;
            // 
            // FDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.box_mode);
            this.Controls.Add(this.txt_interest);
            this.Controls.Add(this.txt_period);
            this.Controls.Add(this.txt_rupees);
            this.Controls.Add(this.txt_accountNo);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_interest);
            this.Controls.Add(this.lbl_period);
            this.Controls.Add(this.lbl_rupees);
            this.Controls.Add(this.lbl_mode);
            this.Controls.Add(this.lbl_accountNo);
            this.Controls.Add(this.lbl_Date);
            this.Name = "FDForm";
            this.Text = "FDForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_accountNo;
        private System.Windows.Forms.Label lbl_mode;
        private System.Windows.Forms.Label lbl_rupees;
        private System.Windows.Forms.Label lbl_period;
        private System.Windows.Forms.Label lbl_interest;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_accountNo;
        private System.Windows.Forms.TextBox txt_rupees;
        private System.Windows.Forms.TextBox txt_period;
        private System.Windows.Forms.TextBox txt_interest;
        private System.Windows.Forms.ComboBox box_mode;
    }
}