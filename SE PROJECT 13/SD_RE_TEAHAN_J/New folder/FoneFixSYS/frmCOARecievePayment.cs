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
    public partial class frmCOARecievePayment : Form
    {
        public frmCOARecievePayment()
        {
            InitializeComponent();
        }

        private void btnBackButton_Click(object sender, EventArgs e)
        {
            //Back button form
            frmMainMenu mm = new frmMainMenu();
            mm.Show();
            this.Hide();
        }

     

        private void btnSubmitCustomerID_Click(object sender, EventArgs e)
        {
            //Validation
            //Regex formats
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
            string status2 = "'ISSUE INVOICE'";

            Repair rep = new Repair();
            DataSet ds = new DataSet();
            //Get repair details
            grdRepairs.DataSource = Repair.getCustomerRepair(ds, Convert.ToInt32(grdAllCustomer.Rows[grdAllCustomer.CurrentCell.RowIndex].Cells[0].Value),status2).Tables["ss"];
            
            //if repair grid is empty, givve warning message
            if (grdRepairs.RowCount == 0)
            {
                grpRepairsDone.Visible = false;
                MessageBox.Show("* * * WARNING * * * \n--------------------------------------------------------------\nCustomer has No COMPLETED Repairs, awaiting PAYMENT...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (repairStatus == "ISSUE INVOICE")
            {
                //Fill labels with repair details
                lblTotalCostFill.Text = Repair.getRepairPayment(Convert.ToInt32(grdAllCustomer.Rows[grdAllCustomer.CurrentCell.RowIndex].Cells[0].Value),Convert.ToInt32(grdRepairs.Rows[grdRepairs.CurrentCell.RowIndex].Cells[0].Value)).ToString();
                lblTotalCost.Visible = true;
                lblTotalCostFill.Visible = true;
                btnIssueInvoice.Visible = true;

            }
        }

        private void frmCOARecievePayment_Load(object sender, EventArgs e)
        {
            //Gets next payment ID
            txtPaymentID.Text = Payments.nextPaymentID().ToString("0000");

            //Sets up a grid with all customers
            grdAllCustomer.AllowUserToAddRows = false;
            grdRepairs.AllowUserToAddRows = false;
            DataSet DataSet = new DataSet();
            grdAllCustomer.DataSource = Customer.getAllCustomers(DataSet).Tables["ss"];
        }

        private void btnIssueInvoice_Click(object sender, EventArgs e)
        {
            grpRepairsDone.Visible = false;

            //Gets current date
            string d = DateTime.Now.ToString("d-MMM-yyyy");

            //Adds a payment to payments table
            Payments p = new Payments(Int32.Parse(txtPaymentID.Text), Int32.Parse(lblTotalCostFill.Text),d, Int32.Parse(lblCustomerID.Text));
            p.addPayment();

            //Confirmation msg
            MessageBox.Show("PAYMENT RECIEVED\n-------------------\nBALANCE UPDATED", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            //stores status value
            string status = "'PAID'";

            //Getting repair and customer ID
            int cno = Convert.ToInt32(grdAllCustomer.Rows[grdAllCustomer.CurrentCell.RowIndex].Cells[0].Value);
            int rno = Convert.ToInt32(grdRepairs.Rows[grdRepairs.CurrentCell.RowIndex].Cells[0].Value);

            //Updates customer balance and repair status
            Repair rep = new Repair();
            Repair.updateCustomerBalance(Convert.ToInt32(lblCostFill.Text), Convert.ToInt32(lblCustomerID.Text));
            rep.updateRepairStatusPAYMENT(Convert.ToInt32(cno), Convert.ToInt32(rno), status);
            DataSet DataSet = new DataSet();
            grdAllCustomer.DataSource = Customer.getAllCustomers(DataSet).Tables["ss"];
            string status2 = "'ISSUE INVOICE'";

            
            DataSet ds = new DataSet();
            grdRepairs.DataSource = Repair.getCustomerRepair(ds, Convert.ToInt32(grdAllCustomer.Rows[grdAllCustomer.CurrentCell.RowIndex].Cells[0].Value),status2).Tables["ss"];

            txtPaymentID.Text = Payments.nextPaymentID().ToString("0000");
        }
    }
}
