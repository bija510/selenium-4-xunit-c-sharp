using System;
using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

    namespace OpenQA.Selenium
    {
        internal static class WebDriverFactory
        {
            public static IWebDriver Create_Browser(BrowserType browserType)
            {
                switch (browserType)
                {
                    case BrowserType.Chrome:
                        return new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                    case BrowserType.Firefox:
                        return new FirefoxDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                    case BrowserType.Edge:
                        return new EdgeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                    default:
                        throw new ArgumentOutOfRangeException(nameof(browserType), browserType, null);
                }
            }
        }
    }