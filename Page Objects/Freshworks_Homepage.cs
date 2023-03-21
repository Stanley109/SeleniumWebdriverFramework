using System;
using OpenQA.Selenium;

namespace SeleniumWebdriver
{
    public class Freshworks_Homepage
    {
        public const string FreshWorksURL = "https://www.freshworks.com/";
        IWebDriver WebDriver;
        public Freshworks_Homepage(IWebDriver WebDriver)
        {
            this.WebDriver = WebDriver;
        }

        //Webelements
        public IWebElement TopBanner_Resources => WebDriver.FindElement(By.XPath("//span[contains(text(),'Resources')]"));
        public IWebElement SubBanner_About => WebDriver.FindElement(By.XPath("(//span[contains(text(),'About')])[1]"));

    }
}