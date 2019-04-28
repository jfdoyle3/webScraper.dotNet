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

        public void ToDatabase()
        {
            string connectionString;
            SqlConnection cnn;

            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\repository\webScraper\dotNET\webScraper.dotNet\webScraper\ScrapeDB.mdf;Integrated Security=True";

            cnn = new SqlConnection(connectionString);

            cnn.Open();
            Console.WriteLine("Database connected/Open");

            SqlCommand viewTable;
            SqlDataReader dataReader;
            String sql, Output = "";
            sql = "Select Id,xpath1 from ScrapedData";
            viewTable = new SqlCommand(sql, cnn);
            dataReader = viewTable.ExecuteReader();

            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + "\n";
            }
            Console.WriteLine(Output);
            cnn.Close();
            Console.WriteLine("Database Closed");

          //  Console.WriteLine("'Written to Database'");
        }
    }
}



           
                
            