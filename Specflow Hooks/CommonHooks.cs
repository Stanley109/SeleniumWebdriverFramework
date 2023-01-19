using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace SeleniumWebdriver
{
    [Binding]
    public class CommonHooks
    {


        [BeforeFeature]
        public static void SetupBrowser()
        {
             string chromeDriverPath = Directory.GetCurrentDirectory().Substring(0,Directory.GetCurrentDirectory().Length-new string("\\bin\\Debug\\net7.0\\").Length+1);
             new DriverManager(chromeDriverPath).SetUpDriver(new ChromeConfig(),VersionResolveStrategy.MatchingBrowser);
            
            Base.driver = new ChromeDriver();
            Base.driver.Url = "Https://wikipedia.org";
           
        }

        [AfterFeature]
        public static void TeardownBrowser()
        {
            Base.driver.Quit();
        }
    }
}