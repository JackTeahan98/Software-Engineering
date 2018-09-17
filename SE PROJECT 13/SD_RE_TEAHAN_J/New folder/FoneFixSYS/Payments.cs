using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace FoneFixSYS
{
    class Payments
    {
        //Attributes
        private int PaymentID;
        private int PaymentAmount;
        private string DatePaid;
        private int CustomerID;
        private string RepairStatus;
        private string RepairID;


        //No argument constructor 
        public Payments()
        {
            CustomerID = 0;
            PaymentAmount = 0;
            DatePaid = "";
            CustomerID = 0;
        }

        //4 argument constructor
        public Payments(int PaymentID, int PaymentAmount, string DatePaid, int CustomerID)
        {
            this.PaymentID = PaymentID;
            this.PaymentAmount = PaymentAmount;
            this.DatePaid = DatePaid;
            this.CustomerID = CustomerID;
        }

        //Setters
        public void setPaymentID(int PaymentID)
        { this.PaymentID = PaymentID; }
        public void setPaymentAmount(int PaymentAmount)
        { this.PaymentAmount = PaymentAmount; }
        public void setDatePaid(string DatePaid)
        { this.DatePaid = DatePaid; }
        public void setCustomerID(int CustomerID)
        { this.CustomerID = CustomerID; }


        //Getters
        public int getPaymentID()
        { return PaymentID; }
        public int getPaymentAmount()
        { return PaymentAmount; }
        public string getDatePaid()
        { return DatePaid; }
        public int getCustomerID()
        { return CustomerID; }


        
        //Adds a new payment with 4 pieces of data into the payments
        public void addPayment()
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();
            String strSQL = "INSERT INTO PAYMENTS VALUES(" + this.PaymentID + "," + this.PaymentAmount + ",'" + this.DatePaid + "'," + this.CustomerID+")";
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();
            myConn.Close();
        }



        //Gets data used for making charts based on the year inputted
        public static DataSet getMonthlyData(DataSet DS, String Year)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //connection name conn.Open();
            String strSQL = "SELECT TO_CHAR(DATEPAID,'MM'), SUM(PAYMENTAMOUNT) FROM Payments WHERE DATEPAID LIKE '%" + Year + "' GROUP BY TO_CHAR(DATEPAID, 'MM') " + "ORDER BY TO_CHAR(DATEPAID, 'MM')";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;

        }



        //Calculates the next id based in the previous IDs
        public static int nextPaymentID()
        {
            int nextPaymentID;

            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "SELECT MAX(PAYMENTID) FROM PAYMENTS";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr.IsDBNull(0))
                nextPaymentID = 1;

            else
                nextPaymentID = Convert.ToInt16(dr.GetValue(0)) + 1;

            myConn.Close();

            return nextPaymentID;

        }
    }

}
