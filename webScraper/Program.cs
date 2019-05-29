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
            YahooFinance yf = new YahooFinance();
            dynamic stockList = yf.Login("jfdoyle_iii", "m93Fe8YHn");

            Console.WriteLine(stockList[1].InnerText);
            
            //for (int index = 1; index < stockList.Count; index++)
            //{
            //    Console.WriteLine(stockList[index].InnerText);
            //}
            //foreach (HtmlNode node in stockList)
            //{

            //    Console.WriteLine(node.InnerText.ToString());
            //}


        }
    }
}

