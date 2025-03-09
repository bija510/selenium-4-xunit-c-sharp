using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace selenium_4_xunit_c_sharp.Test_Cases
{
    public class Test_003_Skip_Method
    {
        private IWebDriver driver;

        [Fact(Skip = "Azure Bug num:- 1158")]
        //[Fact]
        public void Test_skip_for_existing_bug()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.amazon.com");
            Thread.Sleep(4000);
            driver.Quit();


        }
        [Fact]
        [Trait("Category", "Smoke")]
        [Trait("Priority", "1")]
        public void Test_run_with_Category()
        {
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.walmart.com");
            Thread.Sleep(4000);
            driver.Quit();

        }
    }
}
