using OpenQA.Selenium;
using System;
using Xunit;

namespace selenium_xunit_c_sharp.src.test.test_cases
{

    public class X03_2ndDemoTest
    {
        
        //Auto driver.Quit()

        [Theory]
        [InlineData(BrowserType.Chrome)]
        public void Test_demo1(BrowserType browserType)
        {
            using (var driver = WebDriverFactory.Create_Browser(browserType))
            {
                driver.Url = "http://demo.automationtesting.in/Register.html";

            }
        }

        [Fact]     
        public void Test_demo2()
        {
            using (var driver = WebDriverFactory.Create_Browser(BrowserType.Firefox))
            {
                driver.Url = "https://opensource-demo.orangehrmlive.com/";
                Environment.Exit(0); // System.exit(0)

            }
        }
    }
}