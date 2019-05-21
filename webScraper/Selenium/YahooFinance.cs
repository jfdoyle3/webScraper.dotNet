using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Selenium
{
    public class YahooFinance
    {
        public dynamic Login(string email, string password)
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

                IWebElement LoginField = driver.FindElement(By.Id("login-username"));
                LoginField.SendKeys(email);
                LoginField.SendKeys(Keys.Enter);

                WebDriverWait waitPassword= new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                waitPassword.Until(ExpectedConditions.ElementToBeClickable(By.Id("login-passwd")));


                IWebElement passwordField = driver.FindElement(By.Id("login-passwd"));
                passwordField.SendKeys(password);
                passwordField.SendKeys(Keys.Enter);

                driver.Url = "https://finance.yahoo.com/portfolio/p_2/view/v1";
                string currentURL = driver.Url;
                return currentURL;
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