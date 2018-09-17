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
    public partial class frmCOAMainMenu : Form
    {
        public frmCOAMainMenu()
        {
            InitializeComponent();
        }

        private void Carry_Out_Administration_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmMainMenu mm = new frmMainMenu();
            mm.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmCOAIssueInvoice ii = new frmCOAIssueInvoice();
            ii.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmCOARecievePayment rp = new frmCOARecievePayment();
            rp.Show();
            this.Hide();
        }

        private void btnStockAnalysis_Click(object sender, EventArgs e)
        {
            frmCOAPaymentsAnalysis sad = new frmCOAPaymentsAnalysis();
            sad.Show();
            this.Close();
        }

        private void btnRepairAnalysis_Click(object sender, EventArgs e)
        {
            frmCOACustomerAnalysis ra = new frmCOACustomerAnalysis();
            ra.Show();
            this.Hide();
        }
    }
}
