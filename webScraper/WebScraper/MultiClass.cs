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
        private String[] XPath { get; set; }
        private String[] Headers { get; set; }



        private readonly List<HtmlNode> classList = new List<HtmlNode>();

        public MultiClass(String webSite, String[] xPath, String[] headers)
        {
            this.WebSite = webSite;
            this.XPath = xPath;
            this.Headers = headers;
        }


        public dynamic MultiNodestoTable()
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(WebSite);

            DataTable tempTable = new DataTable();
            
            for (int xPathIndex = 0; xPathIndex < XPath.Length; xPathIndex++)
            {
                  
                    tempTable.Columns.Add(Headers[xPathIndex]);
              
                List<HtmlNode> classList = doc.DocumentNode
                                                 .SelectNodes(XPath[xPathIndex])
                                                 .ToList();
                
                //  Add in Scraped Data to Temp Table

                foreach (HtmlNode nodes in classList)
                {
                    tempTable.Rows.Add(nodes.InnerText);
                }
            }
            return tempTable;
        }
    }
            
}


