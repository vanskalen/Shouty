﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Shouty.Spec
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Hear Shout")]
    public partial class HearShoutFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "HearShout.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Hear Shout", "  Shouts have a range of approximately 1000m", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 5
#line 6
    testRunner.Given("Lucy is at 0, 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Multiple shouts from one person")]
        public virtual void MultipleShoutsFromOnePerson()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Multiple shouts from one person", null, ((string[])(null)));
#line 8
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line 10
    testRunner.Given("Sean is at 0, 500", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 11
    testRunner.When("Sean shouts", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
    testRunner.And("Sean shouts", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
    testRunner.Then("Lucy should hear 2 shouts from Sean", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Shouter should not hear their own shouts")]
        public virtual void ShouterShouldNotHearTheirOwnShouts()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Shouter should not hear their own shouts", null, ((string[])(null)));
#line 15
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line 16
    testRunner.When("Lucy shouts", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 17
    testRunner.Then("Lucy should not hear Lucy", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Multiple Shouters One Heard")]
        public virtual void MultipleShoutersOneHeard()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Multiple Shouters One Heard", null, ((string[])(null)));
#line 19
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "x",
                        "y"});
            table1.AddRow(new string[] {
                        "Lucy",
                        "0",
                        "0"});
            table1.AddRow(new string[] {
                        "Sean",
                        "0",
                        "500"});
            table1.AddRow(new string[] {
                        "Oscar",
                        "1100",
                        "0"});
#line 20
    testRunner.Given("people are located at", ((string)(null)), table1, "Given ");
#line 25
    testRunner.When("Sean shouts", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
    testRunner.And("Oscar shouts", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
    testRunner.Then("Lucy should not hear Oscar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 28
    testRunner.But("Lucy should hear Sean", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "But ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Multiple Shouters All Heard")]
        public virtual void MultipleShoutersAllHeard()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Multiple Shouters All Heard", null, ((string[])(null)));
#line 30
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line 32
    testRunner.Given("Sean is at 0, 500", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 33
    testRunner.And("Oscar is at 300, 400", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
    testRunner.When("Sean shouts", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 35
    testRunner.And("Oscar shouts", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
    testRunner.Then("Lucy should hear Oscar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 37
    testRunner.But("Lucy should hear Sean", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "But ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("only hear in-range shouts")]
        [NUnit.Framework.TestCaseAttribute("01", "0, 900", "Sean", null)]
        [NUnit.Framework.TestCaseAttribute("02", "800, 800", "nothing", null)]
        [NUnit.Framework.TestCaseAttribute("03", "900, 900", "nothing", null)]
        [NUnit.Framework.TestCaseAttribute("04", "800, 800", "nothing", null)]
        public virtual void OnlyHearIn_RangeShouts(string id, string seans_Location, string what_Lucy_Hears, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("only hear in-range shouts", null, exampleTags);
#line 39
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line 41
    testRunner.Given(string.Format("Sean is at {0}", seans_Location), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 42
    testRunner.When("Sean shouts", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 43
    testRunner.Then(string.Format("Lucy should hear {0}", what_Lucy_Hears), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
