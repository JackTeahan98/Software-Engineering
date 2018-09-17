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
    public partial class frmRepairCancel : Form
    {
        public frmRepairCancel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBackButton_Click(object sender, EventArgs e)
        {
            //Back Button form
            frmMainMenu mm = new frmMainMenu();
            mm.Show();
            this.Hide();
        }

       


        private void grdAllRepair_CellClick(object sender, DataGridViewCellEventArgs e)
        {



            //find repair details
            Repair rep = new Repair();
            rep.getRepair(Convert.ToInt32(grdAllRepairs.Rows[grdAllRepairs.CurrentCell.RowIndex].Cells[0].Value));

            if (rep.getCustomerID().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            //display Repair details
            txtRepairID.Text = (Convert.ToInt32(grdAllRepairs.Rows[grdAllRepairs.CurrentCell.RowIndex].Cells[0].Value)).ToString();
            cmbStatus.Text = (grdAllRepairs.Rows[grdAllRepairs.CurrentCell.RowIndex].Cells[3].Value).ToString();
       



        }

        private void frmRepairCancel_Load(object sender, EventArgs e)
        {
            //string status value = CANCELLED
            string status = "CANCELLED";

            //Fills grid with all repairs
            DataSet ds = new DataSet();
            grdAllRepairs.DataSource = Repair.getAllRepairs (ds, status).Tables["ss"];
            grdAllRepairs.AllowUserToAddRows = false;
           
            //sets size of grid columns
            DataGridViewColumn column0 = grdAllRepairs.Columns[0];
            column0.Width = 25;

            DataGridViewColumn column4 = grdAllRepairs.Columns[4];
            column4.Width = 300;

            DataGridViewColumn column5 = grdAllRepairs.Columns[5];
            column5.Width = 25;

            DataGridViewColumn column6 = grdAllRepairs.Columns[6];
            column6.Width = 45;

            //if grid empty, close
            if (grdAllRepairs.RowCount == 0)
            {
                DialogResult result = MessageBox.Show("* * * WARNING * * * \n\n--------------------------------------------------------------\n\nNo Repairs have been ADDED to allow CANCELATION...\n\n--------------------------------------------------------------\n\nWould you like to ADD a Repair?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                if (result == DialogResult.Yes)
                {
                    frmRepairLog ca = new frmRepairLog();
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

        private void btnRepairCancel_Click(object sender, EventArgs e)
        {


            //Validation
            if (txtRepairID.Text.Equals(""))
            {
                MessageBox.Show("Field Must Not Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRepairID.Focus();
                return;
            }
            
            
            // Sets the repair to its new details
            Repair rep = new Repair();

            rep.setRepairID(Convert.ToInt32(grdAllRepairs.Rows[grdAllRepairs.CurrentCell.RowIndex].Cells[0].Value));
            rep.setRepairStatus(cmbStatus.Text);

           
            //sets the status to the combo box value
            rep.updateRepairCancel();

            if (cmbStatus.Text == "IN PROGRESS")
            {
                rep.setRepairStatus("IN PROGRESS");
            }
            else
            {
                rep.setRepairStatus("CANCELLED");
            }

            //Display Confirmation Message
            MessageBox.Show(grdAllRepairs.Rows[grdAllRepairs.CurrentCell.RowIndex].Cells[4].Value + "\n --------------------------------------------------------\n"+cmbStatus.Text, "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            //string status value is COMPLETED
            string status = "CANCELLED";

            //reset UI
            txtRepairID.Text = "";
            cmbStatus.Text = "";
            DataSet ds = new DataSet();
            grdAllRepairs.DataSource = Repair.getAllRepairs(ds,status).Tables["ss"];

        }

        private void grdAllRepairs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
