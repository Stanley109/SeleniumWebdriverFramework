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

        [BeforeFeature]
        public static void SetupBrowser(FeatureContext context)
        {
            Base.InitializeBrowser();
            Base.GoToURL(FreshWorksPageObjects.freshWorksURL);
            
            
            ExtentReportsHelper.CreateNewReport();
            ExtentReportsHelper.LogReport(context.FeatureInfo.Title);

        }

        [AfterFeature]
        public static void TeardownBrowser()
        {
            //add comment test only
            Base.webDriver.Quit();
            ExtentReportsHelper.EndReport();
        }
    }
}