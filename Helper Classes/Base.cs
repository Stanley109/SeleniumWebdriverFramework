
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace SeleniumWebdriver
{	
	class Base
  	{
		public static string basePath = Directory.GetCurrentDirectory().Substring(0,Directory.GetCurrentDirectory().Length-new string("\\bin\\Debug\\net7.0\\").Length+1);
		public static IWebDriver webDriver=null!;

		public static void InitializeBrowser()
		{
		    new DriverManager(Base.basePath).SetUpDriver(new ChromeConfig(),VersionResolveStrategy.MatchingBrowser);          
            webDriver = new ChromeDriver();
		}

		public static void GoToURL(string url)
		{
			webDriver.Url = url;
		}
	}
	
}