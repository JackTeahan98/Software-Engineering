using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace FoneFixSYS
{
    class Repair
    {
        //Attributes
        private int RepairID = 1;
        private string PhoneSerialNumber;
        private string Password;
        private int CustomerID;
        private string RepairStatus;
        private string Description;
        private decimal Cost;
        private string CustomerName;
        private string CustomerStatus;


        //No Argument Constructor
        public Repair()
        {
            RepairID = 1;
            PhoneSerialNumber = "";
            Password = "";
            CustomerID = 0;
            RepairStatus = "";
            Description = "";
            Cost = 0;
        }

        //7 Argument Consrtuctor
        public Repair(int RepairID, string PhoneSerialNumber, string Password, string RepairStatus, string Description, int CustomerID, int Cost)
        {
            this.RepairID = RepairID;
            this.PhoneSerialNumber = PhoneSerialNumber;
            this.Password = Password;
            this.CustomerID = CustomerID;
            this.RepairStatus = RepairStatus;
            this.Description = Description;
            this.Cost = Cost;
        }


        //Setters
        public void setRepairID(int RepairID)
        { this.RepairID = RepairID; }
        public void setPhoneSerialNumber(string PhoneSerialNumber)
        { this.PhoneSerialNumber = PhoneSerialNumber; }
        public void setPassword(string Password)
        { this.Password = Password; }
        public void setCustomerID(int CustomerID)
        { this.CustomerID = CustomerID; }
        public void setRepairStatus(string RepairStatus)
        { this.RepairStatus = RepairStatus; }
        public void setDescription(string Description)
        { this.Description = Description; }
        public void setCost(decimal Cost)
        { this.Cost = Cost; }
        public void setCustomerName(string CustomerName)
        { this.CustomerName = CustomerName; }
        public void setCustomerStatus(string CustomerStatus)
        { this.CustomerStatus = CustomerStatus; }




        //Getters
        public int getRepairID()
        { return RepairID; }
        public string getPhoneSerialNumber()
        { return PhoneSerialNumber; }
        public string getPassword()
        { return Password; }
        public int getCustomerID()
        { return CustomerID; }
        public string getRepairStatus()
        { return RepairStatus; }
        public string getDescription()
        { return Description; }
        public decimal getCost()
        { return Cost; }
        public string getCustomerName()
        { return CustomerName; }
        public string getCustomerStatus()
        { return CustomerStatus; }





        //Get Repair Details
        //Gets Customer Information for the repair, ordered by name
        public static DataSet getRepairDetails(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            String strSQL = "SELECT CustomerID, Surname, Status FROM Customer  WHERE Status = 'A' ORDER BY Surname,Forename";
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(DS, "ss");
            conn.Close();
            return DS;
        }



        //get Repair Details
        //Selects
        public void getRepairDetails(int Sno)
        {

            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();


            String strSQL = "SELECT CustomerID,Forename FROM Customer WHERE CustomerID = " + Sno;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);


            OracleDataReader dr = cmd.ExecuteReader();

           
            if (dr.Read())
            {

                setCustomerID(dr.GetInt32(0));
                setCustomerName(dr.GetString(1));
            }

            myConn.Close();
        }



        //Next Repair ID
        //Calculates the next Repair ID in the system
        public static int nextRepairID()
        {
            int nextRepairID;

            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "SELECT MAX(REPAIRID) FROM repair";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr.IsDBNull(0))
                nextRepairID = 1;

            else
                nextRepairID = Convert.ToInt16(dr.GetValue(0)) + 1;

            myConn.Close();

            return nextRepairID;

        }


        //Add repair
        //Inserts 7 pieces of data into Repair
        public void addRepair()
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "INSERT INTO Repair VALUES(" + this.RepairID + ",'" + this.PhoneSerialNumber.ToUpper() + "','" + this.Password.ToUpper() + "','" + this.RepairStatus.ToUpper() + "','" + this.Description.ToUpper() + "'," + this.CustomerID + "," + this.Cost + " )";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            myConn.Close();
        }

       

        //Get All Repair
        //Gets Data for a dataset based on the repair status and ordered by ID
        public static DataSet getAllRepairs(DataSet DS, string STATUS)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            String strSQL = "SELECT * FROM Repair WHERE REPAIRSTATUS = 'IN PROGRESS' OR REPAIRSTATUS = '" +STATUS.ToUpper()+"'ORDER BY RepairID";
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(DS, "ss");
            conn.Close();
            return DS;
        }


        //Get Repair
        //Selects a repair based on the argument passed in
        public void getRepair(int Sno)
        {

            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();


            String strSQL = "SELECT * FROM Repair WHERE RepairID = " + Sno;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);


            OracleDataReader dr = cmd.ExecuteReader();
            

            if (dr.Read())
            {

                setRepairID(dr.GetInt32(0));
                setPhoneSerialNumber(dr.GetString(1));
                setPassword(dr.GetString(2));
                setRepairStatus(dr.GetString(3));
                setDescription(dr.GetString(4));
                setCustomerID(dr.GetInt32(5));
                setCost(dr.GetInt32(6));




            }

            myConn.Close();
        }


        //Update Repair Cancel
        //Sets the status of the repair to a cancelled  or completed one, based on the string argument passed in
        public void updateRepairCancel()
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();
            String strSQL = "UPDATE Repair SET RepairStatus = '" + this.RepairStatus.ToUpper() +
                                             "' WHERE RepairID = " + this.RepairID;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();
            myConn.Close();
        }


    
        //Get Customer Repair
        //Gets the repair based on the customer ID of the repair
        public static DataSet getCustomerRepair(DataSet DS, int Sno, string status)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            
            String strSQL = "SELECT RepairID, Description, Cost, RepairStatus FROM Repair WHERE CustomerID = " + Sno + "AND RepairStatus = "+status;
            OracleCommand cmd = new OracleCommand(strSQL, conn);


            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }


        //Get Repair Invoice
        //Gets  relevant repair details for an invoice based on the repair iD argument passed in
        public void getRepairInvoice(int Sno)
        {

            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();


            String strSQL = "SELECT RepairID, Description, Cost FROM Repair WHERE RepairID = " + Sno;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);


            OracleDataReader dr = cmd.ExecuteReader();

            
            if (dr.Read())
            {

                setRepairID(dr.GetInt32(0));
                setDescription(dr.GetString(1));
                setCost(dr.GetInt32(2));
               



            }

            myConn.Close();
        }



        //Get Repair Cost
        //Gets the total cost of repairs based on its customerID and its status being COMPLETED
        public static int getRepairCost(int sno)
        {
            int nextRepairID;

            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "SELECT SUM(COST) FROM repair where customerID ="+sno+ " AND RepairStatus = 'COMPLETED' ORDER BY RepairStatus";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

           
                nextRepairID = Convert.ToInt32(dr.GetValue(0));

            myConn.Close();

            return nextRepairID;

        }


        //Get Payment
        //Selects the cost of the selected repair based on the customer ID and Repair STatus being ISSUE INVOICE and returning the value
        public static int getRepairPayment(int sno, int cno)
        {
            int nextRepairID;

            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "SELECT COST FROM repair where customerID =" + sno + " AND RepairStatus = 'ISSUE INVOICE' AND RepairID ="+cno+"ORDER BY RepairStatus";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();


            nextRepairID = Convert.ToInt32(dr.GetValue(0));

            myConn.Close();

            return nextRepairID;

        }

        //Update Repair Status for Invoice
        //Updates the Repair status to the argument passed in based on the customer ID and the repair status already being completed
        public void updateRepairStatusINVOICE(int Cno, string status)
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();
            String strSQL = "UPDATE Repair SET RepairStatus = "+status+" WHERE CustomerID = " +Cno+" AND RepairStatus = 'COMPLETED'";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();
            myConn.Close();
        }



        //Update Repair Status for Payment
        //Updates the Repair status to the argument passed in based on the customer ID and the repair status already being the other value passed in
        public void updateRepairStatusPAYMENT(int Cno, int Rno, string status)
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();
            String strSQL = "UPDATE Repair SET RepairStatus = " + status + " WHERE CustomerID = " + Cno + "AND RepairID =" + Rno;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();
            myConn.Close();
        }


        //Update Customer Balance
        //Sets the customer balance after they have sent in theyr payment
        public static void updateCustomerBalance(int payment, int Cno)
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();
            String strSQL = "UPDATE Customer SET CustomerBalance = CustomerBalance - " + payment + " WHERE CustomerID = " + Cno;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();
            myConn.Close();
        }
    }
}
    
