using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using HtmlAgilityPack;

namespace WebScraper
{
    public class Export
    {
        
        public void ToScreen(List<HtmlNode> value)
        {
            for (int index = 0; index < value.Count; index++)
            {
                HtmlAgilityPack.HtmlNode className = value[index];
                if (index % 2 == 0)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("{0}", className.InnerText);
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("{0}", className.InnerText);
                
                }
                Console.ResetColor();
            }
        }

        public void ToFile(List<HtmlNode> value)
        {
            
            String fileName = @"D:\repository\webScraper\dotNET\Output.txt";
            StreamWriter streamWriter = new StreamWriter(fileName, true); //'True' appends to file.
            for (int index = 0; index < value.Count; index++)
            {
                HtmlAgilityPack.HtmlNode className = value[index];

                streamWriter.WriteLine("{0}", className.InnerText);
            }
            streamWriter.Close();
            Console.WriteLine("Exported to File: {0}",fileName);
        }

        public void ToDatabase()
        {
            Console.WriteLine("'Written to Database'");
        }
    }
}



           
                
            