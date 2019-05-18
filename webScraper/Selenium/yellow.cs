using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

// Enable Wait line/method
// Other Methods may need this
using OpenQA.Selenium.Support.UI;

namespace Selenium
{
    public class Yellow
    {
        public static void BikeYellow()
        {
            
            using (IWebDriver driver = new ChromeDriver())
            {
                // Two ways to GET a URL
                 // driver.Navigate().GoToUrl("https://www.yellowpages.com/search?search_terms=bicycles&geo_location_terms=Providence%2C+RI");
                 driver.Url = "https://www.yellowpages.com/search?search_terms=bicycles&geo_location_terms=Providence%2C+RI";
                 IList<IWebElement> businessNames = driver.FindElements(By.ClassName("business-name"));

                foreach (IWebElement names in businessNames)
                    Console.WriteLine(names.Text);    
            }     
        }
    }
}
