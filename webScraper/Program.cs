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
            FromFile scrape = new FromFile();
            List<HtmlNode> stockTable=scrape.ReadFile();
            // scrape.ToFile(stockTable);
            NodetoString tableData = new NodetoString();
            tableData.StringMe(stockTable);
            string html = tableData.StringMe(stockTable);
            Console.WriteLine(html);
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var htmlBody = htmlDoc.DocumentNode.SelectNodes("/td[@aria-label='Volume']").ToList();
            foreach (var item in htmlBody)
            {
                Console.WriteLine(item.InnerText);
            }





        }
    }
}

