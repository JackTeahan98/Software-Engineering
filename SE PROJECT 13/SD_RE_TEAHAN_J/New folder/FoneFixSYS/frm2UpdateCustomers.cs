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
    public partial class UpdateCustomers : Form
    {
        public UpdateCustomers()
        {
            InitializeComponent();
        }

        private void UpdateCustomers_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (txtCustomerSurname.Text.Equals(""))
            {
                MessageBox.Show("Field Must Not Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerSurname.Focus();
                return;
            }
            else if (txtCustomerForeName.Text.Equals(""))
            {
                MessageBox.Show("Field Must Not Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerForeName.Focus();
                return;
            }
            else if (txtCustomerPhone.Text.Equals(""))
            {
                MessageBox.Show("Field Must Not Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerPhone.Focus();
                return;
            }
            else if (txtCustomerEmail.Text.Equals(""))
            {
                MessageBox.Show("Field Must Not Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerEmail.Focus();
                return;
            }
            else if (txtCustomerStreet.Text.Equals(""))
            {
                MessageBox.Show("Field Must Not Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerStreet.Focus();
                return;
            }
            else if (txtCustomerTown.Text.Equals(""))
            {
                MessageBox.Show("Field Must Not Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerTown.Focus();
                return;
            }
            else if (txtCustomerCounty.Text.Equals(""))
            {
                MessageBox.Show("Field Must Not Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerCounty.Focus();
                return;
            }
            else if (txtCustomerEircode.Text.Equals(""))
            {
                MessageBox.Show("Field Must Not Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerEircode.Focus();
                return;
            }

            else if (txtCustomerSurname.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Field Must Not Be numeric only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerSurname.Focus();
                txtCustomerSurname.Text = "";
                return;
            }
            else if (txtCustomerForeName.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Field Must Not Be numeric only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerForeName.Focus();
                txtCustomerForeName.Text = "";
                return;
            }

            else if (txtCustomerEmail.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Field Must Not Be numeric only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerEmail.Focus();
                txtCustomerEmail.Text = "";
                return;
            }
            else if (txtCustomerStreet.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Field Must Not Be numeric only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerStreet.Focus();
                txtCustomerStreet.Text = "";
                return;
            }
            else if (txtCustomerTown.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Field Must Not Be numeric only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerTown.Focus();
                txtCustomerTown.Text = "";
                return;
            }
            else if (txtCustomerCounty.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Field Must Not Be numeric only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerCounty.Focus();
                txtCustomerCounty.Text = "";
                return;
            }
            else if (txtCustomerEircode.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Field Must Not Be numeric only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerEircode.Focus();
                txtCustomerEircode.Text = "";
                return;
            }


            MessageBox.Show("Customer Succesffully Updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);


            //reset UI
           
            txtCustomerSurname.Text = "";
            txtCustomerForeName.Text = "";
            txtCustomerPhone.Text = "";
            txtCustomerEmail.Text = "";
            txtCustomerStreet.Text = "";
            txtCustomerTown.Text = "";
            txtCustomerCounty.Text = "";
            txtCustomerEircode.Text = "";


            MainMenu mm = new MainMenu();
            mm.Show();
            this.Close();


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Close();
        }
    }
}
