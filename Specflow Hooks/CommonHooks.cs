using System;
using AventStack.ExtentReports.Reporter;
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

        public static string basePath = Directory.GetCurrentDirectory().Substring(0,Directory.GetCurrentDirectory().Length-new string("\\bin\\Debug\\net7.0\\").Length+1);

        [BeforeFeature]
        public static void SetupBrowser(FeatureContext context)
        {
             
             new DriverManager(basePath).SetUpDriver(new ChromeConfig(),VersionResolveStrategy.MatchingBrowser);
            
            Base.driver = new ChromeDriver();
            Base.driver.Url = "Https://wikipedia.org";
            
            ExtentReportsHelper.createNewReport();
            ExtentReportsHelper.logReport(context.FeatureInfo.Title);

        }

        [AfterFeature]
        public static void TeardownBrowser()
        {
            //add comment test only
            Base.driver.Quit();
        }
    }
}