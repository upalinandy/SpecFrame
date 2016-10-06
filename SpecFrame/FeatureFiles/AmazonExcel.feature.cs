﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecFrame.FeatureFiles
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Test Amazon using Specflow Excel", Description="\t   Go to Amazon Url\r\n\t   Login to website\r\n\t   Search an item and\r\n\t   Add to ca" +
        "rt", SourceFile="FeatureFiles\\AmazonExcel.feature", SourceLine=0)]
    public partial class TestAmazonUsingSpecflowExcelFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "AmazonExcel.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Test Amazon using Specflow Excel", "\t   Go to Amazon Url\r\n\t   Login to website\r\n\t   Search an item and\r\n\t   Add to ca" +
                    "rt", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
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
        
        public virtual void FeatureBackground()
        {
#line 7
#line 8
    testRunner.Given("User is at Amazon homepage with url \"https://www.amazon.in/\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
    testRunner.And("Signin link should be visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        public virtual void AddItemIntoCartUsingExcel(string username, string password, string searchitem, string selectitem, string displaypage, string exactitem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "excelsheet"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add item into cart using Excel", @__tags);
#line 12
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 13
  testRunner.When("User clicks on \"<Signin>\" link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
  testRunner.Then("User should be at Login Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 15
  testRunner.When(string.Format("User provides \"{0}\",\"{1}\" and click on login button", username, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
  testRunner.Then("User should be able to login successfully.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 17
  testRunner.When(string.Format("User provides \"{0}\",\"{1}\" in search tab", searchitem, selectitem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
  testRunner.Then(string.Format("User should be taken to \"{0}\" Display page.", displaypage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 19
  testRunner.When(string.Format("User selects \"{0}\" and adds to cart", exactitem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
  testRunner.Then("the specific item is added to cart", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 21
  testRunner.When("User clicks on \"<Cart>\" link after adding to cart", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
  testRunner.Then("user is taken to cartpage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 23
  testRunner.When(string.Format("\"{0}\" is present in cart", exactitem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
  testRunner.Then(string.Format("write to file \"{0}\"", exactitem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 25
  testRunner.When(string.Format("User clicks to delete item \"{0}\" from cart", exactitem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
  testRunner.Then("item is deleted from cart", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Add item into cart using Excel, Variant 0", new string[] {
                "excelsheet",
                "source:specflowdata.xlsx"}, SourceLine=0)]
        public virtual void AddItemIntoCartUsingExcel_Variant0()
        {
            this.AddItemIntoCartUsingExcel("nandyupali@gmail.com ", "ganesha123", "iphone ", "iphone 6s", "Amazon.in: iphone 6s - Smartphones / Smartphones & Basic Mobiles: Electronics", "Apple iPhone 6s (Rose Gold, 16GB)", new string[] {
                        "source:specflowdata.xlsx"});
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Add item into cart using Excel, Variant 1", new string[] {
                "excelsheet",
                "source:specflowdata.xlsx"}, SourceLine=0)]
        public virtual void AddItemIntoCartUsingExcel_Variant1()
        {
            this.AddItemIntoCartUsingExcel("nandyupali@gmail.com ", "ganesha123", "moto g", "moto g4 plus", "Amazon.in: moto g4 plus - Smartphones / Smartphones & Basic Mobiles: Electronics", "Moto G Plus, 4th Gen (Black, 32 GB)", new string[] {
                        "source:specflowdata.xlsx"});
#line hidden
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
