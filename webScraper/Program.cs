using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WebScraper
{
    class Program
    {
        static void Main(string[] args)
        {

            String webSite = "https://www.yellowpages.com/search?search_terms=bicycles&geo_location_terms=Providence%2C+RI";
            Scrape.Extract(webSite);

        }
    }
}
