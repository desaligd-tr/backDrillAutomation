using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;


namespace backDrillAutomation
{

    class practice
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
            driver.Quit();
        }

        /*
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
            Assert.AreEqual(btn_logOut.Text, "Logout");
            IWebElement requestclose = driver.FindElement(By.Id("select-2413225501"));
            requestclose.Click();
            Thread.Sleep(3000);
            IWebElement option2 = driver.FindElement(By.CssSelector("#select-2413225501 > option:nth-child(2)"));
            option2.Click();
            IWebElement sumbit_btn = driver.FindElement(By.Id("summary-bar-submit-button"));
            Thread.Sleep(3000);
            sumbit_btn.Click();
            IWebElement confirm_btn = driver.FindElement(By.Id("prompt-modal-continue"));
            confirm_btn.Click();
            IWebElement close_request = driver.FindElement(By.XPath("//*[@id=row-2413225501-request]/span"));
            Assert.AreEqual(close_request.Text, "Close Requested");
        }*/

        [Test]
        public void openpostion_test()
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
            Thread.Sleep(2000);
            /* IWebElement search = driver.FindElement(By.Id("trading-autocomplete-input"));
             search.SendKeys("BTC");
             String searchText = search.Text;*/
            IWebElement btn_watchList = driver.FindElement(By.XPath("//a[@automation-id='sidenav-menu-watchlists']"));
            Thread.Sleep(2000);
            btn_watchList.Click();
            Thread.Sleep(3000);
            IWebElement btc = driver.FindElement(By.XPath("(//div[@class='symbol'])[1]"));
            Thread.Sleep(2000);
            btc.Click();
            //Console.WriteLine("Succesfful");
            //IWebElement click_btc = driver.FindElement(By.XPath("//*[@id=watchlist - instruments]/div[2]/div[1]/div/div[1]/div/et-card-avatar/a/div[2]/div[2]"));
            //click_btc.Click();
           // Console.WriteLine("Succesfful");
            Thread.Sleep(2000);
            IWebElement button_trade = driver.FindElement(By.XPath("//div[@class='head-instrument-action']/et-market-page-trade-button"));
             button_trade.Click();
            // IWebElement cash_input = driver.FindElement(By.Id("input"));
            //cash_input.SendKeys("10");
           // Thread.Sleep(2000);
           // IWebElement input_tradeAmount = driver.FindElement(By.XPath("(//input[starts-with(@type,'text')])[2]"));
           // Thread.Sleep(1000);
          //  input_tradeAmount.Clear();
          //  Thread.Sleep(2000);
          //  input_tradeAmount.SendKeys("10");
          //  Thread.Sleep(2000);
            IWebElement btn_openTrade = driver.FindElement(By.XPath("//div[@class='execution-action-button']/button"));
            Thread.Sleep(2000);
            btn_openTrade.Click();
            //Console.WriteLine("Succesfful");
            
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
            Assert.AreEqual(btn_logOut.Text, "Logout");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IList<IWebElement> elements = driver.FindElements(By.XPath("//span[starts-with(@class,'first__item__subheading ng')]"));
            IWebElement element = elements[0];
            Console.WriteLine("Printed"+element.Text);
            //Console.WriteLine("Succesfful");
            IWebElement dropDown_request = driver.FindElement(By.XPath("(//select[starts-with(@id,'select-')])[1]"));
            dropDown_request.Click();
            Thread.Sleep(2000);
            IWebElement option_requestToClose = driver.FindElement(By.XPath("(//select[starts-with(@id,'select-')])[1]/option[2]"));
            option_requestToClose.Click();
            Console.WriteLine("Selected");
            Thread.Sleep(2000);
            IWebElement sumbit_btn = driver.FindElement(By.Id("summary-bar-submit-button"));
            Thread.Sleep(3000);
            sumbit_btn.Click();
            //IWebElement requestclose = driver.FindElement(By.Id("select-()"));
            //requestclose.Click();
            //  Thread.Sleep(3000);
            //IWebElement option2 = driver.FindElement(By.CssSelector("#select-() > option:nth-child(2)"));
            //option2.Click();
            //IWebElement sumbit_btn = driver.FindElement(By.Id("summary-bar-submit-button"));
            //Thread.Sleep(3000);
            //sumbit_btn.Click();
            //IWebElement confirm_btn = driver.FindElement(By.Id("prompt-modal-continue"));
            //confirm_btn.Click();
            //IWebElement close_request = driver.FindElement(By.XPath("//*[@id=row-2413225501-request]/span"));
            //Assert.AreEqual(close_request.Text, "Close Requested");
            //Console.WriteLine("Succesfful");
        }

    }

    class ReptileAutomationTest
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
            IWebElement position = driver.FindElement(By.XPath("/html/body/app-root/et-layout-main/div/div[2]/div[2]/div[3]/div/ui-layout/ng-view/et-portfolio-overview/div/et-portfolio-list/et-portfolio-group-list/section/et-table/div[2]/div[3]/div/div[1]/div"));
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
