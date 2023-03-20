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
    public partial class ViewFD : Form
    {
        BindingList<FD> bl;
        BankingEntities dbe;

        public ViewFD()
        {
            InitializeComponent();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            bl = new BindingList<FD>();
            dbe = new BankingEntities();
            string date = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            MessageBox.Show(date);
            var item = dbe.FD.Where(a => a.Start_Date.Equals(date));
            dataGridView1.DataSource = item.ToList();

        }
    }
}
