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
    public partial class frmCustomerAdd : Form
    {
        public frmCustomerAdd()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Sets next customer ID
            txtCustId.Text = Customer.nextCustomerID().ToString("0000");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Back button form
            frmMainMenu mm = new frmMainMenu();
            mm.Show();
            this.Close();
        }





        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Validation
            //regex
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
            else if (txtCustomerSurname.Text.Length > 25)
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
            else if (txtCustomerForeName.Text.Length > 25)
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
            if (Customer.phoneExists(txtCustomerPhone.Text))
            {
                MessageBox.Show("Phone already exists in system!\nPlease make another", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerPhone.Focus();
                txtCustomerPhone.Text = "";
                return;
            }
            else if (txtCustomerPhone.Text.Length>12)
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
            if (Customer.emailExists(txtCustomerEmail.Text))
            {
                MessageBox.Show("Email already exists in system!\nPlease make another", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerEmail.Focus();
                txtCustomerEmail.Text = "";
                return;
            }
            else if (txtCustomerEmail.Text.Length > 25)
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
            else if (txtCustomerStreet.Text.Length > 19)
            {
                MessageBox.Show("Email Too Long!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else if (txtCustomerTown.Text.Length > 19)
            {
                MessageBox.Show("Email Too Long!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else if (txtCustomerCounty.Text.Length > 19)
            {
                MessageBox.Show("Email Too Long!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else if (txtCustomerEircode.Text.Length > 9)
            {
                MessageBox.Show("Email Too Long!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerEircode.Focus();
                txtCustomerEircode.Text = "";
                return;
            }





            //Gets the current date
            string d = DateTime.Now.ToString("d-MMM-yyyy");

          //  instantiates and inserts date into customer table
            Customer customer = new Customer(Int32.Parse(txtCustId.Text), txtCustomerSurname.Text, txtCustomerForeName.Text, txtCustomerPhone.Text, txtCustomerEmail.Text, txtCustomerStreet.Text, txtCustomerTown.Text, txtCustomerCounty.Text, txtCustomerEircode.Text, 0, d, "A");
            customer.addCustomer();


         

            //display confirmation message
            MessageBox.Show("Customer Succesffully Added", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);


            //reset UI
            txtCustId.Text = "102";
            txtCustomerSurname.Text = "";
            txtCustomerForeName.Text = "";
            txtCustomerPhone.Text = "";
            txtCustomerEmail.Text = ""; 
            txtCustomerStreet.Text = "";
            txtCustomerTown.Text = "";
            txtCustomerCounty.Text = "";
            txtCustomerEircode.Text = "";
            txtCustId.Text = Customer.nextCustomerID().ToString("0000");

            txtCustomerSurname.Focus();



           
        }

        private void txtCustomerEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
