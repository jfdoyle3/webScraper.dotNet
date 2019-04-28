using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Data.SqlClient;


namespace WebScraper
{
    
    class Program
    {
        static void Main(string[] arg)
        {
            try
            {
                String webSite = "https://www.yellowpages.com/search?search_terms=bicycles&geo_location_terms=Providence%2C+RI";
                String xPath = "//a[@class='business-name']";
                ListNode scrapeNode = new ListNode(webSite, xPath);
                List<HtmlNode> node = scrapeNode.NodesToList();
                //scrapeNode.ToScreen(node);
                scrapeNode.ToDatabase(node);
                ScrapedDatabase view = new ScrapedDatabase();
            //view.InsertDatabase();
             view.DisplayData();


            //Console.WriteLine("Select: A: List using this XPath: {0}\n" +
            //                  "        B: Search the List\n" +
            //                  "        C: MultiScrape\n" +
            //                  "        D: NodeBuilder",xPath);
            //String choice=Console.ReadLine();


            //// Scrape!!

           
        }


    
            catch (Exception)
            {

                Console.WriteLine("Error:\nIn Code\nnetwork problem\nwebsite not working\nXPath error");
            }
            
        }
    }
}
