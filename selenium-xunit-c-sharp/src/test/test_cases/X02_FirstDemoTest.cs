using OpenQA.Selenium;
using System;
using Xunit;



[assembly: CollectionBehavior(MaxParallelThreads = 4)]
//[assembly: CollectionBehavior(CollectionBehavior.CollectionPerAssembly)]

namespace selenium_xunit_c_sharp.Test_Cases
{
    public class X02_FirstDemoTest
    {
            String test_url = "https://lambdatest.github.io/sample-todo-app/";
            String itemName = "Yey, Let's add it to list";

            [Theory]
            [InlineData(BrowserType.Chrome)]
            [InlineData(BrowserType.Firefox)]

            public void NavigateToDoApp(BrowserType browserType)
            {
                using (var driver = WebDriverFactory.Create_Browser(browserType))
                {
                    driver.Navigate().GoToUrl(test_url);

                    driver.Manage().Window.Maximize();

                    Assert.Equal("Sample page - lambdatest.com", driver.Title);
                    // Click on First Check box
                    IWebElement firstCheckBox = driver.FindElement(By.Name("li1"));
                    firstCheckBox.Click();

                    // Click on Second Check box
                    IWebElement secondCheckBox = driver.FindElement(By.Name("li2"));
                    secondCheckBox.Click();

                    // Enter Item name
                    IWebElement textfield = driver.FindElement(By.Id("sampletodotext"));
                    textfield.SendKeys(itemName);

                    // Click on Add button
                    IWebElement addButton = driver.FindElement(By.Id("addbutton"));
                    addButton.Click();

                    // Verified Added Item name
                    IWebElement itemtext = driver.FindElement(By.XPath("/html/body/div/div/div/ul/li[6]/span"));
                    String getText = itemtext.Text;
                    Assert.True(itemName.Contains(getText));

                    /* Perform wait to check the output */
                    //System.Threading.Thread.Sleep(4000);

                    Console.WriteLine("LT_ToDo_Test Passed");

                    driver.Quit();
                }
            }
        }

    public class UnitTest2
    {
        String test_url = "https://lambdatest.github.io/sample-todo-app/";
        String itemName = "Yey, Let's add it to list";

        [Theory]
        [InlineData(BrowserType.Chrome)]
        public void NavigateToDoApp(BrowserType browserType)
        {
            using (var driver = WebDriverFactory.Create_Browser(browserType))
            {
                driver.Navigate().GoToUrl(test_url);

                driver.Manage().Window.Maximize();

                Assert.Equal("Sample page - lambdatest.com", driver.Title);
                // Click on First Check box
                IWebElement firstCheckBox = driver.FindElement(By.Name("li1"));
                firstCheckBox.Click();

                // Click on Second Check box
                IWebElement secondCheckBox = driver.FindElement(By.Name("li2"));
                secondCheckBox.Click();

                // Enter Item name
                IWebElement textfield = driver.FindElement(By.Id("sampletodotext"));
                textfield.SendKeys(itemName);

                // Click on Add button
                IWebElement addButton = driver.FindElement(By.Id("addbutton"));
                addButton.Click();

                // Verified Added Item name
                IWebElement itemtext = driver.FindElement(By.XPath("/html/body/div/div/div/ul/li[6]/span"));
                String getText = itemtext.Text;
                Assert.True(itemName.Contains(getText));

                /* Perform wait to check the output */
                //System.Threading.Thread.Sleep(4000);

                Console.WriteLine("LT_ToDo_Test Passed");

                driver.Quit();
            }
        }
    }
}
    
    