using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Data.SqlClient;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Selenium;

namespace WebScraper
{
    class Program
    {
        static public void Main(string[] arg)
        {

            // Automated Yahoo Login - inherited classes
            // YahooFinance yf = new YahooFinance();
            // List<HtmlNode> stockTable = yf.Login();

            // From File
            FromFile scrape = new FromFile();
            List<HtmlNode> stockTable = scrape.ReadFile();

            // new code below here
            //


            NodetoString tableData = new NodetoString();
            tableData.StringNode(stockTable);
            string html = tableData.StringNode(stockTable);

            // Console.WriteLine(html);
            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            // // "/th"                        = Table Headers
            // // "/td[@aria-label='Symbol']"  = Data Columns

            //List<HtmlNode> headers = htmlDoc.DocumentNode
            //                                .SelectNodes("/th")
            //                                .ToList();
            List<HtmlNode> stockData = htmlDoc.DocumentNode
                                            .SelectNodes("//td")
                                            .ToList();


            ListConverter cStockData=new ListConverter();
            dynamic textData = cStockData.ListToItem(stockData);
            scrape.DataBaseTest(textData);
            //int count = 0;
            //for (int q = 0; q < 12; q++)
            //{
            //    for (int a = count; a < count+13; a++)
            //    {
            //        Console.Write("{0},",textData[a]);
            //    }
            //    Console.WriteLine();
            //    count = count + 16;
            //}

        }
    }
}

