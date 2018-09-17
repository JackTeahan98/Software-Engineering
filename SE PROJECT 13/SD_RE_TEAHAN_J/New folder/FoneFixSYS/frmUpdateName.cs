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
    public partial class frmUpdateName : Form
    {
        public frmUpdateName()
        {
            InitializeComponent();
        }

        private void UpdateName_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (!txtCustomerID.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Numeric values only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerID.Focus();
                return;
            }

            else if(txtCustomerID.Text.Equals(""))
            {
                MessageBox.Show("Numeric values only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerID.Focus();
                return;
            }
           else if (txtCustomerID.Text.All(Char.IsDigit))
            {
                UpdateCustomers uc = new UpdateCustomers();
                uc.Show();
                this.Close();
            }

        }
    }
}
