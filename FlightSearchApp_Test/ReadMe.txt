.FlightSearchApp_Test:

1. Install or make sure Chrome version 84 is installed on your system

2. Locate and open 'FlightSearchApp_Test.csproj' in Visual Studio.

3. Add references(if not automatically added) for below packages from Nuget Package Manager:
	a. Selenium.WebDriver
	b. Selenium.Support
	c. Selenium.WebDriver.ChromeDriver
	d. DotNetSeleniumExtras.PageObjects
	e. DotNetSeleniumExtras.PageObjects.Core
	f.  NUnit
	g. NUnit3TestAdapter
	

4. For executing the tests, go to 'Test'--> 'Windows'-- > 'Test Explorer' and run the below tests:
	a. Verify_DropDownList
	b.  Verify_Email

Note: Make sure to have stable internet connection, so that web pages can load properly.
