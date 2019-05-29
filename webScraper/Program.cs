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
            //YahooFinance.Login();
            YahooFinance yf = new YahooFinance();
            List<HtmlNode> stockTable = yf.Login();
            DataTable tempStockTable = yf.NodesToTable(stockTable);
            yf.ToDatabase(tempStockTable);

            



        }
    }
}

