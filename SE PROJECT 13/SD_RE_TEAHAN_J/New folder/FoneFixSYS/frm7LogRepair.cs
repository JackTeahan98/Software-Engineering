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
    public partial class frm7LogRepair : Form
    {
        public frm7LogRepair()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtPhoneSerialNumber.Text.Equals(""))
            {
                MessageBox.Show("Field Must Not Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneSerialNumber.Focus();
                return;
            }
        else if (!txtPhoneSerialNumber.Text.All(Char.IsDigit))
            { 
                MessageBox.Show("Field Must be numeric only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneSerialNumber.Focus();
                txtPhoneSerialNumber.Text = "";
                return;
            }
            else if (txtCustomerID.Text.Equals(""))
            {
                MessageBox.Show("Field Must Not Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerID.Focus();
                return;
            }
          else if (!txtCustomerID.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Field Must Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerID.Focus();
                txtCustomerID.Text = "";
                return;
            }
            else if (txtCustomerName.Text.Equals(""))
            {
                MessageBox.Show("Field Must Not Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerName.Focus();
                return;
            }
 else if (txtCustomerName.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Field Must Not Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerName.Focus();
                txtCustomerName.Text = "";
                return;
            }
            else if (String.IsNullOrEmpty(cbbDescription.Text))
            {
                MessageBox.Show("Please Select Cause of Repair", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        
            txtRepairID.Text = "1079";
            txtPhoneSerialNumber.Text = "";
            txtPassword.Text = "";
            txtCustomerID.Text = "";
            txtCustomerName.Text = "";
            txtDescription.Text = "Other...(Optional)";













            MessageBox.Show("Repair Added", "Success");

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
