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
            frmMainMenu mm = new frmMainMenu();
            mm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCustomerAdd ac = new frmCustomerAdd();
            ac.Show();
            this.Close(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCustomerUpdate cu = new frmCustomerUpdate();
            cu.Show();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmCustomerDeregister cd = new frmCustomerDeregister();
            cd.Show();
            this.Close();
        }
    }
}
