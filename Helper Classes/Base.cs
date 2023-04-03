
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace SeleniumWebdriver
{	
	class Base
  	{
		public static string BasePath = Directory.GetCurrentDirectory().Substring(0,Directory.GetCurrentDirectory().Length-new string("\\bin\\Debug\\net7.0\\").Length+1);
		public static IWebDriver WebDriver=null!;

		public static void SetupBrowser()
		{
		    new DriverManager(Base.BasePath).SetUpDriver(new ChromeConfig(),VersionResolveStrategy.MatchingBrowser);
			var options = new ChromeOptions();
			options.AddArgument("--start-maximized");
       		options.AddArgument("--disable-notifications");
            WebDriver = new ChromeDriver(options);
			WebDriver.Manage().Timeouts().ImplicitWait= TimeSpan.FromSeconds(5);
		}

		public static void ImplicitlyWait(int sec)
		{
			WebDriver.Manage().Timeouts().ImplicitWait= TimeSpan.FromSeconds(sec);
		}

		public static void GoToURL(string url)
		{
			WebDriver.Url = url;
		}
		public static string GetCurrentURL()
		{
			return WebDriver.Url;
		}
		public static void HoverToElement(IWebElement element)
		{
			Actions action = new Actions(WebDriver);
			action.MoveToElement(element);
			action.Perform();
		}
		public static void ClickElement(IWebElement element)
		{
			element.Click();
		}
		public static string GetText(IWebElement element)
		{
			return element.GetAttribute("value");
		}
	}
	
}