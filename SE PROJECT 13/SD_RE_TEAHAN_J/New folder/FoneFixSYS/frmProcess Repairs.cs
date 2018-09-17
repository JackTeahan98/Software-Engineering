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
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm7LogRepair lr = new frm7LogRepair();
            lr.Show();
            this.Close();
        }

        private void btnCancelRepair_Click(object sender, EventArgs e)
        {
            frm8CancelRepair dr = new frm8CancelRepair();
            dr.Show();
            this.Close();
        }

        private void btnCompleteRepair_Click(object sender, EventArgs e)
        {
            frm9CompleteRepair cr = new frm9CompleteRepair();
            cr.Show();
            this.Hide();
        }

        private void btnReplenishStock_Click(object sender, EventArgs e)
        {
            frm91ReplenishStockID rsi = new frm91ReplenishStockID();
            rsi.Show();
            this.Hide();
        }
    }
}
