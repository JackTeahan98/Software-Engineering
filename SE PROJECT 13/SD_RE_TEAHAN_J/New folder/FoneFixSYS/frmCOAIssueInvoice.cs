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
    public partial class frmCOAIssueInvoice : Form
    {
        public frmCOAIssueInvoice()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Back button form
            frmMainMenu mm = new frmMainMenu();
            mm.Show();
            this.Close();
       
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmitCustomerID_Click(object sender, EventArgs e)
        {
            //Validation
            //regex format
            Regex characterVal = new Regex("^[a-zA-Z]*$");


            ///////////////////////////GetName///////////////////////////

            
            if (!characterVal.IsMatch(txtNameEntered.Text))
            {
                MessageBox.Show("Name must not contain symbols, numbers or spaces, Letters only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNameEntered.Focus();
                txtNameEntered.Text = "";
                return;
            }


            //Fills grid with all customer by name
            Customer cust = new Customer();
            DataSet DataSet = new DataSet();
            grdAllCustomer.DataSource = Customer.getAllCustomerByName(DataSet, txtNameEntered.Text.ToString()).Tables["ss"];
            grdAllCustomer.Visible = true;

            // if grid is empty, close
            if (grdAllCustomer.RowCount == 0)
            {
                grdAllCustomer.Visible = false;
                DialogResult result = MessageBox.Show("* * * WARNING * * * \n\n--------------------------------------------------------------\n\nNo Customers have been ADDED to view their REPAIRS...", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                

                if (result == DialogResult.OK)
                {

                    frmMainMenu ca = new frmMainMenu();
                    this.Close();
                    ca.Show();
                }

                     

            }
        }

        private void frmCOAIssueInvoice_Load(object sender, EventArgs e)
        {
            grdAllCustomer.AllowUserToAddRows = false;
            grdRepairs.AllowUserToAddRows = false;
           



        }

        private void grdAllCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Gets all customer details and displays them
            Customer cust = new Customer();
            cust.getCustomerInvoice(Convert.ToInt32(grdAllCustomer.Rows[grdAllCustomer.CurrentCell.RowIndex].Cells[0].Value));
            lblCustomerID.Text = cust.getCustomerID().ToString();
            lblSurname.Text = cust.getCustomerSurname();
            lblCustomerBalance.Text = cust.getCustomerBalance().ToString();
            lblPhoneNumber.Text = cust.getCustomerPhoneNumberD();
           
            //sets a string status value to ISSUE INVOICE
            string status1 = "'COMPLETED'";

            Repair rep = new Repair();
            DataSet ds = new DataSet();

            //Get repair details
            grdRepairs.DataSource = Repair.getCustomerRepair(ds, Convert.ToInt32(grdAllCustomer.Rows[grdAllCustomer.CurrentCell.RowIndex].Cells[0].Value), status1).Tables["ss"];

            //if repair grid is empty, givve warning message
            if (grdRepairs.RowCount == 0)
            { grpRepairsDone.Visible = false;
              MessageBox.Show("* * * WARNING * * * \n--------------------------------------------------------------\nCustomer has No COMPLETED Repairs, awaiting INVOICE...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //display a group box
            else { grpRepairsDone.Visible = true; }


            //hide some ui
            lblTotalCostFill.Text = "";
            grpRepairInfo.Visible = false;
            btnIssueInvoice.Visible = false;
            lblTotalCost.Visible = false;
            lblTotalCostFill.Visible = false;



            //Set column size in grid
            DataGridViewColumn column0 = grdRepairs.Columns[0];
            column0.Width = 60;

            DataGridViewColumn column1 = grdRepairs.Columns[1];
            column1.Width = 365;

            DataGridViewColumn column2 = grdRepairs.Columns[2];
            column2.Width = 50;

        }

        private void grpRepairsDone_Enter(object sender, EventArgs e)
        {

        }

        private void grdRepairs_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //Gets selected repair details
            Repair rep = new Repair();
            rep.getRepairInvoice(Convert.ToInt32(grdRepairs.Rows[grdRepairs.CurrentCell.RowIndex].Cells[0].Value));
            lblRepairIDFill.Text = rep.getRepairID().ToString();
            lblDescriptionFill.Text = rep.getDescription();
            lblCostFill.Text = rep.getCost().ToString();

            grpRepairInfo.Visible = true;
          
            
            //Sets a string value to the value in the grid at position 3
            string repairStatus = grdRepairs.Rows[grdRepairs.CurrentCell.RowIndex].Cells[3].Value.ToString();

            

            if(repairStatus == "COMPLETED")
            {
                //Fill labels with repair details
                lblTotalCostFill.Text = Repair.getRepairCost(Convert.ToInt32(grdAllCustomer.Rows[grdAllCustomer.CurrentCell.RowIndex].Cells[0].Value)).ToString();
                lblTotalCost.Visible = true;
                lblTotalCostFill.Visible = true;
                btnIssueInvoice.Visible = true;

            }

            else
            {
                MessageBox.Show("Please select a COMPLETED Repair to finish the Invoice \n----------------------------------------------------------\nPlease Wait For Repair to Complete", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }




        }

        private void grdAllCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdRepairs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {


        }
        private void btnIssueInvoice_Click(object sender, EventArgs e)
        {
            //Instantiate customer and repair object
            Customer cust = new Customer();
            Repair rep = new Repair();

            //Setting customer ID
            cust.setCustomerID(Convert.ToInt32(grdAllCustomer.Rows[grdAllCustomer.CurrentCell.RowIndex].Cells[0].Value));

            //calculating initial and after cost
            decimal totalCost   = Convert.ToDecimal(lblTotalCostFill.Text);
            decimal initialCost = Convert.ToDecimal(lblCustomerBalance.Text);

            //Sets balance to initial and total cost combined
            cust.setCustomerBalance(totalCost + initialCost);

            //get customer ID
            string cno = grdAllCustomer.Rows[grdAllCustomer.CurrentCell.RowIndex].Cells[0].Value.ToString(); ;
            

            //Updates customer balance and repair status
            cust.updateCustomerBalance();
            string status = "'ISSUE INVOICE'";
            rep.updateRepairStatusINVOICE(Convert.ToInt32(cno), status);



            Customer cust1 = new Customer();
            DataSet DataSet = new DataSet();

            //Gets all customers by name
            grdAllCustomer.DataSource = Customer.getAllCustomerByName(DataSet, txtNameEntered.Text.ToString()).Tables["ss"];

            MessageBox.Show("INVOICE SENT \n-------------------\nBALANCE UPDATED", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


            grpRepairInfo.Visible = false;
            grpRepairsDone.Visible = false;

          

          


        }

        private void lblSurname_Click(object sender, EventArgs e)
        {

        }

        private void lblCustomerID_Click(object sender, EventArgs e)
        {

        }

        private void txtIssueInvoice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
