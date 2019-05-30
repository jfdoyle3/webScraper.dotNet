using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using HtmlAgilityPack;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Selenium;

namespace WebScraper
{
    public class ListNode : Export
    {


        private readonly List<HtmlNode> classList = new List<HtmlNode>();


        public static void NodesToList()
        {

            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("https://finance.yahoo.com/portfolio/p_2/view/v1");
                HtmlDocument stocks = new HtmlDocument();
                stocks.LoadHtml(driver.PageSource);
                //TODO: HtmlWeb / Document load to the Connection Class
                HtmlDocument stockPage = new HtmlDocument();
                stockPage.LoadHtml(driver.PageSource);

                List<HtmlNode> classList = stockPage.DocumentNode
                                               .SelectNodes("//table")
                                               .ToList();

                for (int index = 0; index < classList.Count; index++)
                {
                    HtmlNode className = classList[index];
                    Console.WriteLine("{0}", className.InnerText);
                }
            }
                //return classList;
        }
        // moved to class nodetostring
        //public dynamic NodesToTable( List<HtmlNode> dataList)
        //{
        //    String[] headers = new string[] { "ID", "Symbol" };
        //    DataTable tempTable = new DataTable();

        //    //for (int header = 0; header < headers.Length; header++)
        //    //    tempTable.Columns.Add(headers[header]);
        //   foreach (string header in headers)
        //      tempTable.Columns.Add(header);

        //    //Add in Scraped Data to Temp Table
        //    for (int index = 1; index < classList.Count; index++)
        //    {
        //        HtmlNode className = classList[index];
        //        tempTable.Rows.Add(index, className.InnerText);
        //    }
        //    return tempTable;
        //}
        
    }
}
