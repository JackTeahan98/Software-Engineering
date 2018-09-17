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
    public partial class frmReplenishStockIDForm : Form
    {
        public frmReplenishStockIDForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReplenishStockform rf = new ReplenishStockform();
            rf.Show();
            this.Close();
        }
    }
}
