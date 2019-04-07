using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace webScraper
{
    class Scrape
    { 
        //   HtmlAgilityPack.HtmlDocument doc = doc.Load("file:///D:/repository/webScraper/HTML/Table.html");
        //   var title = doc.DocumentNode
        //       .SelectNodes("//a[@class='brand-logo']").ToList();
        //   foreach(var names in title)
        //   {
        //       Console.WriteLine(names.InnerText);
        //  }
        public static void Extract()
        {
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load("https://www.yellowpages.com/search?search_terms=bicycles&geo_location_terms=Providence%2C+RI");
           
            var HeaderNames = doc.DocumentNode
              .SelectNodes("//a[@class='business-name']").ToList();
            var PhoneNumbers = doc.DocumentNode
              .SelectNodes("//div[@class='phones phone primary']").ToList();


            for (int index = 0; index < HeaderNames.Count; index++)

            {
                HtmlAgilityPack.HtmlNode companyName = HeaderNames[index];
                HtmlAgilityPack.HtmlNode phoneNumber = PhoneNumbers[index];
                Console.Write("{0} | {1}\n", companyName.InnerText, phoneNumber.InnerText);
            }


        }
    }
}
