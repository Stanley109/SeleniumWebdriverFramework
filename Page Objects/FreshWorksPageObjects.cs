using System;
using OpenQA.Selenium;

namespace SeleniumWebdriver
{
    public class FreshWorksPageObjects
    {
        public const string freshWorksURL = "https://www.freshworks.com";
        IWebDriver webDriver;
        public FreshWorksPageObjects(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        //Webelement
        public IWebElement firstElement => webDriver.FindElement(By.XPath("//*"));




    }
}