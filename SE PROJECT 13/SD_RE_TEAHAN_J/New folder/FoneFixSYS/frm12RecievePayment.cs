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
    public partial class frm12RecievePayment : Form
    {
        public frm12RecievePayment()
        {
            InitializeComponent();
        }

        private void btnBackButton_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Hide();
        }

        private void btnRecievePayment_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Paymnent Recieved!", "recieved Paymnet", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MainMenu mm = new MainMenu();
            mm.Show();
            this.Hide();
                
        }
    }
}
