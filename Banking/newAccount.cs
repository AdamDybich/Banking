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
            throw new NotImplementedException();
        }

        private void loadaccount()
        {
            BSE = new BankingEntities();
            var item = BSE.user
        }

        private void loaddate()
        {
            throw new NotImplementedException();
        }
    }
}
