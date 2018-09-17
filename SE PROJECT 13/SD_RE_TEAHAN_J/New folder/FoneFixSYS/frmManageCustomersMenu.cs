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
    public partial class ManageCustomersMenu : Form
    {
        public ManageCustomersMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm1AddCustomer ac = new frm1AddCustomer();
            ac.Show();
            this.Close(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm2UpdateCustomerID un = new frm2UpdateCustomerID();
            un.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm3DeRegisterCustomer cd = new frm3DeRegisterCustomer();
            cd.Show();
            this.Close();
        }
    }
}
