using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

// Enable Wait line/method
// Other Methods may need this
using OpenQA.Selenium.Support.UI;

namespace Selenium
{
    public class YahooFinance
    {


        
        public static void Login(string email, string password)
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("https://finance.yahoo.com");

                WebDriverWait waitSignIn = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                waitSignIn.Until(ExpectedConditions.ElementToBeClickable(By.Id("uh-signedin")));

                IWebElement signIn = driver.FindElement(By.Id("uh-signedin"));
                 signIn.Click();

                WebDriverWait waitLogin = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                waitLogin.Until(ExpectedConditions.ElementToBeClickable(By.Id("login-username")));

                IWebElement loginBox = driver.FindElement(By.Id("login-username"));
                loginBox.SendKeys(email);
                loginBox.SendKeys(Keys.Enter);

                WebDriverWait waitPw = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                waitPw.Until(ExpectedConditions.ElementToBeClickable(By.Id("login-passwd")));


                IWebElement pwBox = driver.FindElement(By.Id("login-passwd"));
                pwBox.SendKeys(password);
                pwBox.SendKeys(Keys.Enter);

                //WebDriverWait waitPort = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                //waitPort.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("My Portfolio")));

                //IWebElement portfolio = driver.FindElement(By.LinkText("My Portfolio"));
                //portfolio.Click();

                //WebDriverWait waitStockList = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
                //waitStockList.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("Stocks")));
                //waitStockList.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[@href='/portfolio/p_2/view']")));

                //IWebElement stocks = driver.FindElement(By.LinkText("Stocks"));
                //IWebElement stocks = driver.FindElement(By.XPath("//a[@href='/portfolio/p_2/view']"));
                //stocks.Click();

            }
        }
        //public static void WaitForIt(string id)
        //{
        //    using (IWebDriver driver = new ChromeDriver())
        //    {
        //        WebDriverWait waitSignIn = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        //        waitSignIn.Until(ExpectedConditions.ElementToBeClickable(By.Id(id)));

        //    }

        //}        
    }
}