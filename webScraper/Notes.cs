using System;
using System.Collections.Generic;
using System.Text;

namespace WebScraper
{
    class Notes
    {
        // Use List

        // Site 1: Arstechnica
        //String webSite="https://arstechnica.com/gaming/2019/04/terry-gilliams-don-quixote-film-finally-hits-the-big-screen-after-25-years/";
        //String webSite = "https://arstechnica.com/";
        // String xPath = "//p/text()";

        // Site 2: Yellow Pages: Working - Scrape one Class
       // String webSite = "https://www.yellowpages.com/search?search_terms=bicycles&geo_location_terms=Providence%2C+RI";
       // String xPath = "//a[@class='business-name']";

        // Site 3: Yellow Pages: Scrape 2 Classes
        // String webSite = "https://www.yellowpages.com/search?search_terms=bicycles&geo_location_terms=Providence%2C+RI";
        //String xPath = "//a[@class='business-name']";
        // String xPath1 = "//a[@class='class='phones phone primary']";
        //string xPath="//div[@class='v-card']";

        // Site None: Test Try / Catch erros
        // String webSite = "http://z.mo";
        // String xPath = "//a[@class='business-name']";

        // https://blog.scrapinghub.com/2016/10/27/an-introduction-to-xpath-with-examples
        // https://scrapinghub.github.io/xpath-playground/
        //String xPath = "//a[@class='business-name']"; // <-- XPATH

        // String searchPattern=@"\bBicycle\b";


        // Notes:

        //  the xPath String uses XPath:
        //    @ 	    attribute::
        //    .//    ./descendant-or-self::node()/
        //    // 	   descendant-or-self::node()/
        //    *      all child elements of the context node
        //    @*     all attributes of the context node
        //    [n] either [position() = n] = index: XPath index start at 1 not 0
        //    can use math //li[position()%2 = 0] : gets even elements positions
    }
}
