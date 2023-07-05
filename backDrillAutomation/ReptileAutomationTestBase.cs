using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace backDrillAutomation
{
    internal class ReptileAutomationTestBase
    {
        [Test]
        public void OpenAndClosePositions()
        {
            // Set up ChromeDriver
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            IWebDriver driver = new ChromeDriver(options);

            // Open the eToro website
            driver.Navigate().GoToUrl("https://www.etoro.com/portfolio/overview");
            IWebElement userName = driver.FindElement(By.Id("username"));
            IWebElement password = driver.FindElement(By.Id("password"));
            userName.SendKeys("BetaTester30");
            password.SendKeys("Aa123456");
            String userNameText = userName.Text;
            IWebElement btn_login = driver.FindElement(By.XPath("//button[@class='button-default blue-btn']"));
            btn_login.Click();
            Thread.Sleep(2000);
            //IWebElement btn_portfolio = driver.FindElement(By.XPath("/html/body/app-root/et-layout-main/div/div[2]/div[1]/et-layout-sidenav/aside/div[2]/nav/ul/li[3]/a"));
            //Thread.Sleep(2000);
            //btn_portfolio.Click();
            IWebElement position = driver.FindElement(By.XPath("/html/body/app-root/et-layout-main/div/div[2]/div[2]/div[3]/div/ui-layout/ng-view/et-portfolio-overview/div/et-portfolio-list/et-portfolio-group-list/section/et-table/div[2]/div[2]/div/div[1]/div"));
            Thread.Sleep(2000);
            position.Click();
            IWebElement close = driver.FindElement(By.XPath("/html/body/app-root/et-layout-main/div/div[2]/div[2]/div[3]/div/ui-layout/ng-view/et-portfolio-breakdown/div/div/div/div/div/et-portfolio-position-list/section/et-table/div[2]/div[1]/div/div[3]/div/button"));
            close.Click();
            Thread.Sleep(2000);
            IWebElement close_trade = driver.FindElement(By.CssSelector("#uidialog1 > div.uidialog-content > div > div.w-sm-footer.ng-scope > button"));
            Thread.Sleep(2000);
            close_trade.Click();
            //Console.WriteLine("Succesfful");


            // Perform actions to repeatedly open and close positions
            for (int i = 0; i < 1; i++)
            {
                // Perform actions to open a position
                //IWebElement button_trade = driver.FindElement(By.XPath("//div[@class='head-instrument-action']/et-market-page-trade-button"));
                //button_trade.Click();

                // Perform actions to close the position
                //IWebElement btn_portfolio = driver.FindElement(By.XPath("/html/body/app-root/et-layout-main/div/div[2]/div[1]/et-layout-sidenav/aside/div[2]/nav/ul/li[3]/a"));
                //Thread.Sleep(2000);
                //btn_portfolio.Click();
                //IWebElement position =driver.FindElement(By.XPath("//a[@automation-id='portfolio-overview-table-body-cell-market-name'"));
                //Thread.Sleep(2000);
                //position.Click();
            }

            // Close the browser
            driver.Quit();
        }
    }
}