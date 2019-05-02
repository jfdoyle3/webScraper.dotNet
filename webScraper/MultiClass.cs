using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using HtmlAgilityPack;

namespace WebScraper
{
    public class MultiClass : Export
    {
        private String WebSite { get; set; }
        private String XPath { get; set;  }
        private String XPath2 { get; set; }



        private readonly List<HtmlNode> classList = new List<HtmlNode>();
        private readonly List<HtmlNode> classList2 = new List<HtmlNode>();

        public MultiClass(String webSite, String xPath, String xPath2)
        {
            this.WebSite = webSite;
            this.XPath = xPath;
            this.XPath2 = xPath2;
            

        }


        public List<HtmlNode> MultiNodesToList()
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(WebSite);
            List<HtmlNode> classList = doc.DocumentNode
                                         .SelectNodes(XPath)
                                         .ToList();
            List<HtmlNode> classList2 = doc.DocumentNode
                                         .SelectNodes(XPath2)
                                         .ToList();
            classList.AddRange(classList2);
            return classList;
        }
        public dynamic MultiNodestoTable(List<HtmlNode> classList, List<HtmlNode> classList2)
        {
            String[] headers = new string[] { "ID", "Company", "Phone" };
            DataTable tempTable = new DataTable();

            for (int header = 0; header < headers.Length; header++)
                tempTable.Columns.Add(headers[header]);

            //Add in Scraped Data to Temp Table
            for (int index = 1; index < classList.Count; index++)
            {
                HtmlNode className = classList[index];
                HtmlNode className2 = classList2[index];
                tempTable.Rows.Add(index, className.InnerText);
                tempTable.Rows.Add(index,className2.InnerText);
            }
            
            return tempTable;
        }
        public void MultiNodesToTable()
        {
            
            DataTable tempTable = new DataTable();

            String[] headers = new string[] { "ID", "Company", "Phone" };
            for (int header = 0; header < headers.Length; header++)
                tempTable.Columns.Add(headers[header]);

            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(WebSite);
            List<HtmlNode> classList = doc.DocumentNode
                                         .SelectNodes(XPath)
                                         .ToList();

            List<HtmlNode> classList2 = doc.DocumentNode
                                         .SelectNodes(XPath2)
                                          .ToList();
            classList.AddRange(classList2);
            foreach(HtmlNode item in classList)
                Console.WriteLine(item);
                                         
         // Add in Scraped Data to Temp Table
            //for (int index = 1; index < classList.Count; index++)
            //{
            //    HtmlNode className = classList[index];
            //    HtmlNode className2 = classList2[index];
            //    tempTable.Rows.Add(index, className.InnerText);
            //    tempTable.Rows.Add(index, className2.InnerText);
            //}
            // return tempTable;
        }



    }
}
