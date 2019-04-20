using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using HtmlAgilityPack;

namespace WebScraper
{
    public class SearchNode : Export

    {
        private String WebSite { get; set; }
        private String WebClass { get; set; }
        private String RegexPattern {get; set;}

        
        private readonly List<string> extractedText = new List<string>();
        public SearchNode(string webSite, string webClass, string pattern)
        {
            this.WebSite = webSite;
            this.WebClass = webClass;
            this.RegexPattern = pattern;

        }
       
        public void Find()
        {
                         
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(WebSite);
               
            HtmlNodeCollection Node = doc.DocumentNode.SelectNodes(WebClass);
            Regex search = new Regex(RegexPattern);

            foreach (HtmlNode xpath in Node)
                if (Regex.IsMatch(xpath.InnerText, RegexPattern))
                     extractedText.Add(xpath.InnerText);

           foreach (string foundPattern in extractedText)
               Console.WriteLine(foundPattern);

           Console.WriteLine();
           Console.WriteLine("Regex pattern: {0}", search);

           // return extractedText;


        }

    }
}
