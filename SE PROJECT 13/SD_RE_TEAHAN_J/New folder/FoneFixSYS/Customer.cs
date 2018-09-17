using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace FoneFixSYS
{
    class Customer
    {

        //Attributes
        private int CustomerID;
        private string CustomerSurname;
        private string CustomerForename;
        private string CustomerPhoneNumber;
        private string CustomerEmail;
        private string CustomerStreet;
        private string CustomerTown;
        private string CustomerCounty;
        private string CustomerEirCode;
        private decimal CustomerBalance;
        private string CustomerRegisterDate;
        private string CustomerStatus;


        //0 srgument Constructor
        public Customer()
        {
            CustomerID = 0;
            CustomerSurname = "";
            CustomerForename = "";
            CustomerPhoneNumber = "";
            CustomerEmail = "";
            CustomerStreet = "";
            CustomerTown = "";
            CustomerCounty = "";
            CustomerEirCode = "";
            CustomerBalance = 0;
            CustomerRegisterDate = "";
            CustomerStatus = "";
        }

        //12 argument constructor
        public Customer(int CustomerID, string CustomerSurname, string CustomerForename, string CustomerPhoneNumber, string CustomerEmail, string CustomerStreet, string CustomerTown, string CustomerCounty, string CustomerEirCode, decimal CustomerBalance, string CustomerRegisterDate, string CustomerStatus)
        {
            this.CustomerID = CustomerID;
            this.CustomerSurname = CustomerSurname;
            this.CustomerForename = CustomerForename;
            this.CustomerPhoneNumber = CustomerPhoneNumber;
            this.CustomerEmail = CustomerEmail;
            this.CustomerStreet = CustomerStreet;
            this.CustomerTown = CustomerTown;
            this.CustomerCounty = CustomerCounty;
            this.CustomerEirCode = CustomerEirCode;
            this.CustomerBalance = CustomerBalance;
            this.CustomerRegisterDate = CustomerRegisterDate;
            this.CustomerStatus = CustomerStatus;
        }

        //Setters
        public void setCustomerID(int CustomerID)
        { this.CustomerID = CustomerID; }

        public void setCustomerSurname(string CustomerSurname)
        { this.CustomerSurname = CustomerSurname; }

        public void setCustomerForename(string CustomerForename)
        { this.CustomerForename = CustomerForename; }

        public void setCustomerPhoneNumber(string CustomerPhoneNumber)
        { this.CustomerPhoneNumber = CustomerPhoneNumber; }

        public void setCustomerEmail(string CustomerEmail)
        { this.CustomerEmail = CustomerEmail; }

        public void setCustomerStreet(string CustomerStreet)
        { this.CustomerStreet = CustomerStreet; }

        public void setCustomerTown(string CustomerTown)
        { this.CustomerTown = CustomerTown; }

        public void setCustomerCounty(string CustomerCounty)
        { this.CustomerCounty = CustomerCounty; }

        public void setCustomerEirCode(string CustomerEirCode)
        { this.CustomerEirCode = CustomerEirCode; }

        public void setCustomerBalance(decimal CustomerBalance)
        { this.CustomerBalance = CustomerBalance; }

        public void setCustomerRegisterDate(string CustomerRegisterDate)
        { this.CustomerRegisterDate = CustomerRegisterDate; }

        public void setCustomerStatus(string CustomerStatus)
        { this.CustomerStatus = CustomerStatus; }



        //Getters
        public int getCustomerID()
        { return CustomerID; }

        public string getCustomerSurname()
        { return CustomerSurname; }

        public string getCustomerForename()
        { return CustomerForename; }

        public string getCustomerPhoneNumberD()
        { return CustomerPhoneNumber; }

        public string getCustomerEmail()
        { return CustomerEmail; }

        public string getCustomerStreet()
        { return CustomerStreet; }

        public string getCustomerTown()
        { return CustomerTown; }

        public string getCustomerCounty()
        { return CustomerCounty; }

        public string getCustomerEirCode()
        { return CustomerEirCode; }

        public decimal getCustomerBalance()
        { return CustomerBalance; }

        public string getCustomerRegisterDate()
        { return CustomerRegisterDate; }

        public string getCustomerStatus()
        { return CustomerStatus; }



        //Adds a customerinto the database with the 12 arguments passed in
        public void addCustomer()
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();
            String strSQL = "INSERT INTO Customer VALUES(" + this.CustomerID + ",'" + this.CustomerSurname.ToUpper() + "','" + this.CustomerForename.ToUpper() + "','" + this.CustomerPhoneNumber.ToUpper() + "','" + this.CustomerEmail.ToUpper() + "','" + this.CustomerStreet.ToUpper() + "','" + this.CustomerTown.ToUpper() + "','" + this.CustomerCounty.ToUpper() + "','" + this.CustomerEirCode.ToUpper() + "'," + this.CustomerBalance + ",'" + this.CustomerRegisterDate.ToUpper() + "','" + this.CustomerStatus.ToUpper() + "')";
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();
            myConn.Close();
        }


        //Calculates the next customer ID based on previous ID
        public static int nextCustomerID()
        {
            int nextCustomerID;
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();
            String strSQL = "SELECT MAX(CUSTOMERID) FROM CUSTOMER";
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            if (dr.IsDBNull(0))
                nextCustomerID = 1;

            else
                nextCustomerID = Convert.ToInt16(dr.GetValue(0)) + 1;

            myConn.Close();
            return nextCustomerID;

        }


        //Selects all customers for a dataset ordered by surname forename
        public static DataSet getAllCustomer(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            String strSQL = "SELECT * FROM Customer ORDER BY Surname, Forename";
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(DS, "ss");
            conn.Close();
            return DS;
        }


       
        //Updates the customers details  selected based on theyr ID
        public void updateCustomer()
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();
            String strSQL = "UPDATE CUSTOMER SET Forename = '" + this.CustomerForename.ToUpper() +
                                             "', Surname = '" + this.CustomerSurname.ToUpper() +
                                             "', PhoneNumber = '" + this.CustomerPhoneNumber.ToUpper() +
                                             "', Email = '" + this.CustomerEmail.ToUpper() +
                                             "', Street = '" + this.CustomerStreet.ToUpper() +
                                             "', Town = '" + this.CustomerTown.ToUpper() +
                                             "', County = '" + this.CustomerCounty.ToUpper() +
                                             "', Eircode = '" + this.CustomerEirCode.ToUpper() +
                                             "' WHERE CustomerID = " + this.CustomerID;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();
            myConn.Close();
        }

    

        //Changes the status of a customer where theyr ID is the same
        public void updateCustomerStatus()
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();
            String strSQL = "UPDATE CUSTOMER SET Status = '" + this.CustomerStatus.ToUpper() +
                                             "' WHERE CustomerID = " + this.CustomerID;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();
            myConn.Close();
        }


        //Changes the Balance of a customer where theyr ID is the same
        public void updateCustomerBalance()
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();
            String strSQL = "UPDATE CUSTOMER SET CustomerBalance = '" + this.CustomerBalance.ToString() +
                                             "' WHERE CustomerID = " + this.CustomerID;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();
            myConn.Close();
        }

      



        //Gets a customer based on the argument passed in as theyr id
        public void getCustomer(int Sno)
        {

            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();


            String strSQL = "SELECT * FROM Customer WHERE CustomerID = " + Sno;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);


            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                setCustomerID(dr.GetInt32(0));
                setCustomerForename(dr.GetString(1));
                setCustomerSurname(dr.GetString(2));
                setCustomerPhoneNumber(dr.GetString(3));
                setCustomerEmail(dr.GetString(4));
                setCustomerStreet(dr.GetString(5));
                setCustomerTown(dr.GetString(6));
                setCustomerCounty(dr.GetString(7));
                setCustomerEirCode(dr.GetString(8));
                setCustomerBalance(dr.GetDecimal(9));
                setCustomerStatus(dr.GetString(1));



            }

            myConn.Close();
        }


        

        //Selects all customer where the surnamei is like the one passed in as an argument
        public static DataSet getAllCustomerByName(DataSet DS, string CustomerName)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            String strSQL = "SELECT CustomerID, Surname, Forename, CustomerBalance FROM Customer WHERE Surname LIKE '" + CustomerName.ToUpper() + "%' AND Status ='A' ORDER BY Surname, Forename";
            OracleCommand cmd = new OracleCommand(strSQL, conn);


            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }


        //Gets all customers based on theyr status being A and ordered by name
        public static DataSet getAllCustomers(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            String strSQL = "SELECT CustomerID, Surname, Forename, CustomerBalance FROM Customer WHERE Status ='A' ORDER BY Surname, Forename";
            OracleCommand cmd = new OracleCommand(strSQL, conn);


            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }

        //Gets the required details where the customer ID is the argument passed in
        public void getCustomerInvoice(int Sno)
        {

            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();


            String strSQL = "SELECT CustomerID, Surname, CustomerBalance, PhoneNumber FROM Customer WHERE CustomerID = " + Sno;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);


            OracleDataReader dr = cmd.ExecuteReader();

            //If first stockNo, assign value 1, otherwise add 1 to MAX value
            if (dr.Read())
            {

                setCustomerID(dr.GetInt32(0));
                setCustomerSurname(dr.GetString(1));
                setCustomerBalance(dr.GetInt32(2));
                setCustomerPhoneNumber(dr.GetString(3));



            }

            myConn.Close();
        }


        //Gets the data required to make a chart based on the dates customers where registered
        public static DataSet getMonthlyData(DataSet DS, String Year)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //connection name conn.Open();
            String strSQL = "SELECT TO_CHAR(REGISTERDATE,'MM'), count(CUSTOMERID) FROM CUSTOMER WHERE REGISTERDATE LIKE '%" + Year + "' GROUP BY TO_CHAR(REGISTERDATE, 'MM') " + "ORDER BY TO_CHAR(REGISTERDATE, 'MM')";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;

        }

        //Checks the database to see if an email exists already in it
        public static Boolean emailExists(String email)
        {
            Boolean answer = true;
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String sql = "SELECT * FROM CUSTOMER WHERE EMAIL = '" + email.ToUpper() + "'";

            OracleCommand cmd = new OracleCommand(sql, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
                answer.Equals(true);
            else
                answer = false;


            conn.Close();

            return answer;

        }

        //Checks the database to see if an phone exists already in it
        public static Boolean phoneExists(String phone)
        {
            Boolean answer = true;
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String sql = "SELECT * FROM CUSTOMER WHERE PHONENUMBER = '" + phone.ToUpper() + "'";

            OracleCommand cmd = new OracleCommand(sql, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
                answer.Equals(true);
            else
                answer = false;


            conn.Close();

            return answer;

        }




    }
}
