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
        private String[] WebClass { get; set; }

        
        private readonly List<HtmlNode> classList = new List<HtmlNode>();
        public Scrape(String webSite, String[] webClass)
        {
            this.WebSite = webSite;
            this.WebClass[2] = webClass[2];
            // this.WebClass1 = webClass1;

        }

        public List<HtmlNode> NodesToList()
        {

            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(WebSite);
            for (int xpath=0; xpath < WebClass.Length; xpath++)
            {
               List<HtmlNode> classList = doc.DocumentNode
               .SelectNodes(WebClass[xpath]).ToList();
            }
            

            return classList;
        }

    

    //public void  MultiClassScrape()
    //{
    //    HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
    //    HtmlAgilityPack.HtmlDocument doc = web.Load(WebSite);
    //    List<HtmlNode> classList1 = doc.DocumentNode
    //        .SelectNodes(WebClass).ToList();
    //    List<HtmlNode> classList2 = doc.DocumentNode
    //        .SelectNodes(WebClass1).ToList();
    //    //foreach to compile list maybe


    }



      

}
    
