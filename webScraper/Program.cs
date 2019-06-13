using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Data.SqlClient;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Selenium;
using System.Xml;

namespace WebScraper
{
    class Program
    {
        static public void Main(string[] arg)
        {

            // Automated Yahoo Login - inherited classes
            // YahooFinance yf = new YahooFinance();
            // List<HtmlNode> stockTable = yf.Login();

            // From File
            FromFile scrape = new FromFile();
            List<HtmlNode> stockTable = scrape.ReadFile();

            // new code below here
            //


            NodetoString tableData = new NodetoString();
            tableData.StringNode(stockTable);
            string html = tableData.StringNode(stockTable);
            
            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            // // "/th"                        = Table Headers
            // // "/td[@aria-label='Symbol']"  = Data Columns

            // List<HtmlNode> headers = htmlDoc.DocumentNode
            //                                 .SelectNodes("//tr")
            //                                 .ToList();
            List<HtmlNode> stockData = htmlDoc.DocumentNode
                                            .SelectNodes("//td")
                                            .ToList();



            ArrayList aList = new ArrayList(stockData);
            string[,] row = new string[12,14];
           

            aList.CopyTo(row);






            //var node = htmlDoc.DocumentNode.SelectSingleNode("//tr");

            //HtmlNode sibling = node.NextSibling;

            //while (sibling != null)
            //{
            //    if (sibling.NodeType == HtmlNodeType.Element)
            //        Console.Write(sibling.InnerText);

            //    sibling = sibling.NextSibling;
            //}


            //table/tbody/tr[1]/td[1]
            // tr[1]
            //HtmlNode[] stockData = htmlDoc.DocumentNode
            //                               .SelectNodes("//td")
            //                               .ToArray();

            //foreach(HtmlNode items in stockData)
            //  Console.Write("{0}, ",items.InnerText);




            // tbody   Ancestor
            // tr   Parent
            // td   childern and siblngs
            // list of array rows take rows so they can 
            //ArrayList mylist = new ArrayList(5);



            ////foreach(var list in mylist)
            ////   Console.WriteLine(list);


            //Console.WriteLine(mylist.Count);



            //ListConverter cStockData = new ListConverter();
            //cStockData.ListToItem(stockData);
            //scrape.DataBaseTest(textData);
            //int count = 0;
            //for (int q = 0; q < 12; q++)
            //{
            //    for (int a = count; a < count+13; a++)
            //    {
            //        Console.Write("{0},",textData[a]);
            //    }
            //    Console.WriteLine();
            //    count = count + 16;
            //}

        }
        public static void PrintValues(String[] myArr, char mySeparator)
        {
            for (int i = 0; i < myArr.Length; i++)
                Console.Write("{0}{1}", mySeparator, myArr[i]);
            Console.WriteLine();
        }
    }
}

