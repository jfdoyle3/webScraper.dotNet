using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using HtmlAgilityPack;
using System.Data;
using System.Data.SqlClient;
using System.Linq;


namespace WebScraper
{
    class ScrapedDatabase
    {
       
        public void DisplayData()
        {
            //TODO: Move to Connection Class


            // HAL9000
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\repository\webScraper\dotNET\webScraper.dotNet\webScraper\ScrapedData.mdf;Integrated Security=True";

            // Amuzement
            //string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\repository\webScraper\dotNET\webScraper.dotNet\webScraper\ScrapeDB.mdf; Integrated Security = True";

          SqlConnection  cnn = new SqlConnection(connectionString);

        cnn.Open();
            Console.WriteLine("Database connected/Open");

         // View Table
        SqlCommand viewTable;
        SqlDataReader dataReader;
        String sql, Output = "";
        sql = "Select Symbol, Last Price, Change from Stocks";
            viewTable = new SqlCommand(sql, cnn);
        dataReader = viewTable.ExecuteReader();
            // TODO:  Have to alter code to accept dynamic values: fixed 2 variable current
            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + "\n";
            }
            Console.WriteLine(Output);

            // DB Close
            cnn.Close();
            Console.WriteLine("Database Closed");
        }
        //public void InsertDatabase()
        //{
        //    string connectionString;
        //    SqlConnection cnn;

        //    connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\repository\webScraper\dotNET\webScraper.dotNet\webScraper\ScrapeDB.mdf;Integrated Security=True";

        //    cnn = new SqlConnection(connectionString);

        //    cnn.Open();
        //    Console.WriteLine("Database connected/Open");

        //    SqlCommand insert;
        //    SqlDataAdapter adapter = new SqlDataAdapter();
            
        //    String sql = "Insert into ScrapedData (Id,xpath1) values(2,'"+"Doyle"+"')";
        //    insert = new SqlCommand(sql, cnn);
        //    adapter.InsertCommand = new SqlCommand(sql, cnn);
        //    adapter.InsertCommand.ExecuteNonQuery();

        //    insert.Dispose();
        //    cnn.Close();

        //    Console.WriteLine("Database Closed");
        //}
        
    }
}
