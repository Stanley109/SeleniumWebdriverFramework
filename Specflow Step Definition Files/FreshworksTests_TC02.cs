using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SeleniumWebdriver
{
    [Binding]
    class FreshworksTests_TC02
    {
        [Given("I am in the Freshworks homepage")]
        public void GivenIamintheFreshworkshomepage()
        {
            Assert.AreEqual(Freshworks_Homepage.FreshWorksURL,Base.GetCurrentURL());
        }

        [When("I click the about button under the Resources banner")]
        public void IclicktheaboutbuttonundertheResourcesbanner()
        {
            var freshworks_Homepage = new Freshworks_Homepage(Base.WebDriver);

            Base.HoverToElement(freshworks_Homepage.TopBanner_Resources);
            Base.ClickElement(freshworks_Homepage.SubBanner_About);
        }

        [Then("I should be redirected to the Freshworks About us page")]
        public void IshouldberedirectedtotheFreshworksAboutuspage()
        {
            var aboutpage = new AboutPage(Base.WebDriver);

            Assert.AreEqual(AboutPage.AboutPageURL,Base.GetCurrentURL());
        }
        
        [Then("I should see the About us banner paragraph text displayed correctly")]
        public void IshouldseetheAboutusbannerparagraphtextdisplayedcorrectly(Table table)
        {
            var banner = table.CreateInstance<Banner>();
            var aboutpage = new AboutPage(Base.WebDriver);

            Assert.AreEqual(banner.paragraph,Base.GetText(aboutpage.BannerParagraph1_AboutUs));
        }
    }

    class Banner
    {
        public string? paragraph {get;set;}
    }
}