using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace WebScraper
{
    class Scrape
    { 
       
        public static void Extract()
        {
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load("https://www.yellowpages.com/search?search_terms=bicycles&geo_location_terms=Providence%2C+RI");
           
            List<HtmlNode> HeaderNames = doc.DocumentNode
              .SelectNodes("//a[@class='business-name']").ToList();
            List<HtmlNode> PhoneNumbers = doc.DocumentNode
              .SelectNodes("//div[@class='phones phone primary']").ToList();

            for (int index = 0; index < HeaderNames.Count; index++)

            {
                HtmlAgilityPack.HtmlNode companyName = HeaderNames[index];
                HtmlAgilityPack.HtmlNode phoneNumber = PhoneNumbers[index];
 
              if (index%2==0)
                {
                    
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("{0}|{1}\n", companyName.InnerText,phoneNumber.InnerText);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("{0}|{1}\n", companyName.InnerText, phoneNumber.InnerText);

                }
                Console.ResetColor();
            }


        }
    }
}
