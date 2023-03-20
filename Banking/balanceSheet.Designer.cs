namespace Banking
{
    partial class balanceSheet
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
            this.lbl_balanceSheet = new System.Windows.Forms.Label();
            this.txt_show = new System.Windows.Forms.TextBox();
            this.btn_show = new System.Windows.Forms.Button();
            this.dGV_debitDetails = new System.Windows.Forms.DataGridView();
            this.dGV_depositDetails = new System.Windows.Forms.DataGridView();
            this.dGV_transferDetails = new System.Windows.Forms.DataGridView();
            this.lbl_debitDetails = new System.Windows.Forms.Label();
            this.lbl_depositDetails = new System.Windows.Forms.Label();
            this.lbl_transferDetails = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_debitDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_depositDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_transferDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_balanceSheet
            // 
            this.lbl_balanceSheet.AutoSize = true;
            this.lbl_balanceSheet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_balanceSheet.Location = new System.Drawing.Point(51, 26);
            this.lbl_balanceSheet.Name = "lbl_balanceSheet";
            this.lbl_balanceSheet.Size = new System.Drawing.Size(182, 29);
            this.lbl_balanceSheet.TabIndex = 0;
            this.lbl_balanceSheet.Text = "Balance Sheet";
            // 
            // txt_show
            // 
            this.txt_show.Location = new System.Drawing.Point(31, 74);
            this.txt_show.Name = "txt_show";
            this.txt_show.Size = new System.Drawing.Size(241, 22);
            this.txt_show.TabIndex = 1;
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(313, 72);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(102, 23);
            this.btn_show.TabIndex = 2;
            this.btn_show.Text = "Show";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // dGV_debitDetails
            // 
            this.dGV_debitDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_debitDetails.Location = new System.Drawing.Point(31, 142);
            this.dGV_debitDetails.Name = "dGV_debitDetails";
            this.dGV_debitDetails.RowHeadersWidth = 51;
            this.dGV_debitDetails.RowTemplate.Height = 24;
            this.dGV_debitDetails.Size = new System.Drawing.Size(388, 252);
            this.dGV_debitDetails.TabIndex = 3;
            // 
            // dGV_depositDetails
            // 
            this.dGV_depositDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_depositDetails.Location = new System.Drawing.Point(425, 142);
            this.dGV_depositDetails.Name = "dGV_depositDetails";
            this.dGV_depositDetails.RowHeadersWidth = 51;
            this.dGV_depositDetails.RowTemplate.Height = 24;
            this.dGV_depositDetails.Size = new System.Drawing.Size(388, 252);
            this.dGV_depositDetails.TabIndex = 4;
            // 
            // dGV_transferDetails
            // 
            this.dGV_transferDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_transferDetails.Location = new System.Drawing.Point(819, 142);
            this.dGV_transferDetails.Name = "dGV_transferDetails";
            this.dGV_transferDetails.RowHeadersWidth = 51;
            this.dGV_transferDetails.RowTemplate.Height = 24;
            this.dGV_transferDetails.Size = new System.Drawing.Size(388, 252);
            this.dGV_transferDetails.TabIndex = 5;
            // 
            // lbl_debitDetails
            // 
            this.lbl_debitDetails.AutoSize = true;
            this.lbl_debitDetails.Location = new System.Drawing.Point(28, 114);
            this.lbl_debitDetails.Name = "lbl_debitDetails";
            this.lbl_debitDetails.Size = new System.Drawing.Size(84, 16);
            this.lbl_debitDetails.TabIndex = 6;
            this.lbl_debitDetails.Text = "Debit Details";
            // 
            // lbl_depositDetails
            // 
            this.lbl_depositDetails.AutoSize = true;
            this.lbl_depositDetails.Location = new System.Drawing.Point(422, 114);
            this.lbl_depositDetails.Name = "lbl_depositDetails";
            this.lbl_depositDetails.Size = new System.Drawing.Size(99, 16);
            this.lbl_depositDetails.TabIndex = 7;
            this.lbl_depositDetails.Text = "Deposit Details";
            // 
            // lbl_transferDetails
            // 
            this.lbl_transferDetails.AutoSize = true;
            this.lbl_transferDetails.Location = new System.Drawing.Point(816, 114);
            this.lbl_transferDetails.Name = "lbl_transferDetails";
            this.lbl_transferDetails.Size = new System.Drawing.Size(102, 16);
            this.lbl_transferDetails.TabIndex = 8;
            this.lbl_transferDetails.Text = "Transfer Details";
            // 
            // balanceSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 414);
            this.Controls.Add(this.lbl_transferDetails);
            this.Controls.Add(this.lbl_depositDetails);
            this.Controls.Add(this.lbl_debitDetails);
            this.Controls.Add(this.dGV_transferDetails);
            this.Controls.Add(this.dGV_depositDetails);
            this.Controls.Add(this.dGV_debitDetails);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.txt_show);
            this.Controls.Add(this.lbl_balanceSheet);
            this.Name = "balanceSheet";
            this.Text = "balanceSheet";
            ((System.ComponentModel.ISupportInitialize)(this.dGV_debitDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_depositDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_transferDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_balanceSheet;
        private System.Windows.Forms.TextBox txt_show;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.DataGridView dGV_debitDetails;
        private System.Windows.Forms.DataGridView dGV_depositDetails;
        private System.Windows.Forms.DataGridView dGV_transferDetails;
        private System.Windows.Forms.Label lbl_debitDetails;
        private System.Windows.Forms.Label lbl_depositDetails;
        private System.Windows.Forms.Label lbl_transferDetails;
    }
}