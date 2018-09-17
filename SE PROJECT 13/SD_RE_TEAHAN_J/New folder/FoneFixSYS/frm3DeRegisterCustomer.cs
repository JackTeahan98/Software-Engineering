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
    public partial class frm3DeRegisterCustomer : Form
    {
        public frm3DeRegisterCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text.All(Char.IsDigit))
            {
                MessageBox.Show("No Numeric Values, or empty text, Names only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerName.Focus();
                return;
            }



            else if (!txtCustomerName.Text.All(Char.IsDigit))
            {
                frm3DeRegisterCustomerSelect drc = new frm3DeRegisterCustomerSelect();
                drc.Show();
                this.Close();
            }
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Hide();
        }
    }
}
