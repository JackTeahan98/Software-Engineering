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
    public partial class frm13StockAnalysis : Form
    {
        public frm13StockAnalysis()
        {
            InitializeComponent();
            grdStockAnalysis.Rows.Add("12","iPhone7","Screen","109","100");
            grdStockAnalysis.Rows.Add("160", "Samsung s8", "Battery", "109", "100");
            grdStockAnalysis.Rows.Add("24", "One Plus 3", "Screen", "109", "100");
            grdStockAnalysis.Rows.Add("625", "iPhone6", "Chargin Port", "109", "100");
        }
        
        private void btnBackButton_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Close();

        }

        private void grdStockAnalysis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm13StockAnalysis_Load(object sender, EventArgs e)
        {

        }
    }
}
