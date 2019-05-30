using System;
using System.Collections.Generic;
using System.Text;
using HtmlAgilityPack;
using System.IO;
using System.Linq;
using System.Data;


namespace WebScraper
{
    class FromFile : Export
    {
        public List<HtmlNode> ReadFile()
        {
            string stocks = File.ReadAllText(@"C:\website\Stocks.htm");
            HtmlDocument htmlFile = new HtmlDocument();

            htmlFile.LoadHtml(stocks);

            //HtmlNode classList = htmlDoc.DocumentNode.SelectSingleNode("//tr");
            //Console.WriteLine(classList.InnerText);


            List<HtmlNode> classList = htmlFile.DocumentNode.SelectNodes("//tr").ToList(); ;

            //int count = 0;
            //foreach (HtmlNode node in classList)
            //{
            //    count++;
            //    Console.WriteLine("{0} -->  {1}", count, node.InnerText.ToString());
            //}

            return classList;
        }
    }
}
