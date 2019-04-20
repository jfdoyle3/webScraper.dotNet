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
        static void Main(string[] arg)
        {
            try
            {
                String webSite = "https://www.yellowpages.com/search?search_terms=bicycles&geo_location_terms=Providence%2C+RI";
                String webClass = "//a[@class='business-name']";
                String pattern=@"\bBicycle\b";

               // Scrape!!


                 SingleNode scrapeNode = new SingleNode(webSite, webClass);
                 List<HtmlNode> node=scrapeNode.NodesToList();
                 scrapeNode.ToScreen(node);
               //SearchNode search = new SearchNode(webSite, webClass, pattern);
               // search.Find();
                
               
            }
            catch (Exception)
            {

                Console.WriteLine("Can't find website:\nnetwork problem\nwebsite not working");
            }
            
        }
    }
}
