using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
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

            
            YahooFinance yf = new YahooFinance();
            dynamic url= yf.Login("jfdoyle_iii", "m93Fe8YHn");
            Console.WriteLine(url);

            //String xPath = "//*[@id='pf-detail-table']/div[1]/table/tbody/tr[1]/td[2]/span";

            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(url);

            //String lastPrice = doc.DocumentNode.SelectSingleNode(xPath).InnerText;
            //Console.WriteLine(lastPrice);

            var tablerows = doc.DocumentNode.SelectNodes("//*[@id='pf- detail-table']/div[1]/table/tbody/tr[1]");

            foreach (HtmlNode row in tablerows)
            {
                var cells = row.SelectNodes(".//td");

                Console.WriteLine(cells[0].InnerText);
            }
               
            }
        }
}
