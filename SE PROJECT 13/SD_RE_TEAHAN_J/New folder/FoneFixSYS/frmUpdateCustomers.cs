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
    public partial class UpdateCustomers : Form
    {
        public UpdateCustomers()
        {
            InitializeComponent();
        }

        private void UpdateCustomers_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManageCustomersMenu mcm = new ManageCustomersMenu();
            mcm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Customer Succesffully Updated", "Updated");

            ManageCustomersMenu mcm = new ManageCustomersMenu();
            mcm.Show();
            this.Close();
        }
    }
}
