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
    public partial class CreditForm : Form
    {
        public CreditForm()
        {
            InitializeComponent();
            loaddate();
            loadmode();
        }

        private void loadmode()
        {
            //throw new NotImplementedException();
            box_mode.Items.Add("Cash");
            box_mode.Items.Add("Chque");
        }

        private void loaddate()
        {

            //throw new NotImplementedException();
            lbl_date.Text = DateTime.UtcNow.ToString("MM/dd/yyyy");
        }

        private void btn_update_Click (object sender, EventArgs e)
        {
            BankingEntities context = new BankingEntities();
            newAccount acc = new newAccount();
            Deposit dp = new Deposit();
            dp.Date = lbl_date.Text;
            dp.AccountNo = Convert.ToDecimal(txt_enterAccountNumber.Text);
            dp.Name = txt_name.Text;
            dp.OldBalance = Convert.ToDecimal(txt_oldBalance.Text);
            dp.Mode = box_mode.SelectedItem.ToString();
            dp.DipAmonut = Convert.ToDecimal(txt_depositAmonut.Text);
            context.Deposit.Add(dp);
            context.SaveChanges();
            decimal b = Convert.ToDecimal(txt_enterAccountNumber.Text);
            var item = (from u in context.userAccount
                        where u.Account_No == b
                        select u).FirstOrDefault();
            
            item.balance = item.balance + Convert.ToDecimal(txt_depositAmonut.Text);
            context.SaveChanges();
            MessageBox.Show("Deposit Money Sucefully");

        }

        private void btn_getDetails_Click(object sender, EventArgs e)
        {
            BankingEntities context = new BankingEntities();
            decimal b = Convert.ToDecimal(txt_enterAccountNumber.Text);
            var item = (from u in context.userAccount
                        where u.Account_No == b
                        select u).FirstOrDefault();
            txt_name.Text = item.Name;
            txt_oldBalance.Text = Convert.ToString(item.balance);
        }
    }
}
