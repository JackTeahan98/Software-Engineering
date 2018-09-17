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
    public partial class frmCustomerDeregister : Form
    {
        public frmCustomerDeregister()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmMainMenu mm = new frmMainMenu();
            mm.Show();
            this.Hide();
        }

        private void frmCustomerDeregister_Load(object sender, EventArgs e)
        {
            //fills grid with all customers
            DataSet ds = new DataSet();
            grdAllCustomers.DataSource = Customer.getAllCustomer(ds).Tables["ss"];
            grdAllCustomers.AllowUserToAddRows = false;


            //if grid is empty, close
            if (grdAllCustomers.RowCount == 0)
            {
                DialogResult result = MessageBox.Show("* * * WARNING * * * \n\n--------------------------------------------------------------\n\nNo customers have been ADDED to allow DEREGISTER...\n\n--------------------------------------------------------------\n\nWould you like to ADD a customer?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                if (result == DialogResult.Yes)
                {
                    frmCustomerAdd ca = new frmCustomerAdd();
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCustomerDeRegister_Click(object sender, EventArgs e)
        {
            //ID must not be empty
            if (txtCustomerID.Text.Equals(""))
            {
                MessageBox.Show("Field Must Not Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerID.Focus();
                return;
            }

            //Customer obejct instantiation
            Customer cust = new Customer();
            
            cust.setCustomerID(Convert.ToInt32(grdAllCustomers.Rows[grdAllCustomers.CurrentCell.RowIndex].Cells[0].Value));
            cust.setCustomerStatus(cmbStatus.Text);

            //Updates customer status into customer table
            cust.updateCustomerStatus();

            if(cmbStatus.Text == "Active")
            {
                cust.setCustomerStatus("A");
            }
            else
            {
                cust.setCustomerStatus("D");
            }

            //Display Confirmation Message
            MessageBox.Show("Customer " + grdAllCustomers.Rows[grdAllCustomers.CurrentCell.RowIndex].Cells[1].Value + " Updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);


            //reset ui
            txtCustomerID.Text = "";
            cmbStatus.Text = "";
            DataSet ds = new DataSet();
            grdAllCustomers.DataSource = Customer.getAllCustomer(ds).Tables["ss"];


        }


        private void grdAllCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            


            //find cUSTOMER details
            Customer cust = new Customer();
            cust.getCustomer(Convert.ToInt32(grdAllCustomers.Rows[grdAllCustomers.CurrentCell.RowIndex].Cells[0].Value));

            if (cust.getCustomerID().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            //display Customer details
            txtCustomerID.Text = (Convert.ToInt32(grdAllCustomers.Rows[grdAllCustomers.CurrentCell.RowIndex].Cells[0].Value)).ToString();
            cmbStatus.Text = grdAllCustomers.Rows[grdAllCustomers.CurrentCell.RowIndex].Cells[11].Value.ToString();
     



        }

        private void lblCustomerStatus_Click(object sender, EventArgs e)
        {

        }

        private void grdAllCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
