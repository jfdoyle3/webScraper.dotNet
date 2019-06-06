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
    public class StockDataTable
    {
        public static void StkDataTbl()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Dosage", typeof(int));
            table.Columns.Add("Drug", typeof(string));
            table.Columns.Add("Patient", typeof(string));
            table.Columns.Add("Date", typeof(DateTime));

            // Here we add five DataRows.
            table.Rows.Add(25, "Indocin", "David", DateTime.Now);
            table.Rows.Add(50, "Enebrel", "Sam", DateTime.Now);
            table.Rows.Add(10, "Hydralazine", "Christoff", DateTime.Now);
            table.Rows.Add(21, "Combivent", "Janet", DateTime.Now);
            table.Rows.Add(100, "Dilantin", "Melanie", DateTime.Now);

        }
        public static void NodesToTable(List<HtmlNode> headers)
        {
            // String[] headers = new string[3] { "ID", "Symbol","Last Price" };
            //headerList.RemoveRange(13, 2);
            DataTable tempTable = new DataTable("tempStocks");
           // tempTable.Columns.Add("ID");
            //for (int header = 0; header < headers.Count; header++)
            //{
            //    tempTable.Columns.Add(headers[header]);

            //}
            foreach (var item in headers)
            {
                tempTable.Columns.Add(item.InnerText);
            }
            foreach (DataColumn column in tempTable.Columns)
            {

                Console.Write(" {0} |", column.ColumnName);
            }
            //for (int rows = 0; rows < stockList.Count; rows++)
            //{

            //    object[] o = { rows, stockList[0].InnerText, stockList[1].InnerText };
            //    //object[] p = { "2", "Savi", 600 };
            //    tempTable.Rows.Add(o);
            //    //tempTable.Rows.Add(p);
            //    //tempTable.Rows.Add(0, stockList[1].InnerText,stockList[2].InnerText);            //foreach (DataRow row in tempTable.Rows)
            //}
            //    foreach (DataRow row in tempTable.Rows)
            //{
            //    Console.WriteLine();
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item);
            //    }
            //}
            //int count = 0;
            //for (int rows = 0; rows < 12; rows++)
            //{
            //    DataRow dt = tempTable.NewRow();
            //    for (int s = count; s <= count + 15; s++)
            //    {
            //        Console.Write("{0}", stockList[s]);
            //        tempTable.Rows.Add(rows, stockList[s]);
            //    }
            //    count = count + 16;
            //    Console.WriteLine();
            //}
            //  Add in Scraped Data to Temp Table
            //for (int index = 0; index < dataList.Length; index++)
            //{
            //    HtmlNode className = dataList[index];
            //    tempTable.Rows.Add(index, className.InnerText);
            //}
            //   return tempTable;
        }
    }
}
