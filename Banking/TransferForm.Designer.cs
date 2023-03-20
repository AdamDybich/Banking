namespace Banking
{
    partial class TransferForm
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_formAccountNumber = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_currentAmount = new System.Windows.Forms.Label();
            this.lbl_destinationAccount = new System.Windows.Forms.Label();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.txt_fromAccountNumber = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_currentAmount = new System.Windows.Forms.TextBox();
            this.txt_destinationAccount = new System.Windows.Forms.TextBox();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.btn_showDetails = new System.Windows.Forms.Button();
            this.btn_transferAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(60, 52);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(67, 29);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Date";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Location = new System.Drawing.Point(166, 62);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(0, 16);
            this.lbl_Date.TabIndex = 1;
            // 
            // lbl_formAccountNumber
            // 
            this.lbl_formAccountNumber.AutoSize = true;
            this.lbl_formAccountNumber.Location = new System.Drawing.Point(65, 119);
            this.lbl_formAccountNumber.Name = "lbl_formAccountNumber";
            this.lbl_formAccountNumber.Size = new System.Drawing.Size(140, 16);
            this.lbl_formAccountNumber.TabIndex = 2;
            this.lbl_formAccountNumber.Text = "Form Account Number";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(65, 168);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(44, 16);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "Name";
            // 
            // lbl_currentAmount
            // 
            this.lbl_currentAmount.AutoSize = true;
            this.lbl_currentAmount.Location = new System.Drawing.Point(65, 218);
            this.lbl_currentAmount.Name = "lbl_currentAmount";
            this.lbl_currentAmount.Size = new System.Drawing.Size(97, 16);
            this.lbl_currentAmount.TabIndex = 4;
            this.lbl_currentAmount.Text = "Current Amount";
            // 
            // lbl_destinationAccount
            // 
            this.lbl_destinationAccount.AutoSize = true;
            this.lbl_destinationAccount.Location = new System.Drawing.Point(69, 260);
            this.lbl_destinationAccount.Name = "lbl_destinationAccount";
            this.lbl_destinationAccount.Size = new System.Drawing.Size(125, 16);
            this.lbl_destinationAccount.TabIndex = 5;
            this.lbl_destinationAccount.Text = "Destination Account";
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Location = new System.Drawing.Point(69, 306);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(52, 16);
            this.lbl_amount.TabIndex = 6;
            this.lbl_amount.Text = "Amount";
            // 
            // txt_fromAccountNumber
            // 
            this.txt_fromAccountNumber.Location = new System.Drawing.Point(258, 119);
            this.txt_fromAccountNumber.Name = "txt_fromAccountNumber";
            this.txt_fromAccountNumber.Size = new System.Drawing.Size(203, 22);
            this.txt_fromAccountNumber.TabIndex = 7;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(258, 162);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(203, 22);
            this.txt_name.TabIndex = 8;
            // 
            // txt_currentAmount
            // 
            this.txt_currentAmount.Location = new System.Drawing.Point(258, 212);
            this.txt_currentAmount.Name = "txt_currentAmount";
            this.txt_currentAmount.Size = new System.Drawing.Size(203, 22);
            this.txt_currentAmount.TabIndex = 9;
            // 
            // txt_destinationAccount
            // 
            this.txt_destinationAccount.Location = new System.Drawing.Point(258, 254);
            this.txt_destinationAccount.Name = "txt_destinationAccount";
            this.txt_destinationAccount.Size = new System.Drawing.Size(203, 22);
            this.txt_destinationAccount.TabIndex = 10;
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(258, 300);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(203, 22);
            this.txt_amount.TabIndex = 11;
            // 
            // btn_showDetails
            // 
            this.btn_showDetails.Location = new System.Drawing.Point(574, 119);
            this.btn_showDetails.Name = "btn_showDetails";
            this.btn_showDetails.Size = new System.Drawing.Size(127, 23);
            this.btn_showDetails.TabIndex = 12;
            this.btn_showDetails.Text = "Show Details";
            this.btn_showDetails.UseVisualStyleBackColor = true;
            this.btn_showDetails.Click += new System.EventHandler(this.btn_showDetails_Click);
            // 
            // btn_transferAccount
            // 
            this.btn_transferAccount.Location = new System.Drawing.Point(258, 366);
            this.btn_transferAccount.Name = "btn_transferAccount";
            this.btn_transferAccount.Size = new System.Drawing.Size(127, 23);
            this.btn_transferAccount.TabIndex = 13;
            this.btn_transferAccount.Text = "Transfer Account";
            this.btn_transferAccount.UseVisualStyleBackColor = true;
            this.btn_transferAccount.Click += new System.EventHandler(this.btn_transferAccount_Click);
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_transferAccount);
            this.Controls.Add(this.btn_showDetails);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.txt_destinationAccount);
            this.Controls.Add(this.txt_currentAmount);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_fromAccountNumber);
            this.Controls.Add(this.lbl_amount);
            this.Controls.Add(this.lbl_destinationAccount);
            this.Controls.Add(this.lbl_currentAmount);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_formAccountNumber);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl1);
            this.Name = "TransferForm";
            this.Text = "TransferForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_formAccountNumber;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_currentAmount;
        private System.Windows.Forms.Label lbl_destinationAccount;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.TextBox txt_fromAccountNumber;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_currentAmount;
        private System.Windows.Forms.TextBox txt_destinationAccount;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Button btn_showDetails;
        private System.Windows.Forms.Button btn_transferAccount;
    }
}