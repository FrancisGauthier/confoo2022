// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Confoo2022.SpecFlow.FizzBuzz.Specs.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class FizzBuzzFeature : object, Xunit.IClassFixture<FizzBuzzFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "FizzBuzz.feature"
#line hidden
        
        public FizzBuzzFeature(FizzBuzzFeature.FixtureData fixtureData, Confoo2022_SpecFlow_FizzBuzz_Specs_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "FizzBuzz", "\tWrite a program that prints the numbers from 1 to 100. \r\n\tBut for multiples of t" +
                    "hree print “Fizz” instead of the number and for the multiples of five print “Buz" +
                    "z”. \r\n\tFor numbers which are multiples of both three and five print “FizzBuzz”.", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableTheoryAttribute(DisplayName="Print FizzBuzz")]
        [Xunit.TraitAttribute("FeatureTitle", "FizzBuzz")]
        [Xunit.TraitAttribute("Description", "Print FizzBuzz")]
        [Xunit.TraitAttribute("Category", "tag1")]
        [Xunit.InlineDataAttribute("1", "1", new string[0])]
        [Xunit.InlineDataAttribute("2", "2", new string[0])]
        [Xunit.InlineDataAttribute("3", "Fizz", new string[0])]
        [Xunit.InlineDataAttribute("4", "4", new string[0])]
        [Xunit.InlineDataAttribute("5", "Buzz", new string[0])]
        [Xunit.InlineDataAttribute("6", "Fizz", new string[0])]
        [Xunit.InlineDataAttribute("7", "7", new string[0])]
        [Xunit.InlineDataAttribute("8", "8", new string[0])]
        [Xunit.InlineDataAttribute("9", "Fizz", new string[0])]
        [Xunit.InlineDataAttribute("10", "Buzz", new string[0])]
        [Xunit.InlineDataAttribute("11", "11", new string[0])]
        [Xunit.InlineDataAttribute("12", "Fizz", new string[0])]
        [Xunit.InlineDataAttribute("13", "13", new string[0])]
        [Xunit.InlineDataAttribute("14", "14", new string[0])]
        [Xunit.InlineDataAttribute("15", "FizzBuzz", new string[0])]
        [Xunit.InlineDataAttribute("16", "16", new string[0])]
        [Xunit.InlineDataAttribute("17", "17", new string[0])]
        [Xunit.InlineDataAttribute("18", "Fizz", new string[0])]
        [Xunit.InlineDataAttribute("19", "19", new string[0])]
        [Xunit.InlineDataAttribute("20", "Buzz", new string[0])]
        [Xunit.InlineDataAttribute("21", "Fizz", new string[0])]
        [Xunit.InlineDataAttribute("22", "22", new string[0])]
        [Xunit.InlineDataAttribute("23", "23", new string[0])]
        [Xunit.InlineDataAttribute("24", "Fizz", new string[0])]
        [Xunit.InlineDataAttribute("25", "Buzz", new string[0])]
        [Xunit.InlineDataAttribute("26", "26", new string[0])]
        [Xunit.InlineDataAttribute("27", "Fizz", new string[0])]
        [Xunit.InlineDataAttribute("28", "28", new string[0])]
        [Xunit.InlineDataAttribute("29", "29", new string[0])]
        [Xunit.InlineDataAttribute("30", "FizzBuzz", new string[0])]
        [Xunit.InlineDataAttribute("31", "31", new string[0])]
        [Xunit.InlineDataAttribute("32", "32", new string[0])]
        [Xunit.InlineDataAttribute("33", "Fizz", new string[0])]
        [Xunit.InlineDataAttribute("34", "34", new string[0])]
        [Xunit.InlineDataAttribute("35", "Buzz", new string[0])]
        [Xunit.InlineDataAttribute("36", "Fizz", new string[0])]
        [Xunit.InlineDataAttribute("37", "37", new string[0])]
        [Xunit.InlineDataAttribute("38", "38", new string[0])]
        [Xunit.InlineDataAttribute("39", "Fizz", new string[0])]
        [Xunit.InlineDataAttribute("40", "Buzz", new string[0])]
        [Xunit.InlineDataAttribute("41", "41", new string[0])]
        [Xunit.InlineDataAttribute("42", "Fizz", new string[0])]
        [Xunit.InlineDataAttribute("43", "43", new string[0])]
        [Xunit.InlineDataAttribute("44", "44", new string[0])]
        [Xunit.InlineDataAttribute("45", "FizzBuzz", new string[0])]
        [Xunit.InlineDataAttribute("46", "46", new string[0])]
        [Xunit.InlineDataAttribute("47", "47", new string[0])]
        [Xunit.InlineDataAttribute("48", "Fizz", new string[0])]
        [Xunit.InlineDataAttribute("49", "49", new string[0])]
        [Xunit.InlineDataAttribute("50", "Buzz", new string[0])]
        [Xunit.InlineDataAttribute("51", "Fizz", new string[0])]
        [Xunit.InlineDataAttribute("52", "52", new string[0])]
        [Xunit.InlineDataAttribute("53", "53", new string[0])]
        [Xunit.InlineDataAttribute("54", "Fizz", new string[0])]
        [Xunit.InlineDataAttribute("55", "Buzz", new string[0])]
        [Xunit.InlineDataAttribute("56", "56", new string[0])]
        [Xunit.InlineDataAttribute("57", "Fizz", new string[0])]
        [Xunit.InlineDataAttribute("58", "58", new string[0])]
        [Xunit.InlineDataAttribute("59", "59", new string[0])]
        [Xunit.InlineDataAttribute("60", "FizzBuzz", new string[0])]
        [Xunit.InlineDataAttribute("61", "61", new string[0])]
        [Xunit.InlineDataAttribute("62", "62", new string[0])]
        [Xunit.InlineDataAttribute("63", "Fizz", new string[0])]
        [Xunit.InlineDataAttribute("64", "64", new string[0])]
        [Xunit.InlineDataAttribute("65", "Buzz", new string[0])]
        [Xunit.InlineDataAttribute("66", "Fizz", new string[0])]
        [Xunit.InlineDataAttribute("67", "67", new string[0])]
        [Xunit.InlineDataAttribute("68", "68", new string[0])]
        [Xunit.InlineDataAttribute("69", "Fizz", new string[0])]
        [Xunit.InlineDataAttribute("70", "Buzz", new string[0])]
        [Xunit.InlineDataAttribute("71", "71", new string[0])]
        [Xunit.InlineDataAttribute("72", "Fizz", new string[0])]
        [Xunit.InlineDataAttribute("73", "73", new string[0])]
        [Xunit.InlineDataAttribute("74", "74", new string[0])]
        [Xunit.InlineDataAttribute("75", "FizzBuzz", new string[0])]
        [Xunit.InlineDataAttribute("76", "76", new string[0])]
        [Xunit.InlineDataAttribute("77", "77", new string[0])]
        [Xunit.InlineDataAttribute("78", "Fizz", new string[0])]
        [Xunit.InlineDataAttribute("79", "79", new string[0])]
        [Xunit.InlineDataAttribute("80", "Buzz", new string[0])]
        [Xunit.InlineDataAttribute("81", "Fizz", new string[0])]
        [Xunit.InlineDataAttribute("82", "82", new string[0])]
        [Xunit.InlineDataAttribute("83", "83", new string[0])]
        [Xunit.InlineDataAttribute("84", "Fizz", new string[0])]
        [Xunit.InlineDataAttribute("85", "Buzz", new string[0])]
        [Xunit.InlineDataAttribute("86", "86", new string[0])]
        [Xunit.InlineDataAttribute("87", "Fizz", new string[0])]
        [Xunit.InlineDataAttribute("88", "88", new string[0])]
        [Xunit.InlineDataAttribute("89", "89", new string[0])]
        [Xunit.InlineDataAttribute("90", "FizzBuzz", new string[0])]
        [Xunit.InlineDataAttribute("91", "91", new string[0])]
        [Xunit.InlineDataAttribute("92", "92", new string[0])]
        [Xunit.InlineDataAttribute("93", "Fizz", new string[0])]
        [Xunit.InlineDataAttribute("94", "94", new string[0])]
        [Xunit.InlineDataAttribute("95", "Buzz", new string[0])]
        [Xunit.InlineDataAttribute("96", "Fizz", new string[0])]
        [Xunit.InlineDataAttribute("97", "97", new string[0])]
        [Xunit.InlineDataAttribute("98", "98", new string[0])]
        [Xunit.InlineDataAttribute("99", "Fizz", new string[0])]
        [Xunit.InlineDataAttribute("100", "Buzz", new string[0])]
        public virtual void PrintFizzBuzz(string number, string fizzBuz, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "tag1"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("number", number);
            argumentsOfScenario.Add("FizzBuz", fizzBuz);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Print FizzBuzz", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 7
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 8
 testRunner.Given(string.Format("the number is {0}", number), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 9
 testRunner.When("I print the result", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 10
 testRunner.Then(string.Format("{0} should be printed", fizzBuz), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                FizzBuzzFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                FizzBuzzFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
