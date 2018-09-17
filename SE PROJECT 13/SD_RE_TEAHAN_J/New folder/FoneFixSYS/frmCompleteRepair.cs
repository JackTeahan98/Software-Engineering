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
    public partial class frmCompleteRepair : Form
    {
        public frmCompleteRepair()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!txtRepairID.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Numeric values only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRepairID.Focus();
                return;
            }

            else if (txtRepairID.Text.Equals(""))
            {
                MessageBox.Show("Numeric values only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRepairID.Focus();
                return;
            }
            else if (txtRepairID.Text.All(Char.IsDigit))
            {
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Close();
                
            }

            
        }

        private void txtRepairID_TextChanged(object sender, EventArgs e)
        {
 
        }
    }
}
