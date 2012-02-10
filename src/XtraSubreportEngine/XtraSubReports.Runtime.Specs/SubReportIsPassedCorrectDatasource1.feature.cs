﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.239
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace XtraSubReports.Runtime.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Subreport is passed correct datasource")]
    public partial class SubreportIsPassedCorrectDatasourceFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SubReportIsPassedCorrectDatasource.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Subreport is passed correct datasource", "In order to easily build reports without writing any code\r\nAs a report designer\r\n" +
                    "I want my sub reports to share datasources automatically", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
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
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Subreport inside of a header band")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void SubreportInsideOfAHeaderBand()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Subreport inside of a header band", new string[] {
                        "mytag"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("A parent report exists");
#line 9
 testRunner.And("the parent report has a datasource of three items");
#line 10
 testRunner.And("a subreport exists as a file");
#line 11
 testRunner.And("a XRSubreport container exists in the parent report\'s header band");
#line 12
 testRunner.And("the XRSubreport container references the subreport\'s filename");
#line 13
 testRunner.And("the xtrasubreport engine is initialized");
#line 14
 testRunner.When("the report engine runs");
#line 15
 testRunner.Then("the subreport\'s datasource should be the same as the parent report\'s datasource");
#line 16
 testRunner.And("the subreport\'s datasource should not be null");
#line 17
 testRunner.And("the subreport action should have been fired 1 time(s)");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Subreport inside of a footer band")]
        public virtual void SubreportInsideOfAFooterBand()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Subreport inside of a footer band", ((string[])(null)));
#line 20
this.ScenarioSetup(scenarioInfo);
#line 21
 testRunner.Given("A parent report exists");
#line 22
 testRunner.And("the parent report has a datasource of three items");
#line 23
 testRunner.And("a subreport exists as a file");
#line 24
 testRunner.And("a XRSubreport container exists in the parent report\'s footer band");
#line 25
 testRunner.And("the XRSubreport container references the subreport\'s filename");
#line 26
 testRunner.And("the xtrasubreport engine is initialized");
#line 27
 testRunner.When("the report engine runs");
#line 28
 testRunner.Then("the subreport\'s datasource should be the same as the parent report\'s datasource");
#line 29
 testRunner.And("the subreport\'s datasource should not be null");
#line 30
 testRunner.And("the subreport action should have been fired 1 time(s)");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Subreport inside of a detail band")]
        public virtual void SubreportInsideOfADetailBand()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Subreport inside of a detail band", ((string[])(null)));
#line 32
this.ScenarioSetup(scenarioInfo);
#line 33
 testRunner.Given("A parent report exists");
#line 34
 testRunner.And("the parent report has a datasource of three items");
#line 35
 testRunner.And("a subreport exists as a file");
#line 36
 testRunner.And("a XRSubreport container exists in the parent report\'s detail band");
#line 37
 testRunner.And("the XRSubreport container references the subreport\'s filename");
#line 38
 testRunner.And("the xtrasubreport engine is initialized with datasource tracking");
#line 39
 testRunner.When("the report engine runs");
#line 40
 testRunner.Then("each item in the parent\'s datasource should have been set once");
#line 41
 testRunner.And("the subreport action should have been fired 3 time(s)");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
