using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace WebScraper
{
    public class Scrape
    {
        private String WebSite { get; set; }
        private String WebClass { get; set; }
        private readonly List<HtmlNode> ClassList;
        public Scrape(String webSite, String webClass)
        {
            this.WebSite = webSite;
            this.WebClass = webClass;
        }

        public List<HtmlNode> SingleClassScrape()
        {
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(WebSite);

            List<HtmlNode> ClassList = doc.DocumentNode
                .SelectNodes(WebClass).ToList();

            return ClassList;
            
        }
        public void ConsoleOutput()
        {
            for (int index = 0; index < ClassList.Count; index++)
            {
                HtmlAgilityPack.HtmlNode className = ClassList[index];
                if (index % 2 == 0)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("{0}  |  ", className.InnerText);
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("{0}  |  ", className.InnerText);
                }
                Console.ResetColor();
            }
        }
    }
}
