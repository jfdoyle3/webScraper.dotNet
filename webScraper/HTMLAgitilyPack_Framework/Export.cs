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
        public void DataBaseTest(string[] stockData)

            //This Works
        {
            // HAL900
             string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\repository\webScraper\dotNET\webScraper.dotNet\webScraper\ScrapedData.mdf;Integrated Security=True";

            // Amuzement
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\repository\webScraper\dotNET\webScraper.dotNet\webScraper\ScrapedData.mdf;Integrated Security=True";

           // string[] fields ={ "@Symbol", "@LastPrice", "@Change", "@ChgPc", "@Currency", "@MarketTime", "@Volume", "@Shares", "@AvgVol3m", "@DayRange", "@Wk52Range", "@DayChart", "@MarketCap"};
           // string[] data = new string[13];
            //for (int w = 0; w < 12; w++)
            //{
            //    Console.WriteLine("{0} : {1}",w,stockData[w]);
            //    //stockData[w] = data[w];
            //}


                // string[] data = { "AMD", "$1.23", "-0.15", "+1.23", "USD", "4:00pm", "5.5b", "32", "34.65m", "3-5", "4-7", "chart", "100b", "buy/sell" };

            //    Console.WriteLine("f:{0} | d:{1}", fields.Length, data.Length);


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                String query = "INSERT INTO zTable (Symbol,LastPrice,Change,ChgPc,Currency,MarketTime,Volume,Shares,AvgVol3m,DayRange,Wk52Range,DayChart,MarketCap) VALUES (@Symbol,@LastPrice,@Change,@ChgPc,@Currency,@MarketTime,@Volume,@Shares,@AvgVol3m,@DayRange,@Wk52Range,@DayChart,@MarketCap)";


                using (SqlCommand command = new SqlCommand(query, connection))
                {


                    //for (int i = 0; i < fields.Length; i++)
                    //{
                    //    command.Parameters.AddWithValue(fields[i], data[i]);
                    //}

                    //        //int count = 0;
                    //        //for (int rows = 0; rows < 12; rows++)
                    //        //{
                    //        //    for (int s = count; s <= count + 3; s++)
                    //        //    {
                    //        //        Console.Write(stockList[s].InnerText);
                    //        //        tempTable.Rows.Add(stockList[s].InnerText);
                    //        //    }
                    //        //    //Console.Write("<--|-->\n");
                    //        //    count = count + 3;

                    //        //}

                    command.Parameters.AddWithValue("@Symbol", stockData[0]);
                    command.Parameters.AddWithValue("@LastPrice", stockData[1]);
                    command.Parameters.AddWithValue("@Change", stockData[2]);
                    command.Parameters.AddWithValue("@ChgPc", stockData[3]);
                    command.Parameters.AddWithValue("@Currency", stockData[4]);
                    command.Parameters.AddWithValue("@MarketTime", stockData[5]);
                    command.Parameters.AddWithValue("@Volume", stockData[6]);
                    command.Parameters.AddWithValue("@Shares", stockData[7]);
                    command.Parameters.AddWithValue("@AvgVol3m", stockData[8]);
                    command.Parameters.AddWithValue("@DayRange", stockData[9]);
                    command.Parameters.AddWithValue("@Wk52Range", stockData[10]);
                    command.Parameters.AddWithValue("@DayChart", stockData[11]);
                    command.Parameters.AddWithValue("@MarketCap", stockData[12]);




                    connection.Open();
                    Console.WriteLine("DB Opened");
                    int result = command.ExecuteNonQuery();
                    // Check Error
                    if (result < 0)
                        Console.WriteLine("Error inserting data into Database!");
                }
                connection.Close();
            }
            Console.WriteLine("Database Closed");


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
               