using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace WebScraper
{
    public class Scrape : Export
    {
        private String WebSite { get; set; }
        private String WebClass { get; set; }
       // private String RegexPattern {get; set;}

        private  List<HtmlNode> classList = new List<HtmlNode>();
        public Scrape(String webSite, String webClass)
        {
            this.WebSite = webSite;
            this.WebClass = webClass;
         //   this.RegexPattern = pattern;
        }
      
        public List<HtmlNode> NodesToList(String webSite, String webClass)
        {

            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(webSite);
            for (int xpath = 0; xpath < webClass.Length; xpath++)
            {
                List<HtmlNode> classList = doc.DocumentNode
                                             .SelectNodes(webClass)
                                             .ToList();
            }


            return classList;
        }



        //public void SearchScrape()
        //{
        //    try
        //    {
                
        //        List<string> extractedText = new List<string>();
        //        Regex search = new Regex(RegexPattern);
        //        HtmlWeb web = new HtmlWeb();
        //        HtmlDocument doc = web.Load(WebSite);

        //        HtmlNodeCollection Node = doc.DocumentNode.SelectNodes(WebClass);
                
        //        foreach (HtmlNode xpath in Node)
        //            if (Regex.IsMatch(xpath.InnerText, RegexPattern))
        //                extractedText.Add(xpath.InnerText);

        //           foreach (string item in extractedText)
        //                Console.WriteLine(item);

        //            Console.WriteLine();
        //        Console.WriteLine("Regex pattern: {0}",search);

        //    }
        //    catch (Exception)
        //    {

        //        Console.WriteLine("Can't Find Web Site");
        //    }

        }


    }


   
    
