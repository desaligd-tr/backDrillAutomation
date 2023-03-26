using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backDrillAutomation
{

    class practice
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void test01_loginVPN()
        {
            driver.Url = "https://offlinemode.etoro.com";
            driver.Manage().Window.Maximize();
            IWebElement userName = driver.FindElement(By.Id("username"));
            IWebElement password = driver.FindElement(By.Id("password"));
            userName.SendKeys("BetaTester30");
            password.SendKeys("Aa123456");
            IWebElement btn_login = driver.FindElement(By.Id("submit-button"));
            btn_login.Click();
            Thread.Sleep(3000);
            IWebElement btn_popUp = driver.FindElement(By.Id("warning-modal-continue"));
            btn_popUp.Click();
            Thread.Sleep(3000);
            IWebElement btn_logOut = driver.FindElement(By.XPath("//div[starts-with(@class,'header__logout')]"));
            Assert.AreEqual(btn_logOut.Text,"Logout");

        }

        [Test]
        public void test02_addToWatchList()
        {
            driver.Url = "https://www.etoro.com/login";
            driver.Manage().Window.Maximize();
            IWebElement userName = driver.FindElement(By.Id("username"));
            IWebElement password = driver.FindElement(By.Id("password"));
            userName.SendKeys("BetaTester30");
            password.SendKeys("Aa123456");
            String userNameText = userName.Text;
            IWebElement btn_login = driver.FindElement(By.XPath("//button[@class='button-default blue-btn']"));
            btn_login.Click();
            Thread.Sleep(3000);
            IWebElement nameProfile = driver.FindElement(By.XPath("//div[@automation-id='sidenav-user-box']"));
            Assert.True(nameProfile.Displayed);
            Thread.Sleep(1000);
            IWebElement btn_watchList = driver.FindElement(By.XPath("//a[@automation-id='sidenav-menu-watchlists']"));
            btn_watchList.Click();
            Thread.Sleep(3000);
            IWebElement btn_addToWatchList = driver.FindElement(By.XPath("//button[@automation-id='watchlist-watchlist-btn-add-markets']"));
            btn_addToWatchList.Click();
            IWebElement btn_searchFromWatchList = driver.FindElement(By.XPath("//input[@automation-id='add-markets-search-bar']"));
            btn_searchFromWatchList.SendKeys("doge");
            Thread.Sleep(3000);
            IWebElement btn_addToWatchL = driver.FindElement(By.XPath("//ets-checkbox[@automation-id='add-markets-browser-btn-add-item']"));
            btn_addToWatchL.Click();
            IWebElement btn_done = driver.FindElement(By.XPath("//button[@automation-id='add-markets-close-dialog-btn']"));
            btn_done.Click();
            Thread.Sleep(3000);
            IWebElement list_symbol = driver.FindElement(By.XPath("(//div[@class='symbol'])[1]"));
            Assert.AreEqual("DOGE", list_symbol.Text);
            btn_addToWatchList.Click();
            Thread.Sleep(3000);
            IWebElement btn_searchFromWatchListR = driver.FindElement(By.XPath("//input[@automation-id='add-markets-search-bar']"));
            btn_searchFromWatchListR.SendKeys("doge");
            Thread.Sleep(2000);
            IWebElement btn_removeFromWatchL = driver.FindElement(By.XPath("//ets-checkbox[@automation-id='add-markets-browser-btn-add-item']"));
            btn_removeFromWatchL.Click();
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
