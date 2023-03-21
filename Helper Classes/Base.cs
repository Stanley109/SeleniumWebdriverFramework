
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace SeleniumWebdriver
{	
	class Base
  	{
		public static string BasePath = Directory.GetCurrentDirectory().Substring(0,Directory.GetCurrentDirectory().Length-new string("\\bin\\Debug\\net7.0\\").Length+1);
		public static IWebDriver WebDriver=null!;

		public static void InitializeBrowser()
		{
		    new DriverManager(Base.BasePath).SetUpDriver(new ChromeConfig(),VersionResolveStrategy.MatchingBrowser);          
            WebDriver = new ChromeDriver();
		}

		public static void GoToURL(string url)
		{
			WebDriver.Url = url;
		}
		public static string GetCurrentURL()
		{
			return WebDriver.Url;
		}
	}
	
}