using System;
using System.Collections.Generic;
using System.Text;
using HtmlAgilityPack;

namespace WebScraper
{
    public class Nodebuilder
    {
        private String WebSite { get; set; }
        private String WebClass { get; set; }

        private readonly StringBuilder builder = new StringBuilder();

        public Nodebuilder(String webSite, String webClass)
        {
            this.WebSite = webSite;
            this.WebClass = webClass;

        }


        public void NodesToBuilder()
        {



            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(WebSite);
            HtmlNodeCollection classList = doc.DocumentNode.SelectNodes(WebClass);

            foreach(HtmlNode node in classList)
            {
                builder.Append(node.InnerText);
            }

            Console.WriteLine(builder);
            //  return classList;
        }
    }
}
