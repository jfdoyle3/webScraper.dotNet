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
    public class NodetoString : Export
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

        public dynamic NodesToTable(List <HtmlNode> headers, List<HtmlNode> stockList)
        {
            headers.RemoveRange(3,12);
            DataTable tempTable = new DataTable("tempStocks");
            

            foreach (var item in headers)
            {
                tempTable.Columns.Add(item.InnerText);
                Console.WriteLine(item.InnerText);
            }

            int count = 0;
            for (int rows = 0; rows < 12; rows++)
            {
                for (int s = count; s <= count + 3; s++)
                {
                    Console.Write(stockList[s].InnerText);
                    tempTable.Rows.Add(stockList[s].InnerText);
                }
                //Console.Write("<--|-->\n");
                count = count + 3;

            }

            return tempTable;
        }
    }
}
