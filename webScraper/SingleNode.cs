using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace WebScraper
{
    public class SingleNode : Export
    {
        private String WebSite { get; set; }
        private String WebClass { get; set; }


       private readonly List<HtmlNode> classList = new List<HtmlNode>();
          
        public SingleNode(String webSite, String webClass)
        {
            this.WebSite = webSite;
            this.WebClass = webClass;
           
        }

       
        public List<HtmlNode> NodesToList()
        {



                HtmlWeb web = new HtmlWeb();
                HtmlDocument doc = web.Load(WebSite);
                List<HtmlNode> classList = doc.DocumentNode
                                             .SelectNodes(WebClass)
                                             .ToList(); 
                
                return classList;

        }
    }
  
}


