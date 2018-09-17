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
    public partial class frmCOAPaymentsAnalysis : Form
    {
        
        public frmCOAPaymentsAnalysis()
        {
            InitializeComponent();
        }

        private void btnBackButton_Click(object sender, EventArgs e)
        {
            //Backbutton form
            frmMainMenu mm = new frmMainMenu();
            mm.Show();
            this.Close();
        }

        private void frmCOAPaymentsAnalysis_Load(object sender, EventArgs e)
        {
           
        }



        private void defineChart()
        {
            chtPayments.Series.Clear();
            //define chart
            chtPayments.Size = new Size(650, 300);
            chtPayments.ChartAreas[0].Name = "mainArea";
            chtPayments.ChartAreas["mainArea"].AxisX.LabelStyle.Font = new Font("Consolas", 8);
            chtPayments.ChartAreas["mainArea"].AxisY.LabelStyle.Font = new Font("Consolas", 8);

            chtPayments.ChartAreas["mainArea"].AxisY.Minimum = 0;
            chtPayments.ChartAreas["mainArea"].AxisY.Interval = 100;
            chtPayments.ChartAreas["mainArea"].AxisY.Title = "Euros";

            chtPayments.ChartAreas["mainArea"].AxisX.Interval = 1;
            chtPayments.ChartAreas["mainArea"].AxisX.Title = "Month";

            chtPayments.ChartAreas["mainArea"].AxisX.MajorGrid.Enabled = false;
            //chtData.ChartAreas["mainArea"].AxisY.MajorGrid.Enabled = false;

            //chart title   
            
        }

        private void defineSeries()
        {
            chtPayments.Series.Clear();
            chtPayments.Series.Add("Revenue");

            chtPayments.Series["Revenue"].ChartType = SeriesChartType.Column;
            chtPayments.Series["Revenue"].XValueType = ChartValueType.String;
        }

        private void fillChart(string year)
        {
            //fill chart
            chtPayments.Series["Revenue"].Points.Clear();

            //load values returned from query into 12 element array
            //decimal[] monthlyRev = { 0, 1200, 800, 1000, 1500, 1700, 2500, 2200, 1500, 1000, 500, 0 };

            //add values in array to chart series
            //for (int i = 0; i < 12; i++)
            //chtData.Series["Revenue"].Points.AddXY(monthName(i + 1), monthlyRev[i]);

            //get data from database
            DataSet ds = new DataSet();
            ds = Payments.getMonthlyData(ds, year);


            //add values in array to chart series
            int j = 0;
            for (int i = 1; i <= 12; i++)
            {


                if ((j == ds.Tables["ss"].Rows.Count) || (i < Convert.ToInt32(ds.Tables[0].Rows[j][0])))

                    chtPayments.Series["Revenue"].Points.AddXY(monthName(i), 0);
                

                
                   
                else
                {
                    chtPayments.Series["Revenue"].Points.AddXY(monthName(i), Convert.ToDecimal(ds.Tables[0].Rows[j][1]));
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

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            lblYearFill.Text = "20"+cboYear.Text;

            grpPayments.Visible = true;
            //define chart
            defineChart();

            //Define the chart series
            defineSeries();

            //fill Chart
            fillChart(cboYear.Text);
            
        }
    } }
