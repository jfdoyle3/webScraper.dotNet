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
            List<HtmlNode> value = scrape.SingleClassScrape();
            scrape.ToScreen(value);

                   
        }
    }
}

