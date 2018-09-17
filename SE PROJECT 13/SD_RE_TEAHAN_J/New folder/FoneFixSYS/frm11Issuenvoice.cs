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
    public partial class frm11Issuenvoice : Form
    {
        public frm11Issuenvoice()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Close();
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Invoice has been Sent!", "Issue Invoice");
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Close();

        }
    }
}
