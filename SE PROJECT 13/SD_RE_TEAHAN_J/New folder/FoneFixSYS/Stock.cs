using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;


namespace FoneFixSYS
{
    class Stock
    {
        //Attributes
        private int StockID;
        private string StockName;
        private string StockType;
        private decimal StockPrice;
        private int StockQuantity;


        //No argument constructor
        public Stock()
        {
            StockID = 0;
            StockName = "";
            StockType = "";
            StockPrice = 0;
            StockQuantity = 0;
        }




        //5 argument constructor
        public Stock(int StockID, string StockName, string StockType, decimal StockPrice, int StockQuantity)
        {
            this.StockID = StockID;
            this.StockName = StockName;
            this.StockType = StockType;
            this.StockPrice = StockPrice;
            this.StockQuantity = StockQuantity;
        }



        //Getters
        public void setStockID(int StockID)
        { this.StockID = StockID; }

        public void setStockName(string StockName)
        { this.StockName = StockName; }

        public void setStockType(string StockType)
        { this.StockType = StockType; }

        public void setStockPrice(decimal StockPrice)
        { this.StockPrice = StockPrice; }

        public void setStockQuantity(int StockQuantity)
        { this.StockQuantity = StockQuantity; }




        //Setters
        public int getStockID()
        { return StockID; }

        public string getStockName()
        { return StockName; }

        public string getStockType()
        { return StockType; }

        public decimal getStockPrice()
        { return StockPrice; }

        public int getStockQuantity()
        { return StockQuantity; }


        //Add Stock
        //Inserts 5 pieces of data into INVENTORY
        public void addStock()
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();
            
            String strSQL = "INSERT INTO Inventory VALUES(" + this.StockID + ",'" + this.StockName.ToUpper() + "','" + this.StockType + "'," + this.StockPrice + "," + this.StockQuantity + ")";
          
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            myConn.Close();
        }


        //Next Stock ID
        //Calculates the next stock ID in the system
        public static int nextStockID()
        {
            int nextStockID;

            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "SELECT MAX(STOCKID) FROM INVENTORY";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr.IsDBNull(0))
                nextStockID = 1;

            else
                nextStockID = Convert.ToInt16(dr.GetValue(0)) + 1;

            myConn.Close();

            return nextStockID;

        }

        //Get All Stock
        //Selects all the Stock Data from INVENTORY and orders by the StockName
        public static DataSet getAllStock(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String strSQL = "SELECT StockID, StockName, StockType, StockPrice, StockQuantity FROM inventory ORDER BY StockName";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }


        //Gets All Stock By NAME
        //Selects all stock from Inventory based on the argument STOCKNAME passed in
        public static DataSet getAllStockByName(DataSet DS, string StockName)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            String strSQL = "SELECT * FROM inventory WHERE StockName LIKE '"+ StockName.ToUpper()+ "%' ORDER BY StockName";
            OracleCommand cmd = new OracleCommand(strSQL, conn);


            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }



        //Update Stock
        //Updates all of the corresponding stock and changes the values based on arguments passed in
        public void updateStock()
        {           
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();           
            String strSQL = "UPDATE INVENTORY SET StockName = '" + this.StockName.ToUpper() + "', StockType = '" + this.StockType +"', StockPrice = " + this.StockPrice + ", StockQuantity = " + this.StockQuantity + " WHERE StockID = " + this.StockID;
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();
            myConn.Close();
        }

  


        //Get Stock
        //Gets a Stock Item from INVENTORY based on its ID
        public void getStock(int Sno)
        {
            
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            
            String strSQL = "SELECT * FROM inventory WHERE StockID = " + Sno;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

         
            OracleDataReader dr = cmd.ExecuteReader();

            //If first stockNo, assign value 1, otherwise add 1 to MAX value
            if (dr.Read())
            {

                setStockID(dr.GetInt32(0));
                setStockName(dr.GetString(1));
                setStockType(dr.GetString(2));
                setStockPrice(dr.GetInt32(3));
                setStockQuantity(dr.GetInt32(4));
               

            }
            
            myConn.Close();
        }


       

    }
}
