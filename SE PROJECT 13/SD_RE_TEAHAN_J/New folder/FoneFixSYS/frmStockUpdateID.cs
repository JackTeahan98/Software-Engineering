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
    public partial class frmStockUpdateID : Form
    {
        public frmStockUpdateID()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmUpdateStock us = new frmUpdateStock();
            us.Show();
            this.Close();
        }
    }
}
