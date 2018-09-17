using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoneFixSYS
{
    public partial class frmCustDelete : Form
    {
        public frmCustDelete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Customer Succesffully Deleted","Deleted");

            ManageCustomersMenu mcm = new ManageCustomersMenu();
            mcm.Show();
            this.Close();
        }
    }
}
