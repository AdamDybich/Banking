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
    public partial class Debitform : Form
    {
        public Debitform()
        {
            InitializeComponent();
            loadcombo();
            loaddate();

        }

        private void loaddate()
        {
            //throw new NotImplementedException();
            lbl_Date.Text = DateTime.UtcNow.ToString("MM/dd/yyyy");

        }

        private void loadcombo()
        {
            //throw new NotImplementedException();
            box_mode.Items.Add("Cash");
            box_mode.Items.Add("Chque");

            
        }

        private void Debitform_Load(object sender, EventArgs e)
        {

        }

        private void btn_getDetails_Click(object sender, EventArgs e)
        {
            BankingEntities dbe = new BankingEntities();
            decimal b = Convert.ToDecimal(txt_enterAccountNo.Text);
            var item = (from u in dbe.userAccount
                        where u.Account_No == b
                        select u).FirstOrDefault();
            txt_name.Text = item.Name;
            txt_oldBalance.Text = Convert.ToString(item.balance);

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            BankingEntities dbe = new BankingEntities();
            newAccount nacc = new newAccount();
            debit dp = new debit();
            dp.Date = lbl_Date.Text;
            dp.AccountNo = Convert.ToDecimal(txt_enterAccountNo.Text);
            dp.Name = txt_name.Text;
            dp.OldBalance = Convert.ToDecimal(txt_oldBalance.Text);
            dp.Mode = box_mode.SelectedItem.ToString();
            dp.DebAmonut = Convert.ToDecimal(txt_amount.Text);
            dbe.debit.Add(dp);
            dbe.SaveChanges();
            decimal b = Convert.ToDecimal(txt_enterAccountNo.Text);
            var item = (from u in dbe.userAccount
                        where u.Account_No == b
                        select u).FirstOrDefault();
            item.balance = item.balance - Convert.ToDecimal(txt_amount.Text);
            dbe.SaveChanges();
            MessageBox.Show("Debit Money");

        }

       
    }
}
