using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using HtmlAgilityPack;

namespace WebScraper
{
   // Regex for 3 character Upper - Symbol
   // /(.*[A-Z]){3}/i
    public class Search : Export

    {
     
      private String RegexPattern { get; }

        
      private readonly List<string> extractedText = new List<string>();
      public Search(string pattern)
      {
          this.RegexPattern = pattern;

      }

        public dynamic Find(List<HtmlNode> stockTable)
        {

            //HtmlWeb web = new HtmlWeb();
            //HtmlDocument doc = web.Load(WebSite);

            //HtmlNodeCollection Node = doc.DocumentNode.SelectNodes(XPath);
            Regex search = new Regex(RegexPattern);

            foreach (HtmlNode node in stockTable)
                if (Regex.IsMatch(node.InnerText, RegexPattern))
                    extractedText.Add(node.InnerText);

            foreach (string foundPattern in extractedText)
                Console.WriteLine(foundPattern);

            Console.WriteLine();
            Console.WriteLine("Regex pattern: {0}", search);

            return extractedText;
        }

    }
}
