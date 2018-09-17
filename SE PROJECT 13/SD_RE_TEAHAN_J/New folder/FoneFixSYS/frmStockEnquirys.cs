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
    public partial class frmStockEnquirys : Form
    {
        public frmStockEnquirys()
        {
            InitializeComponent();
        }

        private void StockEnquiry_Load(object sender, EventArgs e)
        {
            grdAllStock.AllowUserToAddRows = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Back button form
            frmMainMenu mm = new frmMainMenu();
            mm.Show();
            this.Close();
        }

        private void btnSubmitCustomerID_Click(object sender, EventArgs e)
        {
            //Validation

            Regex characterNumberVal = new Regex("^[a-zA-Z0-9 ]*$");


            ///////////////////////////GetName///////////////////////////
           
            if (!characterNumberVal.IsMatch(txtNameEntered.Text))
            {
                MessageBox.Show("Name must not contain symbols, Letters and Numbers only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNameEntered.Focus();
                txtNameEntered.Text = "";
                return;
            }

            //loads grid with all stock by name
            Stock stock = new Stock();
            DataSet ds = new DataSet();
            grdAllStock.DataSource = Stock.getAllStockByName(ds,txtNameEntered.Text.ToString()).Tables["ss"];


            grdAllStock.Visible = true;

            //If grid is empty, close
            if (grdAllStock.RowCount == 0)
            {
                grdAllStock.Visible = false;
                DialogResult result = MessageBox.Show("* * * WARNING * * * \n\n--------------------------------------------------------------\n\nNo Stock with this name have been ADDED to allow ENQUIRY...\n\n--------------------------------------------------------------\n\nWould you like to ADD Stock?", "Warning",
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


       

        private void grdAllStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grpBoxDetails.Visible = true;
           


            //find stock details
            Stock updStock = new Stock();
            updStock.getStock(Convert.ToInt32(grdAllStock.Rows[grdAllStock.CurrentCell.RowIndex].Cells[0].Value));

            if (updStock.getStockID().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            //display Stock details
            txtStockID.Text = updStock.getStockID().ToString();
            txtStockName.Text = updStock.getStockName();
            txtStockType.Text = updStock.getStockType();
            txtStockPrice.Text = updStock.getStockPrice().ToString();
            txtStockQuantity.Text = updStock.getStockQuantity().ToString();
        }

        private void grpBoxDetails_Enter(object sender, EventArgs e)
        {

        }

        private void grdAllStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNameEntered_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
