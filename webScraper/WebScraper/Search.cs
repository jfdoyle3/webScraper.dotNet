using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using HtmlAgilityPack;

namespace WebScraper
{
    public class Search : Export

    {
        private String WebSite { get;  set; }
        private String XPath { get;  set; }
        private String RegexPattern { get; set; }

        
        private readonly List<string> extractedText = new List<string>();
        public Search(string webSite, string xPath, string pattern)
        {
            this.WebSite = webSite;
            this.XPath = xPath;
            this.RegexPattern = pattern;

        }
       
        public void Find()
        {
                         
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(WebSite);
               
            HtmlNodeCollection Node = doc.DocumentNode.SelectNodes(XPath);
            Regex search = new Regex(RegexPattern);

            foreach (HtmlNode node in Node)
                if (Regex.IsMatch(node.InnerText, RegexPattern))
                     extractedText.Add(node.InnerText);

           foreach (string foundPattern in extractedText)
               Console.WriteLine(foundPattern);

           Console.WriteLine();
           Console.WriteLine("Regex pattern: {0}", search);

           // return extractedText;
        }

    }
}
