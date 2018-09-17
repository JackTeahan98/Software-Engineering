using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FoneFixSYS
{
    public partial class frmCOACustomerAnalysis : Form
    {
        public frmCOACustomerAnalysis()
        {
            InitializeComponent();
        }

        private void frmCOACustomerAnalysis_Load(object sender, EventArgs e)
        {

        }

        private void btnBackButton_Click(object sender, EventArgs e)
        {
            //Back button form
            frmCOAMainMenu mm = new frmCOAMainMenu();
            mm.Show();
            this.Hide();
        }



        private void defineChart()
        {
            chtCustomers.Series.Clear();
            //define chart
            chtCustomers.Size = new Size(650, 300);
            chtCustomers.ChartAreas[0].Name = "mainArea";
            chtCustomers.ChartAreas["mainArea"].AxisX.LabelStyle.Font = new Font("Consolas", 8);
            chtCustomers.ChartAreas["mainArea"].AxisY.LabelStyle.Font = new Font("Consolas", 8);

            chtCustomers.ChartAreas["mainArea"].AxisY.Minimum = 0;
            chtCustomers.ChartAreas["mainArea"].AxisY.Interval = 5;
            chtCustomers.ChartAreas["mainArea"].AxisY.Title = "Number of Customers";

            chtCustomers.ChartAreas["mainArea"].AxisX.Interval = 1;
            chtCustomers.ChartAreas["mainArea"].AxisX.Title = "Month";

            chtCustomers.ChartAreas["mainArea"].AxisX.MajorGrid.Enabled = false;
            //chtData.ChartAreas["mainArea"].AxisY.MajorGrid.Enabled = false;

           
        }


        private void defineSeries()
        {
            chtCustomers.Series.Clear();
            chtCustomers.Series.Add("Customers");

            chtCustomers.Series["Customers"].ChartType = SeriesChartType.Column;
            chtCustomers.Series["Customers"].XValueType = ChartValueType.String;
        }



        private void fillChart(string year)
        {
            //fill chart
            chtCustomers.Series["Customers"].Points.Clear();

            //load values returned from query into 12 element array
            //decimal[] monthlyRev = { 0, 1200, 800, 1000, 1500, 1700, 2500, 2200, 1500, 1000, 500, 0 };

            //add values in array to chart series
            //for (int i = 0; i < 12; i++)
            //chtData.Series["Revenue"].Points.AddXY(monthName(i + 1), monthlyRev[i]);

            //get data from database
            DataSet ds = new DataSet();
            ds = Customer.getMonthlyData(ds, year);


            //add values in array to chart series
            int j = 0;
            for (int i = 1; i <= 12; i++)
            {


                if ((j == ds.Tables["ss"].Rows.Count) || (i < Convert.ToInt32(ds.Tables[0].Rows[j][0])))

                    chtCustomers.Series["Customers"].Points.AddXY(monthName(i), 0);




                else
                {
                    chtCustomers.Series["Customers"].Points.AddXY(monthName(i), Convert.ToDecimal(ds.Tables[0].Rows[j][1]));
                    j++;
                }

            }
        }


        private string monthName(int MonthNo)
        {
            String strMonth = "";

            switch (MonthNo)
            {
                case 1:
                    strMonth = "JAN";
                    break;
                case 2:
                    strMonth = "FEB";
                    break;
                case 3:
                    strMonth = "MAR";
                    break;
                case 4:
                    strMonth = "APR";
                    break;
                case 5:
                    strMonth = "MAY";
                    break;
                case 6:
                    strMonth = "JUN";
                    break;
                case 7:
                    strMonth = "JUL";
                    break;
                case 8:
                    strMonth = "AUG";
                    break;
                case 9:
                    strMonth = "SEP";
                    break;
                case 10:
                    strMonth = "OCT";
                    break;
                case 11:
                    strMonth = "NOV";
                    break;
                case 12:
                    strMonth = "DEC";
                    break;
            }

            return strMonth;
        }

      

        private void btnBackButton_Click_1(object sender, EventArgs e)
        {
            frmMainMenu mm = new frmMainMenu();
            mm.Show();
            this.Hide();
        }

        private void cboYear_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            lblYearFill.Text = "20" + cboYear.Text;
            grpCustomers.Visible = true;
            //define chart
            defineChart();

            //Define the chart series
            defineSeries();

            //fill Chart
            fillChart(cboYear.Text);
        }

        private void grpCustomers_Enter(object sender, EventArgs e)
        {

        }
    }
}
