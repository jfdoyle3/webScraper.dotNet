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
        private String WebClass { get; set; }
        private String WebClass2 { get; set; }


        private readonly List<HtmlNode> classList = new List<HtmlNode>();
        private readonly List<HtmlNode> classList2 = new List<HtmlNode>();

        public MultiClass(String webSite, String webClass, String webClass2)
        {
            this.WebSite = webSite;
            this.WebClass = webClass;
            this.WebClass2 = webClass2;

        }


        public List<HtmlNode> MultiNodesToList()
        {



            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(WebSite);
            List<HtmlNode> classList = doc.DocumentNode
                                         .SelectNodes(WebClass)
                                         .ToList();
            List<HtmlNode> classList2 = doc.DocumentNode
                                         .SelectNodes(WebClass2)
                                         .ToList();
            classList.AddRange(classList2);
            return classList;

        }
    }
}
