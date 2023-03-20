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
    public partial class UpdationForm : Form
    {
        BankingEntities dbe;
        MemoryStream ms;
        BindingList<userAccount> bi;

        public UpdationForm()
        {
            InitializeComponent();
        }

        private void btn_Details_Click(object sender, EventArgs e)
        {
            bi = new BindingList<userAccount>();
            dbe = new BankingEntities();
            decimal accon = Convert.ToDecimal(txt_accountNo.Text);
            var item = dbe.userAccount.Where(a=>a.Account_No == accon);
            foreach (var item1 in item)
            {
                bi.Add(item1);
            }
            dataGridView1.DataSource = bi;

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            bi = new BindingList<userAccount>();
            dbe = new BankingEntities();
            var item = dbe.userAccount.Where(a => a.Name == txt_name.Text);
            foreach (var item1 in item)
            {
                bi.Add(item1);
            }
            dataGridView1.DataSource = bi;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dbe = new BankingEntities();
            decimal accno = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            var item = dbe.userAccount.Where(a => a.Account_No == accno).FirstOrDefault();
            txt_accountNo.Text = item.Account_No.ToString();
            txt_name.Text = item.Name;
            txt_motherName.Text = item.Mother_Name;
            txt_fatherName.Text = item.Father_Name;
            txt_phoneNo.Text = item.PhoneNo;
            txt_Address.Text = item.Address;
            byte[] img = item.Picture;
            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);
            txt_District.Text = item.District;
            txt_state.Text = item.State;
            if (item.Gender=="male")
            {
                rad_male.Checked = true;
            }
            else if (item.Gender == "female")
            {
                rad_female.Checked = true;
            }
            else if (item.Gender == "other")
            {
                rad_other.Checked = true;
            }
            if (item.martial_status == "married")
            {
                rad_married.Checked = true;
            }
            else if(item.martial_status == "unmarried")
            {
                rad_unMarried.Checked = true;
            }
        }

        private void btn_uploadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendlg = new OpenFileDialog();

            if (opendlg.ShowDialog()==DialogResult.OK)
            {
                Image img = Image.FromFile(opendlg.FileName);
                pictureBox1.Image=img;
                ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            bi.RemoveAt(dataGridView1.SelectedRows[0].Index);
            dbe = new BankingEntities();
            decimal a = Convert.ToDecimal(txt_accountNo.Text);
            userAccount acc = dbe.userAccount.First(s => s.Account_No.Equals(a));
            dbe.userAccount.Remove(acc);
            dbe.SaveChanges();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            dbe = new BankingEntities();
            decimal accountono = Convert.ToDecimal(txt_accountNo.Text);
            userAccount userAccount = dbe.userAccount.First(s => s.Account_No.Equals(accountono));
            userAccount.Account_No = Convert.ToDecimal(txt_accountNo.Text);
            userAccount.Name = txt_name.Text;
            userAccount.Date = dateTimePicker1.Value.ToString();
            userAccount.Mother_Name = txt_motherName.ToString();
            userAccount.Father_Name = txt_fatherName.ToString();
            userAccount.PhoneNo = txt_phoneNo.Text;
            if (rad_male.Checked == true)
            {
                userAccount.Gender = "male";
            }
            else
            {
                if(rad_female.Checked == true)
                
                    userAccount.Gender = "female";
                {
                    if (rad_married.Checked == true)
                    {
                        userAccount.martial_status = "married";

                    }
                    else
                    {
                        if (rad_unMarried.Checked == true)
                            userAccount.martial_status = "Un-Married";

                    }
                    Image img = pictureBox1.Image;
                    //if (img.RawFormat = null)
                    {
                        if (ms != null)
                        {
                            img.Save(ms, img.RawFormat);
                            userAccount.Picture = ms.ToArray();

                        }
                    }
                    userAccount.Address = txt_Address.Text;
                    userAccount.District = txt_District.Text;
                    userAccount.State = txt_state.Text;
                    dbe.SaveChanges();
                    MessageBox.Show("Record Updated");
                }
                

            }
        }
    }
}
