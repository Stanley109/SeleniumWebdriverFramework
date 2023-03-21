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
            Base.GoToURL(Freshworks_Homepage.FreshWorksURL);
            ExtentReportsHelper.CreateNewReport();
            ExtentReportsHelper.CreateFeatureReport(context);
        }

        [AfterFeature]
        public static void TeardownBrowser()
        {
            Base.WebDriver.Quit();
            ExtentReportsHelper.EndReport();
        }

        [BeforeScenario]
        public static void BeforeScenario(ScenarioContext context)
        {
            ExtentReportsHelper.CreateScenarioReport(context);
        }

        [AfterStep]
        public static void AfterStep(ScenarioContext context)
        {
            ExtentReportsHelper.CreateStepReport(context);
        }
    }
}