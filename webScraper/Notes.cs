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





        

        // Yellow Pages - Working/Test
        //String webSite = "https://www.yellowpages.com/search?search_terms=bicycles&geo_location_terms=Providence%2C+RI";
        // String xPath = "//a[@class='business-name']";
        //string xPath = "//div[@class='v-card']";
       


        //Yahoo Finance
        // String webSite = "https://finance.yahoo.com/portfolio/p_0/view";
        //  String xPath = "//";


        //Top of finance Table
        //String xPath = "//div[@class='']";
        // String xPath="//div id='pf-detail-table' class='Pos(r) '";
        // String xPath="//div[@id='pf-detail-table']";

        // String xPath = "//div[@class='Ovx(s) Ovy(h)']"; // The entire table
        //String xPath = "//div[@class='Ovx(a)']"; 
        //String xPath = "//*[@id='pf-detail-table']/div[1]/table/tbody/tr[1]/td[2]";
        // label in table
        // String xPath= "//td[@aria-label='Change']";
        //String xPath = "//table[@class='W(100%)']";
     
       

        
        //String[] xPath = new "//a[@class='phones phone primary']";
        // String[] headers = new string[2] { "Company", "Phone"};
        //String[] xPath =new string[2] { "//a[@class='business-name']", "//a[@class='phones phone primary']" };
        // String[] headers = new string[2] { "Company","Phone" };
        //String[] xPath = new string[2] { "//a[@class='business-name']","//div[@class='phones phone primary']"};
       

        //TablePrinter t = new TablePrinter("id", "Column A", "Column B","Column C","Column ABC");
        //t.AddRow(1, "Val A1", "Val B1","Val C1","Val 123");
        //t.AddRow(2, "Val A2", "Val B2","Val C2","Val 456");
        //t.AddRow(100, "Val A100", "Val B100","Val C100","Val 888");
        //t.Print();

        // Automated Yahoo Login - inherited classes
        //YahooFinance yf = new YahooFinance();
        //List<HtmlNode> stockTable = yf.Login();

        // Working code: Crashes: Data overflow
        //DataTable tempStockTable = yf.NodesToTable(stockTable);
        //yf.ToDatabase(tempStockTable);
    }
}
