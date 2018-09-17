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
    public partial class Process_Repairs : Form
    {
        public Process_Repairs()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmMainMenu mm = new frmMainMenu();
            mm.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRepairLog lr = new frmRepairLog();
            lr.Show();
            this.Close();
        }

        private void btnCancelRepair_Click(object sender, EventArgs e)
        {
            frmRepairCancel dr = new frmRepairCancel();
            dr.Show();
            this.Close();
        }

        private void btnCompleteRepair_Click(object sender, EventArgs e)
        {
            frmRepairComplete cr = new frmRepairComplete();
            cr.Show();
            this.Hide();
        }

        private void btnReplenishStock_Click(object sender, EventArgs e)
        {
            
        }
    }
}
