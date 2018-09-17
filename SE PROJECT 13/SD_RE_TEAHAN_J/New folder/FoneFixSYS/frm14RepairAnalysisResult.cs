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
    public partial class frm14RepairAnalysisResult : Form
    {
        public frm14RepairAnalysisResult()
        {
            InitializeComponent();

            grdRepairAnalysis.Rows.Add("12", "17372", "1234", "Tim", "34", "Descritpion");
            grdRepairAnalysis.Rows.Add("160", "12979", "Password", "Bob", "3747", "Descritpion");
            grdRepairAnalysis.Rows.Add("24", "1037601", "", "Sheila", "388", "Descritpion");
            grdRepairAnalysis.Rows.Add("625", "108327", "", "Mary", "109","Descritpion");

        }

        private void btnBackButton_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Close();
        }

        private void frm14RepairAnalysisResult_Load(object sender, EventArgs e)
        {

        }
    }
}
