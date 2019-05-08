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
        static void Main(string[] arg)
        {
            // try
            // {

            // Yellow Pages - Working/Test
            //String webSite = "https://www.yellowpages.com/search?search_terms=bicycles&geo_location_terms=Providence%2C+RI";
            //String xPath = "//a[@class='business-name']";
            //string xPath = "//div[@class='v-card']";
            //ListNode scrapeNode = new ListNode(webSite, xPath);
            //List<HtmlNode> nodeList = scrapeNode.NodesToList();
            //scrapeNode.ToScreen(nodeList);



            //Yahoo Finance
            //String webSite = "https://finance.yahoo.com/portfolio/p_0/view";
            // String xPath = "//";

            ////main/div/div/div[2]/div/div[1]

            //Top of fiance Table
            // String xPath="div[@class='']";
            // String xPath="//div id='pf-detail-table' class='Pos(r) '";
            // String xPath="//div[@id='pf-detail-table']";
            // String xPath="tr";
            //String xPath = "//div[@class='Ovx(s) Ovy(h)']"; // The entire table



            //String xPath2 = "//a[@class='phones phone primary']";
            // String[] headers = new string[] { "ID", "Company" };
            //String[] xPath =new string[2] { "//a[@class='class='phones phone primary']", "//a[@class='business-name']" };
            //foreach (string query in xPath)
            //    Console.WriteLine(query);
            // string xPath1 = xPath[0];

            // Selenium
            Selenium.Selenium execute = new Selenium.Selenium();
            execute.RunSelenium();

            // DataBase Column = List <T>
            // ListNode scrapeNode = new ListNode(webSite, xPath);
            //scrapeNode.GetChildNodes();
            //scrapeNode.GetInnerHtml();
            //  scrapeNode.GetInnerText();

            // Scrape WebSite and Return a List<HtmlNode> list.
            //List<HtmlNode> nodeList = scrapeNode.NodesToList();
            // List<HtmlNode> company=companyNode.NodesToList();
            // List<HtmlNode> phone=companyNode.NodesToList();


            // Create a tempDataTable from List var Name
            //DataTable nodeDataList=companyNode.NodesToTable(scrapeNode);


            //View DataTable / To Screen /To File
            //scrapeNode.ViewDataTable(nodeList);
             // scrapeNode.ToScreen(nodeList);
            //scrapeNode.ToFile(nodeList);


            // Write to tempDataTable to Database
            // scrapeNode.ToDatabase(nodeList);


            // Display Database
            // ScrapedDatabase view = new ScrapedDatabase();
            // view.DisplayData();











            //}       
            //catch (Exception)
            //{

            //  Console.WriteLine("Error:\nIn Code\nnetwork problem\nwebsite not working\nXPath error");
            //}

        }
    }
}
