# How to add the selenium webdriver in the solution (Nuget package)
	Tools--> NuGet Package Manager-->Manage NuGet Package for solution-->Brower tab---> Type Selenium

# From Selenium 4.29 We don't need to install Chrome driver or anydriver.
	Just write IWebDriver driver = new ChromeDriver(), EdgeDriver and FireFox Respectively.

# How to run all test from command line CMD.
	dotnet test

# How to run test from command line CMD with Catagory marked.
	dotnet test - -filter "Category=Smoke"
	dotnet test - -filter "Priority=1"


# CodeLens settings:( [Pass or Fail]XUnit method class to show references in Visual Studio)
	Go to Tools > Options > Text Editor > All Languages > CodeLens > "Enable CodeLens"

# xUnit Attributes Docs
	https://xunit.net/docs/comparisons