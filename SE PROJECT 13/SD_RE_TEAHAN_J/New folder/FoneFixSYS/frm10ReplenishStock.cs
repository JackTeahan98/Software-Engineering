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
            MainMenu pr = new MainMenu();
            pr.Show();
            this.Close();
        }

        private void btnSubmitRepairID_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Parts Succesffuly Added to Used Parts File", "Added..", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MainMenu mm = new MainMenu();
            mm.Show();
            this.Close();

        }
    }
}
