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
    public partial class ReplenishStockform : Form
    {
        public ReplenishStockform()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process_Repairs pr = new Process_Repairs();
            pr.Show();
            this.Close();
        }
    }
}
