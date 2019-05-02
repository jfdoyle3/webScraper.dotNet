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
            StreamWriter streamWriter = new StreamWriter(file, true); //'True' appends to file.
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
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\repository\webScraper\dotNET\webScraper.dotNet\webScraper\ScrapeDB.mdf;Integrated Security=True";

            // Amuzement
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\repository\webScraper\dotNET\webScraper.dotNet\webScraper\ScrapeDB.mdf; Integrated Security = True";
     
            SqlConnection dbConnect = new SqlConnection(connectionString);
            dbConnect.Open();

            using (SqlBulkCopy sqlBulk = new SqlBulkCopy(connectionString))
            {
                sqlBulk.DestinationTableName = "YellowPages";
                sqlBulk.WriteToServer(tempTable);
            }

            // Close Database
            dbConnect.Close();
            Console.WriteLine("'Written to Database'");
        }
        public void ViewDataTable (DataTable table)
        {
            foreach (DataRow dataRow in table.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    Console.Write("{0}\n",item);
                }
            }
        }
        public void InsertDatabase()
        {
          //Console.WriteLine("Database connected/Open");

            // SqlCommand insert;
            // SqlDataAdapter adapter = new SqlDataAdapter();
            // String sql = "";
            // for (int index = 0; index < value.Count; index++)
            // {
            //     HtmlNode className = value[index];
            //     sql = "Insert into ScrapedData (Id,xpath1) values(index,'" + className.InnerText + "')";
            //     insert = new SqlCommand(sql, cnn);
            //     adapter.InsertCommand = new SqlCommand(sql, cnn);
            //     adapter.InsertCommand.ExecuteNonQuery();
            // }
            // insert.Dispose();
            // cnn.Close();

            // Console.WriteLine("Database Closed");

             
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
}               
            