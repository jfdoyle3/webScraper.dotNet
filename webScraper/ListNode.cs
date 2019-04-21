using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlAgilityPack;

namespace WebScraper
{
    public class ListNode : Export
    {
        private String WebSite { get; set; }
        private String XPath { get; set; }

        private readonly List<HtmlNode> classList = new List<HtmlNode>();

        public ListNode(String webSite, String xPath)
        {
            this.WebSite = webSite;
            this.XPath = xPath;

        }


        public List<HtmlNode> NodesToList()
        {



            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(WebSite);
            List<HtmlNode> classList = doc.DocumentNode
                                           .SelectNodes(XPath)
                                           .ToList();

           
           
              return classList;
        }
    }
}
