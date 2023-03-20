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
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            BankingEntities dbe = new BankingEntities();
            if (txt_userName.Text!=String.Empty || txt_password.Text != String.Empty)
            {
                var user1 = dbe.Admin_Table.FirstOrDefault(a => a.UserName.Equals(txt_userName.Text));

                if (user1!=null)
                {
                    if (user1.Password.Equals(txt_password.Text))
                    {
                        Menu m1 = new Menu();
                        m1.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Password incorrect");
                    }
                }
                else
                {
                    MessageBox.Show("Null Value");
                }
            }
            else
            {
                MessageBox.Show("Please enter username and password");
            }
        }

        
    }
}
