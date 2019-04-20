using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using HtmlAgilityPack;

namespace WebScraper
{
    public class SearchNode

    {
        private String WebSite { get; set; }
        private String WebClass { get; set; }
        private String RegexPattern {get; set;}

        private List<HtmlNode> classList = new List<HtmlNode>();
        public SearchNode(string webSite, string webClass, string pattern)
        {
            this.WebSite = webSite;
            this.WebClass = webClass;
            this.RegexPattern = pattern;

        }
       
        public void SearchScrape()
        {
            try
            {
               
                Regex search = new Regex(RegexPattern);
                HtmlWeb web = new HtmlWeb();
                HtmlDocument doc = web.Load(WebSite);
                List<string> extractedText = new List<string>();
                HtmlNodeCollection Node = doc.DocumentNode.SelectNodes(WebClass);

                foreach (HtmlNode xpath in Node)
                    if (Regex.IsMatch(xpath.InnerText, RegexPattern))
                        extractedText.Add(xpath.InnerText);

                foreach (string item in extractedText)
                    Console.WriteLine(item);

                Console.WriteLine();
                Console.WriteLine("Regex pattern: {0}", search);

            }
            catch (Exception)
            {

                Console.WriteLine("Can't Find Web Site");
            }
        }

    }
}
