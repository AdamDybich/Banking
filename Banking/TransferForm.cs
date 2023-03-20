using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking
{
    public partial class TransferForm : Form
    {
        public TransferForm()
        {
            InitializeComponent();
            loaddate();

        }

        private void loaddate()
        {
            //throw new NotImplementedException();
            lbl_Date.Text = DateTime.UtcNow.ToString("MM/dd/yyyy");

        }

        private void btn_showDetails_Click(object sender, EventArgs e)
        {
            BankingEntities dbe = new BankingEntities();
            decimal b = Convert.ToDecimal(txt_fromAccountNumber.Text);
            var item = (from u in dbe.userAccount
                        where u.Account_No == b
                        select u).FirstOrDefault();
            txt_name.Text = item.Name;
            txt_currentAmount.Text = Convert.ToString(item.balance);
        }

        private void btn_transferAccount_Click(object sender, EventArgs e)
        {
            BankingEntities dbe = new BankingEntities();
            decimal b = Convert.ToDecimal(txt_fromAccountNumber.Text);
            var item = (from u in dbe.userAccount
                        where u.Account_No == b
                        select u).FirstOrDefault();
            decimal b1 = Convert.ToDecimal(item.balance);
            decimal totalbal = Convert.ToDecimal(txt_amount.Text);
            decimal transferacc = Convert.ToDecimal(txt_destinationAccount.Text);
            if (b1 > totalbal)
            {
                userAccount item2 = (from u in dbe.userAccount
                                     where u.Account_No == transferacc
                                     select u).FirstOrDefault();
                item2.balance = item2.balance + totalbal;
                item.balance = item.balance - totalbal;
                //dbe.SaveChanges();
                Transfer transfer = new Transfer();
                transfer.Account_No = Convert.ToDecimal(txt_fromAccountNumber.Text);
                transfer.ToTransfer = Convert.ToDecimal(txt_destinationAccount.Text);
                transfer.Date = DateTime.UtcNow.ToString();
                transfer.Name = txt_name.Text;
                transfer.balance = Convert.ToDecimal(txt_amount.Text);

                dbe.Transfer.Add(transfer);
                dbe.SaveChanges();
                MessageBox.Show("Transfer Money Sucessfully");

                        }
        }
    }
}
