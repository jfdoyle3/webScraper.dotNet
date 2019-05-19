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

            //  SeleniumTest.Testing123();
            YahooFinance.Login("jfdoyle_iii","Wa49sDwq");
           // Yellow.BikeYellow(); 

            // Yellow Pages - Working/Test
            //String webSite = "https://www.yellowpages.com/search?search_terms=bicycles&geo_location_terms=Providence%2C+RI";
            // String xPath = "//a[@class='business-name']";
            //string xPath = "//div[@class='v-card']";
            // ListNode scrapeNode = new ListNode(webSite, xPath);
            // List<HtmlNode> nodeList = scrapeNode.NodesToList();
            // scrapeNode.ToScreen(nodeList);



            //Yahoo Finance
           // String webSite = "https://finance.yahoo.com/portfolio/p_0/view";
            // String xPath = "//";


            //Top of fiance Table
            // String xPath="div[@class='']";
            // String xPath="//div id='pf-detail-table' class='Pos(r) '";
            // String xPath="//div[@id='pf-detail-table']";
            //String xPath= "//td[@aria-label='Change']";
            //String xPath = "//div[@class='Ovx(s) Ovy(h)']"; // The entire table
            //String xPath = "//div[@class='Ovx(a)']";
            //ListNode stocks = new ListNode(webSite, xPath);
            
            //stocks.ToScreen(stockList);


            //String[] xPath = new "//a[@class='phones phone primary']";
            // String[] headers = new string[2] { "Company", "Phone"};
            //String[] xPath =new string[2] { "//a[@class='business-name']", "//a[@class='phones phone primary']" };
            // String[] headers = new string[2] { "Company","Phone" };
            //String[] xPath = new string[2] { "//a[@class='business-name']","//div[@class='phones phone primary']"};
            // var scrape = new MultiClass(webSite,xPath,headers);
            // var table = scrape.MultiNodestoTable();
            //scrape.ViewDataTable(table);
            //scrape.ToDatabase(table);

            //TablePrinter t = new TablePrinter("id", "Column A", "Column B","Column C","Column ABC");
            //t.AddRow(1, "Val A1", "Val B1","Val C1","Val 123");
            //t.AddRow(2, "Val A2", "Val B2","Val C2","Val 456");
            //t.AddRow(100, "Val A100", "Val B100","Val C100","Val 888");
            //t.Print();


           

        }
    }
}
