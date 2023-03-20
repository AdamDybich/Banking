using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking
{
    public partial class newAccount : Form
    {
        string gender = string.Empty;
        string m_status = string.Empty;
        decimal no;
        BankingEntities BSE;
        MemoryStream ms;
        
       
        public newAccount()
        {

            InitializeComponent();
            loaddate();
            loadaccount();
            loadstate();
        }

        private void loadstate()
        {
            //throw new NotImplementedException();
            box_state.Items.Add("Małopolska");
            box_state.Items.Add("Wielkopolska");
        }

        private void loadaccount()
        {
            BSE = new BankingEntities();
            var item = BSE.userAccount.ToArray();
            no = item.LastOrDefault().Account_No + 1;
            txt_accountNo.Text = Convert.ToString(no);
        }

        private void loaddate()
        {
            //throw new NotImplementedException();
            lbl_dateLabel.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (rad_male.Checked)
            {
                gender = "male";
            }
            else if (rad_female.Checked)
                {
                    gender = "female";
                }
            else if (rad_other.Checked)
            {
                gender = "other";
            }
            if (rad_married.Checked)
            {
                m_status = "married";
            }
            else if (rad_unmarried.Checked)
            {
                m_status = "unmarried";
            }

            BSE = new BankingEntities();
            userAccount acc = new userAccount();
            acc.Account_No = Convert.ToDecimal(txt_accountNo.Text);
            acc.Name = txt_name.Text;
            acc.DOB = dateTimePicker1.Value.ToString();
            acc.PhoneNo = txt_phoneNumber.Text;
            acc.Address = txt_address.Text;
            acc.District = txt_dist.Text;
            acc.State = box_state.SelectedItem.ToString();
            acc.Gender = gender;
            acc.martial_status = m_status;
            acc.Mother_Name = txt_motherName.Text;
            acc.Father_Name = txt_fatherName.Text;
            acc.balance = Convert.ToDecimal(txt_balance.Text);
            acc.Date = lbl_date.Text;
            acc.Picture = ms.ToArray();
            BSE.userAccount.Add(acc);
            BSE.SaveChanges();
            MessageBox.Show("File saved");



        }

        private void btn_uploadPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog opebdlg = new OpenFileDialog();
            if (opebdlg.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(opebdlg.FileName);
                pictureBox1.Image = img;
                ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
            }
        }
    }
}
