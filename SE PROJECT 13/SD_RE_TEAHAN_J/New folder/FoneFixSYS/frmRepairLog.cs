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
    public partial class frmRepairLog : Form
    {
        public frmRepairLog()
        {
            InitializeComponent();
        }

        private void frmRepairLog_Load(object sender, EventArgs e)
        {



            
            //Fills grid with customer repair details
            DataSet ds = new DataSet();
            grdgetRepairDetails.DataSource = Repair.getRepairDetails(ds).Tables["ss"];
            grdgetRepairDetails.AllowUserToAddRows = false;
            txtRepairID.Text = Repair.nextRepairID().ToString("0000");

            //if grid is empty, close
            if (grdgetRepairDetails.RowCount == 0)
            {
                DialogResult result = MessageBox.Show("* * * WARNING * * * \n\n--------------------------------------------------------------\n\nNo Customers have been ADDED to allow REPAIR...\n\n--------------------------------------------------------------\n\nWould you like to ADD a Customer?", "Warning",
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Back button form
            frmMainMenu mm = new frmMainMenu();
            mm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Validation

            Regex characterVal = new Regex("^[a-zA-Z]*$");
            Regex characterNumberVal = new Regex("^[a-zA-Z0-9 ]*$");


            //////////////////////////Serial//////////////////////////
            if (txtPhoneSerialNumber.Text.Equals(""))
            {
                MessageBox.Show("Field Must Not Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneSerialNumber.Focus();
                return;
            }
            else if (!txtPhoneSerialNumber.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Numbers only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneSerialNumber.Focus();
                txtPhoneSerialNumber.Text = "";
                return;
            }
            else if (txtPhoneSerialNumber.Text.Length > 20)
            {
                MessageBox.Show("Serial Number too long!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneSerialNumber.Focus();
                txtPhoneSerialNumber.Text = "";
                return;
            }





            //////////////////////////Password//////////////////////////
            else if (txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Phone password required, if there is none, then Specify NULL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }
            else if (!characterNumberVal.IsMatch(txtPassword.Text))
            {
                MessageBox.Show("Name must not contain symbols, Letters and Numbers only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                txtPassword.Text = "";
                return;
            }
            else if (txtPassword.Text.Length > 20)
            {
                MessageBox.Show("Name Too Long!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                txtPassword.Text = "";
                return;
            }






            //////////////////////////PhoneType(CBO)//////////////////////////
            else if (String.IsNullOrEmpty(cbophonetype.Text))
            {
                MessageBox.Show("Please Select Phone type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }




            //////////////////////////Description(CBO)//////////////////////////
            else if (String.IsNullOrEmpty(cbbDescription.Text))
            {
                MessageBox.Show("Please Select Cause of Repair", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }




            //////////////////////////Description(TXT)//////////////////////////
                       else if (!characterNumberVal.IsMatch(txtDescription.Text))
            {
                MessageBox.Show("Please enter a description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription.Focus();
                txtDescription.Text = "";
                return;
            }
            else if (txtDescription.Text.Length > 75)
            {
                MessageBox.Show("Description Too Long!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription.Focus();
                txtDescription.Text = "";
                return;
            }





            ///////////////////////////Cost///////////////////////////
            else if (txtCost.Text.Equals(""))
            {
                MessageBox.Show("Field Must Not Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCost.Focus();
                return;
            }
            else if (!txtCost.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Positive, Whole numbers only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCost.Focus();
                txtCost.Text = "";
                return;
            }
            else if (txtCost.Text.Length > 5)
            {
                MessageBox.Show("Price too long!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCost.Focus();
                txtCost.Text = "";
                return;
            }







            //Changes description if its empty
            else if (txtDescription.Text.Equals(""))
            {
                txtDescription.Text.Equals("No Details");
                return;
            }

            //Adds repair to system
            Repair repair = new Repair(Int32.Parse(txtRepairID.Text), txtPhoneSerialNumber.Text, txtPassword.Text, "In Progress", cbophonetype.Text + "  -  " + cbbDescription.Text + "  -  "+ txtDescription.Text, Int32.Parse(txtCustomerID.Text), Int32.Parse(txtCost.Text));
            repair.addRepair();

            //Display success message
            MessageBox.Show("Repair Added", "Success");

            //reset UI
            txtPhoneSerialNumber.Text = "";
            txtPassword.Text = "";
            txtCustomerID.Text = "";
            lblCustomerName.Text = "Select a Customer...";
            txtDescription.Text = "";
            txtRepairID.Text = Repair.nextRepairID().ToString("0000");
            cbophonetype.Text = "";
            cbbDescription.Text = "";

            grpRepairDetails.Visible = false;
            btnSubmit.Visible = false;


        }

        //Clears description on entering
        private void  txtDescription_Enter(object sender, EventArgs e)
        {
            if (txtDescription.Text.Trim() != "" || txtDescription.Text != null)

            {

                txtDescription.Text = "";

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            


            //find repair details
            Repair rep = new Repair();
            rep.getRepairDetails(Convert.ToInt32(grdgetRepairDetails.Rows[grdgetRepairDetails.CurrentCell.RowIndex].Cells[0].Value));
           
            //If no repair, display appropriate message
            if (rep.getRepairID().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            //Get string status value
            string status = grdgetRepairDetails.Rows[grdgetRepairDetails.CurrentCell.RowIndex].Cells[2].Value.ToString();


            //if status d, do not procede with repair
            if(status =="D")
            {
                grpRepairDetails.Visible = false;
                lblCustomerName.Text = "Select a Customer...";
                txtCustomerID.Text = "";
                MessageBox.Show("Member NOT ACTIVE \n-----------------------\nPlease activate "+ grdgetRepairDetails.Rows[grdgetRepairDetails.CurrentCell.RowIndex].Cells[1].Value + " to Log a Repair...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                

                return;
            }

            //display Repair details
            txtCustomerID.Text = rep.getCustomerID().ToString();
            lblCustomerName.Text = rep.getCustomerName();


            grpRepairDetails.Visible=true;
            btnSubmit.Visible = true;


        }

        private void txtRepairID_TextChanged(object sender, EventArgs e)
        {

        }

        private void grdgetRepairDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbbDescription_SelectedIndexChanged(object sender, EventArgs e)
        {
            //calculating price of repair based off multipliers of phone type, and repair cause

            double multiplyer = 1;

            if (cbophonetype.SelectedIndex == 0)
            {
                multiplyer = .8;
                    }
            if (cbophonetype.SelectedIndex == 1)
            {
                multiplyer = 1;
            }
            if (cbophonetype.SelectedIndex == 2)
            {
                multiplyer = .5;
            }
            if (cbophonetype.SelectedIndex == 3)
            {
                multiplyer = .7;
            }
            if (cbophonetype.SelectedIndex == 4)
            {
                multiplyer = .8;
            }
            if (cbophonetype.SelectedIndex == 5)
            {
                multiplyer = .6;
            }

            if (cbbDescription.SelectedIndex == 0)
            {
                txtCost.Text = Convert.ToString(Convert.ToInt32(90*multiplyer)); 
            }
            if (cbbDescription.SelectedIndex == 1)
            {
                txtCost.Text = Convert.ToString(Convert.ToInt32(50 * multiplyer));
            }
            if (cbbDescription.SelectedIndex == 2)
            {
                txtCost.Text = Convert.ToString(Convert.ToInt32(45 * multiplyer));
            }
            if (cbbDescription.SelectedIndex == 3)
            {
                txtCost.Text = Convert.ToString(Convert.ToInt32(40 * multiplyer));
            }
            if (cbbDescription.SelectedIndex == 4)
            {
                txtCost.Text = Convert.ToString(Convert.ToInt32(55 * multiplyer));
            }
            if (cbbDescription.SelectedIndex == 5)
            {
                txtCost.Text = Convert.ToString(Convert.ToInt32(45 * multiplyer));
            }
            if (cbbDescription.SelectedIndex == 6)
            {
                txtCost.Text = Convert.ToString(Convert.ToInt32(35 * multiplyer));
            }
            if (cbbDescription.SelectedIndex == 7)
            {
                txtCost.Text = Convert.ToString(Convert.ToInt32(40 * multiplyer));
            }
            if (cbbDescription.SelectedIndex == 8)
            {
                txtCost.Text = Convert.ToString(Convert.ToInt32(45 * multiplyer));
            }
            if (cbbDescription.SelectedIndex == 9)
            {
                txtCost.Text = Convert.ToString(Convert.ToInt32(70 * multiplyer));
            }
        }

        private void grpRepairDetails_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lblRepairID_Click(object sender, EventArgs e)
        {

        }
    }
}
