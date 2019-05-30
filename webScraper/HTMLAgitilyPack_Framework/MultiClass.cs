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

        private String[] Headers { get; set; }



        private readonly List<HtmlNode> classList = new List<HtmlNode>();

        public MultiClass( String[] headers)
        {
            
            this.Headers = headers;
        }


        public dynamic MultiNodestoTable(string XPath)
        {
            //HtmlWeb web = new HtmlWeb();
            //HtmlDocument doc = web.Load(WebSite);

            DataTable tempTable = new DataTable();
            
            for (int xPathIndex = 0; xPathIndex < XPath.Length; xPathIndex++)
            {
                  
                 tempTable.Columns.Add(Headers[xPathIndex]);    
              
               // List<HtmlNode> classList = doc.DocumentNode
                //                              .SelectNodes(XPath[xPathIndex])
                //                              .ToList();
                
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


