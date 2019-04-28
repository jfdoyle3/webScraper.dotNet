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

        public void ToDatabase(List<HtmlNode> value)
        {
            // Connect and Open Database
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\repository\webScraper\dotNET\webScraper.dotNet\webScraper\ScrapeDB.mdf;Integrated Security=True";
            SqlConnection dbConnect = new SqlConnection(connectionString);
            dbConnect.Open();

            // Create a Temp DataTable
            DataTable tempTable = new DataTable();
            tempTable.Columns.Add("Id");
            tempTable.Columns.Add("xpath1");

            //Add in Scraped Data to Temp Table
            for (int index = 1; index < value.Count; index++)
            {
                HtmlNode className = value[index];
                tempTable.Rows.Add(index++ , className.InnerText);
            }

            // BulkCopy from Temp Table to Database Table
            using (SqlBulkCopy sqlBulk = new SqlBulkCopy(connectionString))
            {
                sqlBulk.DestinationTableName = "ScrapedData";
                sqlBulk.WriteToServer(tempTable);
            }
            dbConnect.Close();
            Console.WriteLine("'Written to Database'");














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

            //  
        }
    }
}



           
                
            