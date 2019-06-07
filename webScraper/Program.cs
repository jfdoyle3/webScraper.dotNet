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

            // "/th"                        = Table Headers
            // "/td[@aria-label='Symbol']"  = Data Columns

            List<HtmlNode> headers = htmlDoc.DocumentNode
                                            .SelectNodes("/th")
                                            .ToList();
            List<HtmlNode> stockData = htmlDoc.DocumentNode
                                            .SelectNodes("//td")
                                            .ToList();

          
            // ListConverter.ListToItem(stockData);
            NodetoString nts = new NodetoString();
            dynamic dTable=nts.NodesToTable(headers, stockData);
            nts.ToDatabase(dTable);

            //StockDataTable.StkDataTbl();

        }
    }
}

