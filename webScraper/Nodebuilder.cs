using System;
using System.Collections.Generic;
using System.Text;
using HtmlAgilityPack;

namespace WebScraper
{
    public class NodeBuilder
    {
        private String WebSite { get; set; }
        private String XPath { get; set; }

        private readonly StringBuilder builder = new StringBuilder();

        public NodeBuilder(String webSite, String xPath)
        {
            this.WebSite = webSite;
            this.XPath = xPath;

        }


        public void NodesToBuilder()
        {



            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(WebSite);
            HtmlNodeCollection classList = doc.DocumentNode.SelectNodes(XPath);

            foreach(HtmlNode node in classList)
            {
                builder.Append(node.InnerText+"\n");
            }
            builder.ToString();
            Console.WriteLine(builder);
            //  return classList;
        }
    }
}
