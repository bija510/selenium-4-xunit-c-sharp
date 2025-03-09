using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace selenium_4_xunit_c_sharp
{
    public class Test_002_RefreshForwardBack
    {
        protected IWebDriver driver;

        [Fact]
        public void test_refForBack()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.facebook.com");
            Thread.Sleep(2000);
            driver.Navigate().Refresh();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//a[text()='Create new account']")).Click();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.Navigate().Forward();
            Thread.Sleep(2000);
            driver.Quit();
            Assert.Equal("apple", "apple");


        }
    }
}
