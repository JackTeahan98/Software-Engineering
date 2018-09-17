using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoneFixSYS
{
    public partial class frmStockNew : Form
    {
        public frmStockNew()
        {
            InitializeComponent();
        }

        private void NewStock_Load(object sender, EventArgs e)
        {
            //Sets the stock ID
            txtStockID.Text = Stock.nextStockID().ToString("0000");

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Back Button form
            ManageStock ms = new ManageStock();
            ms.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Validation

            Regex characterVal = new Regex("^[a-zA-Z]*$");
            Regex characterNumberVal = new Regex("^[a-zA-Z0-9 ]*$");

           
            ///////////////////////////Name///////////////////////////
            if (txtStockName.Text.Equals(""))
            {
                MessageBox.Show("Field Must Not Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStockName.Focus();
                return;
            }
            else if (!characterNumberVal.IsMatch(txtStockName.Text))
            {
                MessageBox.Show("Name must not contain symbols, Letters and Numbers only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStockName.Focus();
                txtStockName.Text = "";
                return;
            }
            else if (txtStockName.Text.Length > 20)
            {
                MessageBox.Show("Name Too Long!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStockName.Focus();
                txtStockName.Text = "";
                return;
            }



            ///////////////////////////Type///////////////////////////
            else if (txtType.Text.Equals(""))
            {
                MessageBox.Show("Field Must Not Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtType.Focus();
                return;
            }
            else if (!characterVal.IsMatch(txtType.Text))
            {
                MessageBox.Show("Type must not contain symbols, numbers or spaces, Letters only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtType.Focus();
                txtType.Text = "";
                return;
            }
            else if (txtType.Text.Length > 20)
            {
                MessageBox.Show("Type Too Long!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtType.Focus();
                txtType.Text = "";
                return;
            }




            ///////////////////////////Price///////////////////////////
            else if (txtPrice.Text.Equals(""))
            {
                MessageBox.Show("Field Must Not Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                return;
            }
            else if (!txtPrice.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Positive, Whole numbers only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                txtPrice.Text = "";
                return;
            }
            else if (txtPrice.Text.Length > 5)
            {
                MessageBox.Show("Price too long!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                txtPrice.Text = "";
                return;
            }




            ///////////////////////////Quantity///////////////////////////
            else if (txtQuantity.Text.Equals(""))
            {
                MessageBox.Show("Field Must Not Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Focus();
                return;
            }
            else if (!txtQuantity.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Positive, Whole numbers only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Focus();
                txtQuantity.Text = "";
                return;
            }
            else if (txtQuantity.Text.Length > 5)
            {
                MessageBox.Show("Quantity too long!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Focus();
                txtQuantity.Text = "";
                return;
            }








            //Success message
            MessageBox.Show("Stock Added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Adds Stock
            Stock Stock = new Stock(Int32.Parse(txtStockID.Text), txtStockName.Text, txtType.Text, Decimal.Parse(txtPrice.Text), Int32.Parse(txtQuantity.Text));
            Stock.addStock();
            

            //reset UI
            txtStockID.Text = "";
            txtStockName.Text = "";
            txtType.Text = "";
            txtQuantity.Text = "";
            txtPrice.Text = "";
            txtStockID.Text = Stock.nextStockID().ToString("0000");

            txtStockName.Focus();
        }

        private void txtStockID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
