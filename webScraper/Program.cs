using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
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
           
              //String[] xPath =new string[2] { "//a[@class='class='phones phone primary']", "//a[@class='business-name']" };
                String xPath = "//a[@class='business-name']";
                ListNode scrapeNode = new ListNode(webSite, xPath);
                List<HtmlNode> node = scrapeNode.NodesToList();
                MultiClass table = new MultiClass(webSite,xPath);
                DataTable scrapeData=table.NodestoTable(node);
                table.ToDatabase(scrapeData);
        }
           catch (Exception)
            {

                Console.WriteLine("Error:\nIn Code\nnetwork problem\nwebsite not working\nXPath error");
            }

        }
    }
}
