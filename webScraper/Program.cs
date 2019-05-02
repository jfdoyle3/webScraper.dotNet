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
            String webSite = "https://www.yellowpages.com/search?search_terms=bicycles&geo_location_terms=Providence%2C+RI";
            String xPath = "//a[@class='business-name']";
            String xPath2 = "//a[@class='phones phone primary']";
            // String[] headers = new string[] { "ID", "Company" };
            //String[] xPath =new string[2] { "//a[@class='class='phones phone primary']", "//a[@class='business-name']" };
            //foreach (string query in xPath)
            //    Console.WriteLine(query);


            // DataBase Column = List <T>
            // ListNode  companyNode= new ListNode(webSite,xPath);
            MultiClass bikeShops = new MultiClass(webSite, xPath, xPath2);

            // Scrape WebSite and Return a List<HtmlNode> list.
            // List<HtmlNode> company=companyNode.NodesToList();
            List<HtmlNode> shopPhone = bikeShops.MultiNodesToList();

            // Create a tempDataTable from List var Name
            // DataTable companyList=companyNode.NodesToTable(company);
            // bikeShops.MultiNodesToTable();

            //View DataTable
            //companyNode.ViewDataTable(companyList);
            // bikeShops.ViewDataTable(companyList);


            // Write to tempDataTable to Database
            // companyNode.ToDatabase(companyList);

            // Display Database
            // ScrapedDatabase view = new ScrapedDatabase();
            // view.DisplayData();

            bikeShops.ToScreen(shopPhone);









            //}       
            //catch (Exception)
            //{

            //  Console.WriteLine("Error:\nIn Code\nnetwork problem\nwebsite not working\nXPath error");
            //}

        }
    }
}
