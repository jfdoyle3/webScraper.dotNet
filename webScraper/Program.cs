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
            // YahooFinance yf = new YahooFinance();
            // string url=yf.Login("username", "password");
            // Console.WriteLine(url);



            string stocks = File.ReadAllText(@"C:\website\Stocks.htm");
            HtmlDocument htmlDoc = new HtmlDocument();

            htmlDoc.LoadHtml(stocks);

            HtmlNode classList = htmlDoc.DocumentNode.SelectSingleNode("//tr");
                                           
                                           

            Console.WriteLine(classList.InnerText);
           // foreach (HtmlNode node in classList)
          //  {
           //     Console.WriteLine(node.InnerText);
          //  }
        }
    }
}

