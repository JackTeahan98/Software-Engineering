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
    public partial class frmCustomerUpdate : Form
    {
        public frmCustomerUpdate()
        {
            InitializeComponent();
        }

        private void UpdateCustomers_Load(object sender, EventArgs e)
        {
            //Fills grid with all customers
            DataSet ds = new DataSet();
            grdAllCustomers.DataSource = Customer.getAllCustomer(ds).Tables["ss"];
            grdAllCustomers.AllowUserToAddRows = false;
            grpBoxDetails.Visible = false;


            //if grid is empty, close
            if (grdAllCustomers.RowCount == 0)
            {
                DialogResult result = MessageBox.Show("* * * WARNING * * * \n\n--------------------------------------------------------------\n\nNo customers have been ADDED to allow UPDATE...\n\n--------------------------------------------------------------\n\nWould you like to ADD a customer?", "Warning",
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

        private void button4_Click(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {

            //Validation
            //Regex formats
            Regex phoneFormat = new Regex(@"\(?\d{3}\)?[-]? *\d{3}[-]? *[-]?\d{4}");
            Regex eircodeFormat = new Regex("^[a-zA-Z]{1}[0-9]{2}[a-zA-Z]{2}[0-9]{2}$");
            Regex emailFormat = new Regex(@"^(?("")("".+?(?<!\\)""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9][\-a-z-A-Z0-9]{0,22}[a-zA-Z0-9]))$");
            Regex characterVal = new Regex("^[a-zA-Z]*$");
            Regex characterNumberVal = new Regex("^[a-zA-Z0-9 ]*$");





            ////validate data
            ///////////////////////////Surname///////////////////////////
            if (txtCustomerSurname.Text.Equals(""))
            {
                MessageBox.Show("Field Must Not Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerSurname.Focus();
                txtCustomerSurname.Text = "";
                return;
            }
            else if (!characterVal.IsMatch(txtCustomerSurname.Text))
            {
                MessageBox.Show("Surname must not contain numbers, spaces or symbols, Letters only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerSurname.Focus();
                txtCustomerSurname.Text = "";
                return;
            }
            else if (txtCustomerSurname.Text.Length > 30)
            {
                MessageBox.Show("Name Too Long!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerSurname.Focus();
                txtCustomerSurname.Text = "";
                return;
            }



            ///////////////////////////Forename///////////////////////////
            else if (txtCustomerForeName.Text.Equals(""))
            {
                MessageBox.Show("Field Must Not Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerForeName.Focus();
                txtCustomerForeName.Text = "";
                return;
            }
            else if (!characterVal.IsMatch(txtCustomerForeName.Text))
            {
                MessageBox.Show("Forename must not contain numbers, spaces or symbols, Letters only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerForeName.Focus();
                txtCustomerForeName.Text = "";
                return;
            }
            else if (txtCustomerForeName.Text.Length > 30)
            {
                MessageBox.Show("Name Too Long!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerForeName.Focus();
                txtCustomerForeName.Text = "";
                return;
            }




            ///////////////////////////Phone Number///////////////////////////
            else if (txtCustomerPhone.Text.Equals(""))
            {
                MessageBox.Show("Field Must Not Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerPhone.Focus();
                txtCustomerPhone.Text = "";
                return;
            }
            else if (!phoneFormat.IsMatch(txtCustomerPhone.Text))
            {
                MessageBox.Show("Phone Number Format not correct!\n123 123 1234\n123-123-1234", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerPhone.Focus();
                txtCustomerPhone.Text = "";
                return;
            }
            else if (txtCustomerPhone.Text.Length > 12)
            {
                MessageBox.Show("Phone Number Too Long!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerPhone.Focus();
                txtCustomerPhone.Text = "";
                return;
            }




            ///////////////////////////Email///////////////////////////
            else if (txtCustomerEmail.Text.Equals(""))
            {
                MessageBox.Show("Field Must Not Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerEmail.Focus();
                txtCustomerEmail.Text = "";
                return;
            }
            else if (!emailFormat.IsMatch(txtCustomerEmail.Text))
            {
                MessageBox.Show("Not a proper Email Format\nPlease make ensure that an  '@'  and a  '.'  are present\nEXAMPLE:   123mail@gmail.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerEmail.Focus();
                txtCustomerEmail.Text = "";
                return;
            }
            else if (txtCustomerEmail.Text.Length > 30)
            {
                MessageBox.Show("Email Too Long!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerEmail.Focus();
                txtCustomerEmail.Text = "";
                return;
            }




            ///////////////////////////Street///////////////////////////
            else if (txtCustomerStreet.Text.Equals(""))
            {
                MessageBox.Show("Field Must Not Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerStreet.Focus();
                txtCustomerStreet.Text = "";
                return;
            }
            else if (!characterNumberVal.IsMatch(txtCustomerStreet.Text))
            {
                MessageBox.Show("Street must not contain symbols, Letters, numbers and spaces only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerStreet.Focus();
                txtCustomerStreet.Text = "";
                return;
            }
            else if (txtCustomerStreet.Text.Length > 20)
            {
                MessageBox.Show("Street Too Long!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerStreet.Focus();
                txtCustomerStreet.Text = "";
                return;
            }


            ///////////////////////////Town///////////////////////////
            else if (txtCustomerTown.Text.Equals(""))
            {
                MessageBox.Show("Field Must Not Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerTown.Focus();
                txtCustomerTown.Text = "";
                return;
            }
            else if (!characterVal.IsMatch(txtCustomerTown.Text))
            {
                MessageBox.Show("Town must not contain numbers, spaces or symbols, Letters only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerTown.Focus();
                txtCustomerTown.Text = "";
                return;
            }
            else if (txtCustomerTown.Text.Length > 20)
            {
                MessageBox.Show("Town Too Long!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerTown.Focus();
                txtCustomerTown.Text = "";
                return;
            }



            ///////////////////////////County///////////////////////////
            else if (txtCustomerCounty.Text.Equals(""))
            {
                MessageBox.Show("Field Must Not Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerCounty.Focus();
                txtCustomerCounty.Text = "";
                return;
            }
            else if (!characterVal.IsMatch(txtCustomerCounty.Text))
            {
                MessageBox.Show("County must not contain numbers, spaces or symbols, Letters only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerCounty.Focus();
                txtCustomerCounty.Text = "";
                return;
            }
            else if (txtCustomerCounty.Text.Length > 20)
            {
                MessageBox.Show("County Too Long!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerCounty.Focus();
                txtCustomerCounty.Text = "";
                return;
            }



            ///////////////////////////Eircode///////////////////////////
            else if (txtCustomerEircode.Text.Equals(""))
            {
                MessageBox.Show("Field Must Not Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerEircode.Focus();
                txtCustomerEircode.Text = "";
                return;
            }
            else if (!eircodeFormat.IsMatch(txtCustomerEircode.Text))
            {
                MessageBox.Show("Eircode Invalid!\nV15GH76\nG36AD54\nQ77QW12", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerEircode.Focus();
                txtCustomerEircode.Text = "";
                return;
            }
            else if (txtCustomerEircode.Text.Length > 10)
            {
                MessageBox.Show("Eircode Too Long!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerEircode.Focus();
                txtCustomerEircode.Text = "";
                return;
            }





            //instantiate Customer Object
            Customer cust = new Customer();
            cust.setCustomerID(Convert.ToInt32(grdAllCustomers.Rows[grdAllCustomers.CurrentCell.RowIndex].Cells[0].Value));
            cust.setCustomerForename(txtCustomerForeName.Text);
            cust.setCustomerSurname(txtCustomerSurname.Text);
            cust.setCustomerPhoneNumber(txtCustomerPhone.Text);
            cust.setCustomerEmail(txtCustomerEmail.Text);
            cust.setCustomerStreet(txtCustomerStreet.Text);
            cust.setCustomerTown(txtCustomerTown.Text);
            cust.setCustomerCounty(txtCustomerCounty.Text);
            cust.setCustomerEirCode(txtCustomerEircode.Text);
           
        

            //UPDATE Customer record in Customers table
            cust.updateCustomer();

            //Display Confirmation Message
            MessageBox.Show("Customer " + grdAllCustomers.Rows[grdAllCustomers.CurrentCell.RowIndex].Cells[1].Value + " Updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);


            //reset UI

            txtCustomerSurname.Text = "";
            txtCustomerForeName.Text = "";
            txtCustomerPhone.Text = "";
            txtCustomerEmail.Text = "";
            txtCustomerStreet.Text = "";
            txtCustomerTown.Text = "";
            txtCustomerCounty.Text = "";
            txtCustomerEircode.Text = "";
           
            DataSet ds = new DataSet();
        
            grdAllCustomers.DataSource = Customer.getAllCustomer(ds).Tables["ss"];


            grpBoxDetails.Visible = false;

        }



        

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmMainMenu mm = new frmMainMenu();
            mm.Show();
            this.Close();
        }

        private void lblHeader_Click(object sender, EventArgs e)
        {

        }

        private void grdAllCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //check that Customer number is entered
            grpBoxDetails.Visible = true;

            //find Customer details
            Customer cust = new Customer();
            cust.getCustomer(Convert.ToInt32(grdAllCustomers.Rows[grdAllCustomers.CurrentCell.RowIndex].Cells[0].Value));

            if (cust.getCustomerID().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            //display Customer details
            txtCustomerForeName.Text = cust.getCustomerForename().ToString();
            txtCustomerSurname.Text = cust.getCustomerSurname();
            txtCustomerPhone.Text = cust.getCustomerPhoneNumberD();
            txtCustomerEmail.Text = cust.getCustomerEmail().ToString();
            txtCustomerStreet.Text = cust.getCustomerStreet();
            txtCustomerTown.Text = cust.getCustomerTown();
            txtCustomerCounty.Text = cust.getCustomerCounty();
            txtCustomerEircode.Text = cust.getCustomerEirCode();
           
            
            grpBoxDetails.Visible = true;
        }

        private void grpBoxDetails_Enter(object sender, EventArgs e)
        {

        }

        private void lblCustomerStreet_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomerTown_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
