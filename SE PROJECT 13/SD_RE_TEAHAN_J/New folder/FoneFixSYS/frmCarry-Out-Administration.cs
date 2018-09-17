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
    public partial class Carry_Out_Administration : Form
    {
        public Carry_Out_Administration()
        {
            InitializeComponent();
        }

        private void Carry_Out_Administration_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frm11IssueInvoiceID ii = new frm11IssueInvoiceID();
            ii.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frm12RecievePaymentID rpi = new frm12RecievePaymentID();
            rpi.Show();
            this.Hide();
        }

        private void btnStockAnalysis_Click(object sender, EventArgs e)
        {
            frm13StockAnalysisDates sad = new frm13StockAnalysisDates();
            sad.Show();
            this.Close();
        }

        private void btnRepairAnalysis_Click(object sender, EventArgs e)
        {
            frm14RepairAnalysis ra = new frm14RepairAnalysis();
            ra.Show();
            this.Hide();
        }
    }
}
