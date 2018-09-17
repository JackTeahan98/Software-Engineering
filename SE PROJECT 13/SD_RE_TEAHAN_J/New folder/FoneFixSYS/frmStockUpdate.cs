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
    public partial class frmStockUpdate : Form
    {
        public frmStockUpdate()
        {
            InitializeComponent();
        }

        private void UpdateStock_Load(object sender, EventArgs e)
        {
      
            //Loads All Stock
            DataSet ds = new DataSet();
            grdAllStock.DataSource = Stock.getAllStock(ds).Tables["ss"];
            grdAllStock.AllowUserToAddRows = false;

            //If grid is empty, close
            if (grdAllStock.RowCount == 0)
            {
                DialogResult result = MessageBox.Show("* * * WARNING * * * \n\n--------------------------------------------------------------\n\nNo Stock have been ADDED to allow UPDATE...\n\n--------------------------------------------------------------\n\nWould you like to ADD Stock?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                if (result == DialogResult.Yes)
                {
                    frmStockNew ca = new frmStockNew();
                    this.Close();
                    ca.Show();
                }
                else if (result == DialogResult.No)
                {
                    frmMainMenu mm = new frmMainMenu();
                    this.Close();
                    mm.Show();
                }


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Back button Form
            frmMainMenu mm = new frmMainMenu();
            mm.Show();
            this.Close(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Validation

            Regex characterVal = new Regex("^[a-zA-Z ]*$");
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
            else if (txtStockType.Text.Equals(""))
            {
                MessageBox.Show("Field Must Not Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStockType.Focus();
                return;
            }
            else if (!characterVal.IsMatch(txtStockType.Text))
            {
                MessageBox.Show("Type must not contain symbols, numbers or spaces, Letters only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStockType.Focus();
                txtStockType.Text = "";
                return;
            }
            else if (txtStockType.Text.Length > 20)
            {
                MessageBox.Show("Type Too Long!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStockType.Focus();
                txtStockType.Text = "";
                return;
            }




            ///////////////////////////Price///////////////////////////
            else if (txtStockPrice.Text.Equals(""))
            {
                MessageBox.Show("Field Must Not Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStockPrice.Focus();
                return;
            }
            else if (!txtStockPrice.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Positive, Whole numbers only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStockPrice.Focus();
                txtStockPrice.Text = "";
                return;
            }
            else if (txtStockPrice.Text.Length > 5)
            {
                MessageBox.Show("Price too long!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStockPrice.Focus();
                txtStockPrice.Text = "";
                return;
            }




            ///////////////////////////Quantity///////////////////////////
            else if (txtStockQuantity.Text.Equals(""))
            {
                MessageBox.Show("Field Must Not Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStockQuantity.Focus();
                return;
            }
            else if (!txtStockQuantity.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Positive, Whole numbers only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStockQuantity.Focus();
                txtStockQuantity.Text = "";
                return;
            }
            else if (txtStockQuantity.Text.Length > 5)
            {
                MessageBox.Show("Quantity too long!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStockQuantity.Focus();
                txtStockQuantity.Text = "";
                return;
            }


            //instantiate Stock Object
            Stock myStock = new Stock();
            myStock.setStockID(Convert.ToInt32(grdAllStock.Rows[grdAllStock.CurrentCell.RowIndex].Cells[0].Value));
            myStock.setStockName(txtStockName.Text);
            myStock.setStockType(txtStockType.Text);
            myStock.setStockPrice(Convert.ToInt32(txtStockPrice.Text));
            myStock.setStockQuantity(Convert.ToInt32(txtStockQuantity.Text));


            //INSERT Stock record into stock table
            myStock.updateStock();

            //Display Confirmation Message
            MessageBox.Show("Stock " + grdAllStock.Rows[grdAllStock.CurrentCell.RowIndex].Cells[1].Value + " Updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

       

           //reset UI
            txtStockName.Text = "";
            txtStockType.Text = "";
            txtStockPrice.Text = "";
            txtStockQuantity.Text = "";
            grdAllStock.ClearSelection();
            DataSet ds = new DataSet();
            grdAllStock.DataSource = Stock.getAllStock(ds).Tables["ss"];
            grpBox2.Visible = false;




           


           
           
        }

        private void txtStockName_TextChanged(object sender, EventArgs e)
        {

        }

     
        private void grdAllStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        
            

            //find stock details
            Stock updStock = new Stock();
            updStock.getStock(Convert.ToInt32(grdAllStock.Rows[grdAllStock.CurrentCell.RowIndex].Cells[0].Value));

            if (updStock.getStockID().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
                return;
            }

            //display Stock details
            txtStockName.Text = updStock.getStockName();
            txtStockType.Text = updStock.getStockType();
            txtStockPrice.Text = updStock.getStockPrice().ToString();
            txtStockQuantity.Text = updStock.getStockQuantity().ToString();
            grpBox2.Visible = true;
        }

      

        private void grdAllStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtStockType_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
