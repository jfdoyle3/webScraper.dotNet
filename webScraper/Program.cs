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
          //String webSite="https://arstechnica.com/gaming/2019/04/terry-gilliams-don-quixote-film-finally-hits-the-big-screen-after-25-years/";
          // String webSite = "https://arstechnica.com/";
          //  String webClass = "//p/text()";



            // Site 2: Yellow Pages: Working - Scrape one Class
            String webSite = "https://www.yellowpages.com/search?search_terms=bicycles&geo_location_terms=Providence%2C+RI";
            String webClass = "//a[@class='business-name']";

            // Site 2: Yellow Pages: Scrape 2 Classes
            //String webSite = "https://www.yellowpages.com/search?search_terms=bicycles&geo_location_terms=Providence%2C+RI";
            //String webClass = "//a[@class='business-name']";
            //String webClass1 = "//a[@class='class='phones phone primary']";

            //
            // https://blog.scrapinghub.com/2016/10/27/an-introduction-to-xpath-with-examples
            // https://scrapinghub.github.io/xpath-playground/
            //String webClass = "//a[@class='business-name']"; // <-- XPATH
            //  the WebClass String uses XPath:
            //    @ 	    attribute::
            //    .//    ./descendant-or-self::node()/
            //    // 	   descendant-or-self::node()/
            //    *      all child elements of the context node
            //    @*     all attributes of the context node
            //    [n] either [position() = n] = index: XPath index start at 1 not 0
            //    can use math //li[position()%2 = 0] : gets even elements positions
            //


            // Scrape!!
            Scrape scrape = new Scrape(webSite, webClass);
            List<HtmlNode> value = scrape.NodesToList();
            //IEnumerable<HtmlNode> value = scrape.MultiClassScrape();
            scrape.ToScreen(value);
            scrape.ToDatabase();
            scrape.ToFile(value);       
        }
    }
}

