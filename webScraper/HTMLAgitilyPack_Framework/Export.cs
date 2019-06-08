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
    public class Export
    {
        private String Folder = @"D:\repository\webScraper\dotNET\";
        private String FileName = "Output.txt";
        
        
        public void ToScreen(List<HtmlNode> value)
        {
            for (int index = 0; index < value.Count; index++)
            {
                HtmlNode className = value[index];
                // Console.WriteLine("{0}", className.InnerText);
                if (index % 2 == 0)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("{0}", className.InnerText);
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("{0}", className.InnerText);

                }
                Console.ResetColor();
            }
        }

        public void ToFile(List<HtmlNode> value)
        {

            String file = Folder + FileName;
            StreamWriter streamWriter = new StreamWriter(file); //'True' appends to file.
            for (int index = 0; index < value.Count; index++) // foreach change
            {
                HtmlNode className = value[index];

                streamWriter.WriteLine("{0}", className.InnerText);
            }
            streamWriter.Close();
            Console.WriteLine("Exported to File: {0}",FileName);
        }

        public void ToDatabase(DataTable tempTable)
        {
            // Connect and Open Database
            //
            // HAL900
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\repository\webScraper\dotNET\webScraper.dotNet\webScraper\ScrapedData.mdf;Integrated Security=True";

            // Amuzement
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\repository\webScraper\dotNET\webScraper.dotNet\webScraper\ScrapedData.mdf;Integrated Security=True";
            // TODO: Write tsble headers to database table

            SqlConnection dbConnect = new SqlConnection(connectionString);
            dbConnect.Open();
            Console.WriteLine("database open");
            using (SqlBulkCopy sqlBulk = new SqlBulkCopy(connectionString))
            {
                sqlBulk.DestinationTableName = "Stocks";
                sqlBulk.WriteToServer(tempTable);
            }

            // Close Database
            dbConnect.Close();
            Console.WriteLine("'Written to Database'");
        }
        public void ViewDataTable (DataTable table)
        {
            foreach(DataRow row in table.Rows)
            {
                Console.WriteLine();
                foreach (Object item in row.ItemArray)
                {
                    Console.WriteLine(item);
                }
            }
        }
        //public void InsertDatabase()
        //{
        //    // HAL900
        //    string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\repository\webScraper\dotNET\webScraper.dotNet\webScraper\ScrapedData.mdf;Integrated Security=True";

        //    // Amuzement
        //    //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\repository\webScraper\dotNET\webScraper.dotNet\webScraper\ScrapeDB.mdf; Integrated Security = True";
        //    SqlConnection cnn = new SqlConnection(connectionString);
        //    cnn.Open();

        //    Console.WriteLine("Database connected/Open");

        //    SqlCommand insert;
        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    String sql = "";
        //    for (int index = 0; index < value.Count; index++)
        //    {
        //        HtmlNode className = value[index];
        //        sql = "Insert into ScrapedData (xpath1) values(index,'" + className.InnerText + "')";
        //        insert = new SqlCommand(sql, cnn);
        //        adapter.InsertCommand = new SqlCommand(sql, cnn);
        //        adapter.InsertCommand.ExecuteNonQuery();
        //    }
        //    insert.Dispose();
        //    cnn.Close();

        //    Console.WriteLine("Database Closed");


        //}
        public void DataBaseTest()
        {
            // HAL900
             string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\repository\webScraper\dotNET\webScraper.dotNet\webScraper\ScrapedData.mdf;Integrated Security=True";

            // Amuzement
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\repository\webScraper\dotNET\webScraper.dotNet\webScraper\ScrapedData.mdf;Integrated Security=True";
            //SqlConnection cnn = new SqlConnection(connectionString);
            //cnn.Open();


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //String query = "INSERT INTO dbo.Table (Symbol,LastPrice,Change,ChgPc,Currency,MarketTime,Volume,Shares,AvgVol3m,DayRange,Wk52Range,DayChart,MarketCap,junk) VALUES (Symbol,LastPrice,Change,ChgPc,Currency,MarketTime,Volume,Shares,AvgVol3m,DayRange,Wk52Range,DayChart,MarketCap,junk)";
                String query = "INSERT INTO Stock.dTable (Symbol,LastPrice,Change) VALUES (Symbol,LastPrice,Change)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Symbol", "CVS");
                    command.Parameters.AddWithValue("@LastPrice", "-0.15");
                    command.Parameters.AddWithValue("@Change", "-4.65");
                    //command.Parameters.AddWithValue("@ChgPc", "$1,234");
                    //command.Parameters.AddWithValue("@Currency", "USA");
                    //command.Parameters.AddWithValue("@MarketTime", "1.55");
                    //command.Parameters.AddWithValue("@Volume", "7,453");
                    //command.Parameters.AddWithValue("@Shares", "One");
                    //command.Parameters.AddWithValue("@AvgVol3m", "56b");
                    //command.Parameters.AddWithValue("@DayRange", "23m");
                    //command.Parameters.AddWithValue("@Wk52Range", ".05");
                    //command.Parameters.AddWithValue("@DayChart", "upper");
                    //command.Parameters.AddWithValue("@MarketCap", "100b");
                    //command.Parameters.AddWithValue("@junk", "buy/sell");
                    


                    connection.Open();
                    Console.WriteLine("DB Opened");
                    int result = command.ExecuteNonQuery();
                    // Check Error
                    if (result < 0)
                        Console.WriteLine("Error inserting data into Database!");
                }
                  connection.Close();

                   Console.WriteLine("Database Closed");
               

            }


        }
        
    }

}


    //Copy the DataTable to SQL Server
    //        using(SqlConnection dbConnection = new SqlConnection("Data Source=dbhost;Initial Catalog=dbname;Integrated Security=SSPI;Connection Timeout=60;Min Pool Size=2;Max Pool Size=20;"))
    //        {
    //            dbConnection.Open();
    //            using (SqlBulkCopy s = new SqlBulkCopy(dbConnection))
    //            {
    //                s.DestinationTableName = dailySalesStats.TableName;
    //                foreach (var column in dailySalesStats.Columns)
    //                    s.ColumnMappings.Add(column.ToString(), column.ToString());
    //                s.WriteToServer(dailySalesStats);
    //            }
               