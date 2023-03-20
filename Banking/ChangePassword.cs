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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btn_changePassword_Click(object sender, EventArgs e)
        {
            BankingEntities dbe = new BankingEntities();
            if (txt_oldPassword.Text != string.Empty ||
                txt_newPassword.Text != string.Empty ||
                txt_retypePassword.Text != string.Empty);
            {
                Admin_Table user1 = dbe.Admin_Table.FirstOrDefault(a => a.UserName.Equals(txt_userName.Text));

                if (user1 != null)
                {
                    if (user1.Password.Equals(txt_oldPassword.Text))
                    {
                        user1.Password = txt_newPassword.Text;
                        dbe.SaveChanges();
                        MessageBox.Show("Password Change Sucessfully");

                    }
                    else
                    {
                        MessageBox.Show("Password Incorrect");

                    }
                }
            }

        }
    }
}
