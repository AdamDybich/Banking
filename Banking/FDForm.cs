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
    public partial class FDForm : Form
    {
        public FDForm()
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
            lbl_Date.Text = DateTime.UtcNow.ToString("MM/dd/yyyy");

        }

        

        private void btn_save_Click(object sender, EventArgs e)
        {
            BankingEntities dbe = new BankingEntities();
            decimal accno = Convert.ToDecimal(txt_accountNo.Text);
            var accuonts = dbe.userAccount.Where(x => x.Account_No == accno).SingleOrDefault();
            FD fdform = new FD();
            fdform.Account_No = Convert.ToDecimal(txt_accountNo.Text);
            fdform.mode = box_mode.SelectedItem.ToString();
            fdform.Rupees = txt_rupees.Text;
            fdform.Peroid = Convert.ToInt32(txt_period.Text);
            fdform.Interest_rate = Convert.ToDecimal(txt_interest.Text);
            fdform.Start_Date = DateTime.UtcNow.ToString("MM/dd/yyyy");
            fdform.Maturity_Date = (DateTime.UtcNow.AddDays(Convert.ToInt32(txt_period.Text))).ToString("MM/dd/yyyy");
            fdform.Maturity_Amount = ((Convert.ToDecimal(txt_rupees.Text) * Convert.ToInt32(txt_period.Text)
                * Convert.ToDecimal(txt_interest.Text)) / (100 * 12 * 30)) + (Convert.ToDecimal(txt_rupees.Text));
            dbe.FD.Add(fdform);
            decimal amount = Convert.ToDecimal(txt_rupees.Text);
            decimal totalamount = Convert.ToDecimal(accuonts.balance);
            decimal fdammount = totalamount - amount;
            accuonts.balance = fdammount;
            dbe.SaveChanges();
            MessageBox.Show("FD Started Now");

        }
    }
}
