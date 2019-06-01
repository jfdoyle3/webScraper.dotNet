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

        public dynamic NodesToTable(List<HtmlNode> headerList, List<HtmlNode> stockList)
        {
            // String[] headers = new string[2] { "ID", "Symbol" };
           // headerList.RemoveRange(13, 2);
            DataTable tempTable = new DataTable("tempStocksTable");
            tempTable.Columns.Add("ID");
            for (int header = 0; header < headerList.Count; header++)
            {
                tempTable.Columns.Add(headerList[header].InnerText);
              
            }
            foreach(DataColumn column in tempTable.Columns)
            {
                
                Console.Write(" {0} |", column.ColumnName);
            }
            //object[] o = { "1","Ravi", 500 };
            //object[] p = { "2", "Savi", 600 };
            //tempTable.Rows.Add(o);
            //tempTable.Rows.Add(p);
           // tempTable.Rows.Add(0, stockList[1].InnerText,stockList[2].InnerText);            //foreach (DataRow row in tempTable.Rows)
            foreach (DataRow row in tempTable.Rows)
            {
                Console.WriteLine();
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item);
                }
            }

            //  Add in Scraped Data to Temp Table
            //for (int index = 0; index < dataList.Length; index++)
            //{
            //    HtmlNode className = dataList[index];
            //    tempTable.Rows.Add(index, className.InnerText);
            //}
            return tempTable;
        }
    }
}
