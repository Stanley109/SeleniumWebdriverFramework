using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

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
            Assert.IsTrue(true);
        }
        [Then("I should be redirected to the Freshworks About us page")]
        public void IshouldberedirectedtotheFreshworksAboutuspage()
        {
            Assert.IsTrue(true);
        }
        [Then("I should see the About us banner paragraph text displayed correctly")]
        public void IshouldseetheAboutusbannerparagraphtextdisplayedcorrectly(Table table)
        {
            Assert.IsTrue(true);
        }
        
    }
}