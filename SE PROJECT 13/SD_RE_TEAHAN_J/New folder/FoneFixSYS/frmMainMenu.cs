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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageCustomersMenu mcm = new ManageCustomersMenu();
            mcm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageStock ms = new ManageStock();
            ms.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process_Repairs pr = new Process_Repairs();
            pr.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmCOAMainMenu coa = new frmCOAMainMenu();
            coa.Show();
            this.Hide();
        }
    }
}
