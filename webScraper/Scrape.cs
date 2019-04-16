using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace WebScraper
{
    public class Scrape : Export
    {
        private String WebSite { get; set; }
        private String WebClass { get; set; }
        private String WebClass1 { get; set; }
        private readonly List<HtmlNode> classList = new List<HtmlNode>();
        public Scrape(String webSite, String webClass)
        {
            this.WebSite = webSite;
            this.WebClass = webClass;
           // this.WebClass1 = webClass1;

        }
        
        public List<HtmlNode> NodesToList()
        {
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(WebSite);
            List<HtmlNode> classList = doc.DocumentNode
                .SelectNodes(WebClass).ToList();
            
          
            return classList; 
        }

        public IEnumerable<HtmlNode> MultiClassScrape()
        {
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(WebSite);
            List<HtmlNode> classList1 = doc.DocumentNode
                .SelectNodes(WebClass).ToList();
            List<HtmlNode> classList2 = doc.DocumentNode
                .SelectNodes(WebClass1).ToList();

            IEnumerable<HtmlNode> completeList = classList1.Concat(classList2);
            return completeList;

            
        }
          
        
    }
}
