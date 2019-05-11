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
            // try
            // {

            // Yellow Pages - Working/Test
           String webSite = "https://www.yellowpages.com/search?search_terms=bicycles&geo_location_terms=Providence%2C+RI";
           // String xPath = "//a[@class='business-name']";
            //string xPath = "//div[@class='v-card']";
           // ListNode scrapeNode = new ListNode(webSite, xPath);
           // List<HtmlNode> nodeList = scrapeNode.NodesToList();
           // scrapeNode.ToScreen(nodeList);



            //Yahoo Finance
            //String webSite = "https://finance.yahoo.com/portfolio/p_0/view";
            // String xPath = "//";


            //Top of fiance Table
            // String xPath="div[@class='']";
            // String xPath="//div id='pf-detail-table' class='Pos(r) '";
            // String xPath="//div[@id='pf-detail-table']";
            //String xPath= "//td[@aria-label='Change']";
            //String xPath = "//div[@class='Ovx(s) Ovy(h)']"; // The entire table
            //String xPath = "//div[@class='Ovx(a)']";


            //String[] xPath = new "//a[@class='phones phone primary']";
           // String[] headers = new string[2] { "Company", "Phone"};
            //String[] xPath =new string[2] { "//a[@class='business-name']", "//a[@class='phones phone primary']" };
            String[] headers = new string[2] { "Company","Phone" };
            String[] xPath = new string[2] { "//a[@class='business-name']","//div[@class='phones phone primary']"};
            var scrape = new MultiClass(webSite,xPath,headers);
            var table = scrape.MultiNodestoTable();
            scrape.ViewDataTable(table);
            scrape.ToDatabase(table);
          



            //}       
            //catch (Exception)
            //{

            //  Console.WriteLine("Error:\nIn Code\nnetwork problem\nwebsite not working\nXPath error");
            //}
        
        }
    }
}
