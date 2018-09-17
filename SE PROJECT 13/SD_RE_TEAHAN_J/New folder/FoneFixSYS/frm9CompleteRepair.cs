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
    public partial class frm9CompleteRepair : Form
    {
        public frm9CompleteRepair()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtRepairID.Text.Equals(""))
            {
                MessageBox.Show("No Blank Spaces", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRepairID.Focus();
                return;
            }

           else if (txtRepairID.Text.All(Char.IsDigit))
            {
                MessageBox.Show("No Numeric values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRepairID.Focus();
                return;
            }

           
            else if (!txtRepairID.Text.All(Char.IsDigit))
            {
           
 frm9CompleteRepairSelect mm = new frm9CompleteRepairSelect();
            mm.Show();
            this.Close();
                
            }

            
        }

        private void txtRepairID_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void btnBackButton_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Hide();
        }
    }
}
