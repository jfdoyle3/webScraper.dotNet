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

            // Site 1: Proving Ground
            String webSite = "https://arstechnica.com/";
            String webClass = "//title";



            // Site 2: Yellow Pages: Working
            //String webSite = "https://www.yellowpages.com/search?search_terms=bicycles&geo_location_terms=Providence%2C+RI";
            //String webClass = "//a[@class='business-name']"; // <-- XPATH


            // https://blog.scrapinghub.com/2016/10/27/an-introduction-to-xpath-with-examples
            // https://scrapinghub.github.io/xpath-playground/
            //  the WebClass String uses these:
            //    @ 	    attribute::
            //    .//    ./descendant-or-self::node()/
            //    // 	   descendant-or-self::node()/
            //    *      all child elements of the context node
            //    @*     all attributes of the context node
            //    [n]    [position() = n]


            // Scrape!!
            Scrape scrape = new Scrape(webSite, webClass);
            List<HtmlNode> value = scrape.SingleClassScrape();
            scrape.ToScreen(value);
            scrape.ToDatabase();
            scrape.ToFile();       
        }
    }
}

