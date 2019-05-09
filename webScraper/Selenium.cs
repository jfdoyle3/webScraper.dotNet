﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium
{
    class Selenium
    {
        public void RunSelenium()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.google.com");
            driver.FindElement(By.Name("q")).SendKeys("CareerDevs\n");
            // driver.Quit();
        }
        public void AltRunSelenium()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://www.demoga.com";

        }
    }
}
