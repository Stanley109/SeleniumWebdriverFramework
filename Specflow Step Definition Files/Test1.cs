using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SeleniumWebdriver
{
    [Binding]
    class Test1
    {
        private int num1 {get;set;}
        private int num2 {get;set;}
        private int sum {get;set;}

        [Given ("I have (.*) and (.*)")]
        public void GivenIhave1and2(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        [When("i add both of them")]
        public void Wheniaddbothofthem()
        {
            sum=num1+num2;
            Console.WriteLine(sum);
        }

        [Then("the result should be (.*)")]
        public void Thentheresultshouldbe3(int sum)
        {
            Assert.AreEqual(sum,this.sum);
        }
    }
}
