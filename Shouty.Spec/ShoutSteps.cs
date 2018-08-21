using System;
using TechTalk.SpecFlow;
using Shouty;
using NUnit.Framework;
using TechTalk.SpecFlow.Assist;

namespace Shouty.Specs
{
    [Binding]
    public class ShoutSteps
    {
        public ShoutSteps(ShoutyNetwork sh)
        {
            shouty = sh;
        }

        private const string ARBITRARY_MESSAGE = "Hello, world";
        private readonly ShoutyNetwork shouty;

        [When(@"(.*) shouts")]
        public void WhenShouterShouts(string shouter)
        {
            shouty.Shout(shouter, ARBITRARY_MESSAGE);
        }

        [Then(@"(.*) should hear ([a-zA-Z]*)")]
        public void ThenListenerShouldHearShouter(string listener, string shouter)
        {
            if (shouter == "nothing")
                Assert.IsTrue(shouty.GetShoutsHeardBy(listener).Count == 0);
            else
                Assert.IsTrue(shouty.GetShoutsHeardBy(listener).ContainsKey(shouter));
        }

         [Then(@"(.*) should hear (\d*) shouts from ([a-zA-Z]*)")]
        public void ThenLucyShouldHearShoutsFromSean(string listener, int numOfShouts, string shouter)
        {
                Assert.IsTrue(shouty.GetShoutsHeardBy(listener)[shouter].Count == numOfShouts);
        }

        [Then(@"(.*) should not hear (.*)")]
        public void ThenListenerShouldNotHearShouter(string listener, string shouter)
        {
             Assert.IsFalse(shouty.GetShoutsHeardBy(listener).ContainsKey(shouter));
        }
       
    }
}
