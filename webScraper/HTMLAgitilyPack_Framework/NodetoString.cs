using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Data.SqlClient;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Selenium;

namespace WebScraper
{
    class NodetoString 
    {
        public dynamic StringNode(List<HtmlNode> stockTable)
        {
            List<String> stockHtml = new List<string>();
            List<String> stockText = new List<string>();

            foreach (HtmlNode node in stockTable)
            {
                stockHtml.Add(node.InnerHtml);
                stockText.Add(node.InnerText);
            }

            string html = String.Join("", stockHtml);
            string text = String.Join("", stockText);

            return html;
        }

        public dynamic NodesToTable(HtmlNode[] dataList)
        {
          // String[] headers = new string[2] { "ID", "Symbol" };
            DataTable tempTable = new DataTable();
            tempTable.Columns.Add("ID");
            tempTable.Columns.Add("Symbol");
            //for (int header = 0; header < headers.Length; header++)
            //{
            //    tempTable.Columns.Add(headers[header]);
            //}
            //foreach (HtmlNode header in dataList)
            //{
            //    tempTable.Columns.Add(header.InnerText);
            //}
          //  Add in Scraped Data to Temp Table
            for (int index = 0; index < dataList.Length; index++)
            {
                HtmlNode className = dataList[index];
                tempTable.Rows.Add(index, className.InnerText);
            }
            return tempTable;
        }
    }
}
