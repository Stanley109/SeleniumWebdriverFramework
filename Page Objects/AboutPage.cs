using System;
using OpenQA.Selenium;

namespace SeleniumWebdriver
{
    public class AboutPage
    {
        public const string AboutPageURL = "https://www.freshworks.com/company/about/";
        IWebDriver WebDriver;
        public AboutPage(IWebDriver WebDriver)
        {
            this.WebDriver = WebDriver;
        }

        //Webelements
        public IWebElement BannerHeader_AboutUs => WebDriver.FindElement(By.XPath("//h1[text()='About us']"));
        public IWebElement BannerParagraph1_AboutUs => WebDriver.FindElement(By.XPath("//h1[text()='About us']//following::p[1]"));
        public IWebElement BannerParagraph2_AboutUs => WebDriver.FindElement(By.XPath("//h1[text()='About us']//following::p[2]"));

    }
}