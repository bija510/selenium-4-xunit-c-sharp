using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace selenium_4_xunit_c_sharp
{
    public class Test_001_LunchBrowsers
    {
        private IWebDriver driver;
        [Fact]
        public void test_lunch_chrome()
        {    
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.facebook.com");
            Thread.Sleep(4000);
            driver.Quit();
        }
        [Fact]
        public void test_lunch_edge()
        {
            driver = new EdgeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.amazon.com");
            Thread.Sleep(4000);
            driver.Quit();
           

        }
        [Fact]
        public void test_lunch_firefox()
        {
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.walmart.com");
            Thread.Sleep(4000);
            driver.Quit();

        }
    }
}
