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
    public partial class frmAddCustomer : Form
    {
        public frmAddCustomer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //validate data
            if (txtCustomerSurname.Text.Equals(""))
            {
                MessageBox.Show("Customer Not Added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerSurname.Focus();
                return;
            }
            else if (txtCustomerForeName.Text.Equals(""))
            {
                MessageBox.Show("Customer Not Added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerForeName.Focus();
                return;
            }
            else if (txtCustomerPhone.Text.Equals(""))
            {
                MessageBox.Show("Customer Not Added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerPhone.Focus();
                return;
            }
            else if (txtCustomerEmail.Text.Equals(""))
            {
                MessageBox.Show("Customer Not Added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerEmail.Focus();
                return;
            }
            else if (txtCustomerStreet.Text.Equals(""))
            {
                MessageBox.Show("Customer Not Added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerStreet.Focus();
                return;
            }
            else if (txtCustomerTown.Text.Equals(""))
            {
                MessageBox.Show("Customer Not Added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerTown.Focus();
                return;
            }
            else if (txtCustomerCounty.Text.Equals(""))
            {
                MessageBox.Show("Customer Not Added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerCounty.Focus();
                return;
            }
            else if (txtCustomerEircode.Text.Equals(""))
            {
                MessageBox.Show("Customer Not Added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerEircode.Focus();
                return;
            }



            //assign default values

            //save data in customer file

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



            

            //MainMenu mm = new MainMenu();

           // mm.Show();
           // this.Close();
        }

     

        
    }
}
