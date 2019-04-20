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
                Console.WriteLine("Select: A: List of Text\n        B:Search the List");
                String choice=Console.ReadLine();
                String webSite = "https://www.yellowpages.com/search?search_terms=bicycles&geo_location_terms=Providence%2C+RI";
                String webClass = "//a[@class='business-name']";
                // Console.Write("Search: ");
                // String findMe = Console.ReadLine();
                // String pattern=@"\b"+findMe+"\\b";

                // Scrape!!

                if (choice.Equals("a") | (choice.Equals("A")))
                {
                    SingleNode scrapeNode = new SingleNode(webSite, webClass);
                    List<HtmlNode> node = scrapeNode.NodesToList();
                    scrapeNode.ToScreen(node);
                }
                else
                {
                    Console.Write("Search: ");
                    String findMe = Console.ReadLine();
                    String pattern = @"\b" + findMe + "\\b";
                    SearchNode search = new SearchNode(webSite, webClass, pattern);
                    search.Find();
                }
               
            }
            catch (Exception)
            {

                Console.WriteLine("Can't find website:\nnetwork problem\nwebsite not working");
            }
            
        }
    }
}
