using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;


namespace WebScraper
{
    
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                String webSite = "https://www.yellowpages.com/search?search_terms=bicycles&geo_location_terms=Providence%2C+RI";
                String webClass = "//a[@class='business-name']";

                // Scrape!!
                SingleNode scrapeNode = new SingleNode(webSite, webClass);
                List<HtmlNode> node=scrapeNode.NodesToList();
                scrapeNode.ToScreen(node);
                
               
            }
            catch (Exception)
            {

                Console.WriteLine("Can't find website:\nnetwork problem\nwebsite not working");
            }
            
        }
    }
}
