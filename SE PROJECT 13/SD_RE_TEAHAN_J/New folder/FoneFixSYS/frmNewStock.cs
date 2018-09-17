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
    public partial class frmNewStock : Form
    {
        public frmNewStock()
        {
            InitializeComponent();
        }

        private void NewStock_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManageStock ms = new ManageStock();
            ms.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Item Added...", "AddStock");

            ManageStock ms = new ManageStock();
            ms.Show();
            this.Close();
        }
    }
}
