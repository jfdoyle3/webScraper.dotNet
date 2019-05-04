using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
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

            //TODO: HtmlWeb / Document load to the Connection Class
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(WebSite);

            List<HtmlNode> classList = doc.DocumentNode
                                           .SelectNodes(XPath)
                                           .ToList();
           
              return classList;
        }
        public dynamic NodesToTable(List<HtmlNode> classList)
        {
            String[] headers = new string[] { "ID", "Company" };
            DataTable tempTable = new DataTable();

            //for (int header = 0; header < headers.Length; header++)
            //    tempTable.Columns.Add(headers[header]);
            foreach (string header in headers)
                tempTable.Columns.Add(header);

            //Add in Scraped Data to Temp Table
            for (int index = 1; index < classList.Count; index++)
            {
                HtmlNode className = classList[index];
                tempTable.Rows.Add(index, className.InnerText);
            }
            return tempTable;
        }
        public void GetInnerHtml()
        {

            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(WebSite);
            //HtmlNodeCollection htmlNodes = doc.DocumentNode.SelectNodes(XPath);
        
            //foreach (HtmlNode node in htmlNodes)
            //{
            //    Console.WriteLine(node.InnerText);
            //}
        }
    }
}
