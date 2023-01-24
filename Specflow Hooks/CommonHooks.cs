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

        static string basePath = Directory.GetCurrentDirectory().Substring(0,Directory.GetCurrentDirectory().Length-new string("\\bin\\Debug\\net7.0\\").Length+1);

        [BeforeFeature]
        public static void SetupBrowser(FeatureContext context)
        {
             
             new DriverManager(basePath).SetUpDriver(new ChromeConfig(),VersionResolveStrategy.MatchingBrowser);
            
            Base.driver = new ChromeDriver();
            Base.driver.Url = "Https://wikipedia.org";

            

            ExtentHtmlReporter htmlreport =  new ExtentHtmlReporter(basePath+"\\TestReports\\");
            var extent = new AventStack.ExtentReports.ExtentReports();
            extent.AttachReporter(htmlreport);
            var feature = extent.CreateTest(context.FeatureInfo.Title);
            extent.Flush();
        }

        [AfterFeature]
        public static void TeardownBrowser()
        {
            Base.driver.Quit();
        }
    }
}