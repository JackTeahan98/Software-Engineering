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
    public partial class frm5UpdateStock : Form
    {
        public frm5UpdateStock()
        {
            InitializeComponent();
        }

        private void UpdateStock_Load(object sender, EventArgs e)
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
            if (txtStockName.Text.Equals(""))
            {
                MessageBox.Show("Field Must Not Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStockName.Focus();
                return;
            }
            else if (txtStockType.Text.Equals(""))
            {
                MessageBox.Show("Field Must Not Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStockName.Focus();
                return;
            }

            else if (txtStockType.Text.Equals(""))
            {
                MessageBox.Show("Field Must Not Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStockName.Focus();
                return;
            }
            else if (txtStockQuantity.Text.Equals(""))
            {
                MessageBox.Show("Field Must Not Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStockName.Focus();
                return;
            }




            else if (txtStockName.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Field Must Not Be numeric only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStockName.Focus();
                txtStockName.Text = "";
                return;
            }
            else if (txtStockType.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Field Must Not Be numeric only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStockType.Focus();
                txtStockType.Text = "";
                return;
            }
            else if (!txtStockQuantity.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Field Must Be numeric only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStockQuantity.Focus();
                txtStockQuantity.Text = "";
                return;
            }
            else if (!txtStockPrice.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Field Must Be numeric only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStockPrice.Focus();
                txtStockPrice.Text = "";
                return;
            }

            MessageBox.Show("Item Succesffully Updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);


            MainMenu mm= new MainMenu();
            mm.Show();
            this.Close();
        }
    }
}
