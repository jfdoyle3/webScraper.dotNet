using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace htmlAgilitypack_scrape
{
    class Program
    {
        static void Main(string[] args)
        {
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load("https://www.yellowpages.com/search?search_terms=bicycles&geo_location_terms=Providence%2C+RI");

            var HeaderNames = doc.DocumentNode
                .SelectNodes("//a[@class='business-name']").ToList();
            var PhoneNumbers = doc.DocumentNode
                .SelectNodes("//div[@class='phones phone primary']").ToList();

            foreach (var companyName in HeaderNames)
            {
                Console.WriteLine(companyName.InnerText);
            }
            foreach (var phone in PhoneNumbers)
            {
                Console.WriteLine(phone.InnerText);
            }
            Console.ReadLine();
        }
    }
}
