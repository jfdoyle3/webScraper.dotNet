using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace WebScraper
{
    public static class Scrape
    {
        public static void bicycleYellow()
        {
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load("https://www.yellowpages.com/search?search_terms=bicycles&geo_location_terms=Providence%2C+RI");

            List<HtmlNode> HeaderNames = doc.DocumentNode
                .SelectNodes("//a[@class='business-name']").ToList();
            List<HtmlNode> phone = doc.DocumentNode
                .SelectNodes("//div[@class='phones phone primary']").ToList();

            for (int index = 0; index < HeaderNames.Count; index++)
            {
                HtmlAgilityPack.HtmlNode company = HeaderNames[index];
                HtmlAgilityPack.HtmlNode phones = phone[index];
                if (index%2==0)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("{0}  |  {1}", company.InnerText, phones.InnerText);
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("{0}  |  {1}",company.InnerText,phones.InnerText);
                }
                Console.ResetColor();
            }

        }

    }


}