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
    public class ListConverter
    {
        public dynamic ListToItem(List<HtmlNode> stockList)
        {
            List<String> stockHtml = new List<string>();
            List<String> stockText = new List<string>();

            foreach (HtmlNode node in stockList)
            {
                stockHtml.Add(node.InnerHtml);
                stockText.Add(node.InnerText);
            }

            string html = String.Join("", stockHtml);
            string text = String.Join(",", stockText);

            string[] stockRow = text.Split(",");
            // 16 places per row
            //int count = 0;
            //for (int rows = 0; rows < 12; rows++)
            //{

            //    for (int s = count; s <= count + 16; s++)
            //    {
            //        Console.Write(stockRow[s]);
            //    }
            //    count = count + 16;
            //    Console.WriteLine();
            //}
            // 0 - 15 AMD
            // 16 - 31 CVS
            // 32 - 47  stock row 3
            // 48 - 63  stock row 4
            // etc...
            // 5,64-79; 6,80-95; 7,96,111; 8,112-127;
            // 9,128-143; 10,144-159; 11,160-175; 12,176-191;


            //for (int i = 0; i < 15; i++)
            //{
            //    Console.Write(stockRow[i]);
            //}

            //stockList.RemoveRange(0, 16);
            //Console.WriteLine();
            //for (int i = 0; i < 16; i++)
            //{
            //    Console.Write(stockList[i].InnerText);
            //}
            //foreach (var item in stockRow)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(text.Count());

            return stockRow;

        }
    }
}
