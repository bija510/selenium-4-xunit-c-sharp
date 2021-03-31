using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.IO;
using System.Reflection;
using Xunit;

namespace selenium_xunit_c_sharp
{
    public class X01_MajorBrowserTest
    {
        // ======For=========https://xunit.net/ ========DOCS===========
        IWebDriver driver;
        string browserName = "FIREFOX";

        [Fact]
        public void Test1()
        {
           
            if (browserName.Equals("CHROME"))
            {
                driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                driver.Manage().Window.Maximize();
            }
            else if (browserName.Equals("FIREFOX"))
            {
                driver = new FirefoxDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                driver.Manage().Window.Maximize();
            }
            else if (browserName.Equals("MSEDGE"))
            {
                driver = new EdgeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                driver.Manage().Window.Maximize();
            }
         
            driver.Url = "https://www.facebook.com";
        }
        
    }
}
