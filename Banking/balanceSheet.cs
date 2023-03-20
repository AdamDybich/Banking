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
    public partial class balanceSheet : Form
    {
        public balanceSheet()
        {
            InitializeComponent();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            BankingEntities dbe = new BankingEntities();
            decimal b = Convert.ToDecimal(txt_show.Text);
            var item = (from u in dbe.debit
                        where u.AccountNo == b
                        select u);
            dGV_debitDetails.DataSource = item.ToList();
            var item1 = (from u in dbe.Deposit
                         where u.AccountNo==b
                         select u);
            dGV_depositDetails.DataSource = item1.ToList();
            var item2 = (from u in dbe.Transfer
                         where u.Account_No == b
                         select u);
            dGV_transferDetails.DataSource = item2.ToList();

        }
    }
}
