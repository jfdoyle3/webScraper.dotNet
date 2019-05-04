using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using HtmlAgilityPack;


namespace WebScraper
{
    
    class Program
    {
        static void Main(string[] arg)
        {
            // try
            // {

            // Yellow Pages
            //String webSite = "https://www.yellowpages.com/search?search_terms=bicycles&geo_location_terms=Providence%2C+RI";
            //String xPath = "//a[@class='business-name']";
            //string xPath = "//div[@class='v-card']";

            //Yahoo Finance
           // String webSite = "https://finance.yahoo.com/portfolio/p_0/view";
           // String xPath = "//div[@class='Ovx(s) Ovy(h)']"; // The entire table

            




            //String xPath2 = "//a[@class='phones phone primary']";
            // String[] headers = new string[] { "ID", "Company" };
            //String[] xPath =new string[2] { "//a[@class='class='phones phone primary']", "//a[@class='business-name']" };
            //foreach (string query in xPath)
            //    Console.WriteLine(query);
            // string xPath1 = xPath[0];

            // DataBase Column = List <T>
            ListNode scrapeNode = new ListNode(webSite,xPath);
            //scrapeNode.GetInnerHtml();


            // Scrape WebSite and Return a List<HtmlNode> list.
             List<HtmlNode> nodeList=scrapeNode.NodesToList();
            // List<HtmlNode> company=companyNode.NodesToList();
            // List<HtmlNode> phone=companyNode.NodesToList();
            

            // Create a tempDataTable from List var Name
             //DataTable nodeDataList=companyNode.NodesToTable(scrapeNode);


            //View DataTable / To Screen
            //scrapeNode.ViewDataTable(nodeList);
            scrapeNode.ToScreen(nodeList);



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
