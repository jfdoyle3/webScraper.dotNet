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

            String webSite = "https://www.yellowpages.com/search?search_terms=bicycles&geo_location_terms=Providence%2C+RI";
            String webClass = "//a[@class='business-name']";


            // Scrape!!
            Scrape scrape = new Scrape(webSite, webClass);
            scrape.SingleClassScrape();
            
            //for (int index = 0; index < ClassName.Count; index++)
            //{
            //    HtmlAgilityPack.HtmlNode className = ClassName[index];
            //    if (index % 2 == 0)
            //    {
            //        Console.BackgroundColor = ConsoleColor.DarkGray;
            //        Console.ForegroundColor = ConsoleColor.DarkBlue;
            //        Console.WriteLine("{0}  |  ", className.InnerText);
            //    }
            //    else
            //    {
            //        Console.BackgroundColor = ConsoleColor.DarkBlue;
            //        Console.ForegroundColor = ConsoleColor.DarkGray;
            //        Console.WriteLine("{0}  |  ", className.InnerText);
            //    }
            //    Console.ResetColor();

            }
    }
}
