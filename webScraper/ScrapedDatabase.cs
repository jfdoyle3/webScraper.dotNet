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
         string connectionString;
         SqlConnection cnn;

            // HAL9000
            //connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\repository\webScraper\dotNET\webScraper.dotNet\webScraper\ScrapeDB.mdf;Integrated Security=True";

            // Amuzement
            connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\repository\webScraper\dotNET\webScraper.dotNet\webScraper\ScrapeDB.mdf; Integrated Security = True";

            cnn = new SqlConnection(connectionString);

        cnn.Open();
            Console.WriteLine("Database connected/Open");

        SqlCommand viewTable;
        SqlDataReader dataReader;
        String sql, Output = "";
        sql = "Select ID,Company from YellowPages";
            viewTable = new SqlCommand(sql, cnn);
        dataReader = viewTable.ExecuteReader();

            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + "\n";
            }
            Console.WriteLine(Output);
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
