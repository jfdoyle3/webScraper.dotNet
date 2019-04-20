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
               


                Console.WriteLine("Select: A: List of Text\n" +
                                  "        B: Search the List\n" +
                                  "        C: MultiScrape");
                String choice=Console.ReadLine();
                

                // Scrape!!
                switch  (choice)
                {
                    case "a":
                    case "A":
                        SingleNode scrapeNode = new SingleNode(webSite, webClass);
                        List<HtmlNode> node = scrapeNode.NodesToList();
                        scrapeNode.ToScreen(node);
                        break;

                    case "b":
                    case "B":
                        Console.WriteLine("Search: ");
                        String findMe = Console.ReadLine();
                        String pattern = @"\b" + findMe + "\\b";
                        SearchNode search = new SearchNode(webSite, webClass, pattern);
                        search.Find();
                        break;

                    case "c":
                    case "C":
                        String webClass2 = "//div[@class='phones phone primary']";
                        MultiClass MultiNode = new MultiClass(webSite, webClass, webClass2);
                        List<HtmlNode> multiNode = MultiNode.MultiNodesToList();
                        MultiNode.ToScreen(multiNode);
                        break;
                }
               
            }
            catch (Exception)
            {

                Console.WriteLine("Error:\nIn Code\nnetwork problem\nwebsite not working\nXPath error");
            }
            
        }
    }
}
