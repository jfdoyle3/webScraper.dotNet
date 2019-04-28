using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlAgilityPack;

namespace WebScraper
{
    public class MultiClass : Export
    {
        private String WebSite { get; set; }
        private String XPath { get;}
        private String XPath2 { get;}


        private readonly List<HtmlNode> classList = new List<HtmlNode>();
        private readonly List<HtmlNode> classList2 = new List<HtmlNode>();

        public MultiClass(String webSite, String xPath, String xPath2)
        {
            this.WebSite = webSite;
            this.XPath = xPath;
            this.XPath2 = xPath2;
        }


        public List<HtmlNode> MultiNodesToList()
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(WebSite);
            List<HtmlNode> classList = doc.DocumentNode
                                         .SelectNodes(XPath)
                                         .ToList();
            List<HtmlNode> classList2 = doc.DocumentNode
                                         .SelectNodes(XPath2)
                                         .ToList();
            classList.AddRange(classList2);
            return classList;
        }
    }
}
