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
    public partial class CustomerList : Form
    {
        public CustomerList()
        {
            InitializeComponent();
            bindgrid();
            
        }

        private void bindgrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            BankingEntities bs = new BankingEntities();
            var item = bs.userAccount.ToList();
            dataGridView1.DataSource = item;

            //throw new NotImplementedException();
        }
    }
}
