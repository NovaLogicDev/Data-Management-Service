﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by Reqnroll (https://www.reqnroll.net/).
//      Reqnroll Version:2.0.0.0
//      Reqnroll Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace EdFi.DataManagementService.Api.Tests.E2E.Features.Resources
{
    using Reqnroll;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Reqnroll", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Resources \"Read\" Operation validations")]
    public partial class ResourcesReadOperationValidationsFeature
    {
        
        private global::Reqnroll.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "ReadResourcesValidation.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual async System.Threading.Tasks.Task FeatureSetupAsync()
        {
            testRunner = global::Reqnroll.TestRunnerManager.GetTestRunnerForAssembly(null, NUnit.Framework.TestContext.CurrentContext.WorkerId);
            global::Reqnroll.FeatureInfo featureInfo = new global::Reqnroll.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/Resources", "Resources \"Read\" Operation validations", null, global::Reqnroll.ProgrammingLanguage.CSharp, featureTags);
            await testRunner.OnFeatureStartAsync(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual async System.Threading.Tasks.Task FeatureTearDownAsync()
        {
            await testRunner.OnFeatureEndAsync();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public async System.Threading.Tasks.Task TestInitializeAsync()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public async System.Threading.Tasks.Task TestTearDownAsync()
        {
            await testRunner.OnScenarioEndAsync();
        }
        
        public void ScenarioInitialize(global::Reqnroll.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public async System.Threading.Tasks.Task ScenarioStartAsync()
        {
            await testRunner.OnScenarioStartAsync();
        }
        
        public async System.Threading.Tasks.Task ScenarioCleanupAsync()
        {
            await testRunner.CollectScenarioErrorsAsync();
        }
        
        public virtual async System.Threading.Tasks.Task FeatureBackgroundAsync()
        {
#line 3
        #line hidden
#line 4
            await testRunner.GivenAsync("the Data Management Service must receive a token issued by \"http://localhost\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 5
              await testRunner.AndAsync("user is already authorized", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 6
              await testRunner.AndAsync("a POST request is made to \"ed-fi/absenceEventCategoryDescriptors\" with", @"  {
      ""codeValue"": ""Sick Leave"",
      ""description"": ""Sick Leave"",
      ""effectiveBeginDate"": ""2024-05-14"",
      ""effectiveEndDate"": ""2024-05-14"",
      ""namespace"": ""uri://ed-fi.org/AbsenceEventCategoryDescriptor"",
      ""shortDescription"": ""Sick Leave""
  }", ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 17
             await testRunner.ThenAsync("it should respond with 201", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify existing resources can be retrieved successfully")]
        [NUnit.Framework.IgnoreAttribute("Ignored scenario")]
        public async System.Threading.Tasks.Task VerifyExistingResourcesCanBeRetrievedSuccessfully()
        {
            string[] tagsOfScenario = new string[] {
                    "ignore"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Verify existing resources can be retrieved successfully", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 20
        this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 3
        await this.FeatureBackgroundAsync();
#line hidden
#line 21
             await testRunner.WhenAsync("a GET request is made to \"ed-fi/absenceEventCategoryDescriptors\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 22
             await testRunner.ThenAsync("it should respond with 200", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 23
              await testRunner.AndAsync("the response body is", @"  [
      {
          ""id"": ""{id}"",
          ""codeValue"": ""Jury duty"",
          ""description"": ""Jury duty"",
          ""effectiveBeginDate"": ""2024-05-14"",
          ""effectiveEndDate"": ""2024-05-14"",
          ""namespace"": ""uri://ed-fi.org/AbsenceEventCategoryDescriptor"",
          ""shortDescription"": ""Jury duty""
      }
  ]", ((global::Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify retrieving a single resource by ID")]
        public async System.Threading.Tasks.Task VerifyRetrievingASingleResourceByID()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Verify retrieving a single resource by ID", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 38
        this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 3
        await this.FeatureBackgroundAsync();
#line hidden
#line 40
             await testRunner.WhenAsync("a GET request is made to \"ed-fi/absenceEventCategoryDescriptors/{id}\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 41
             await testRunner.ThenAsync("it should respond with 200", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 42
              await testRunner.AndAsync("the response body is", @"  {
    ""codeValue"": ""Sick Leave"",
    ""description"": ""Sick Leave"",
    ""effectiveBeginDate"": ""2024-05-14"",
    ""effectiveEndDate"": ""2024-05-14"",
    ""namespace"": ""uri://ed-fi.org/AbsenceEventCategoryDescriptor"",
    ""shortDescription"": ""Sick Leave""
  }", ((global::Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify response code 404 when ID does not exist")]
        public async System.Threading.Tasks.Task VerifyResponseCode404WhenIDDoesNotExist()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Verify response code 404 when ID does not exist", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 54
        this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 3
        await this.FeatureBackgroundAsync();
#line hidden
#line 55
             await testRunner.WhenAsync("a GET request is made to \"ed-fi/absenceEventCategoryDescriptors/123123123123\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 56
             await testRunner.ThenAsync("it should respond with 404", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify array records content on GET All")]
        [NUnit.Framework.IgnoreAttribute("Ignored scenario")]
        public async System.Threading.Tasks.Task VerifyArrayRecordsContentOnGETAll()
        {
            string[] tagsOfScenario = new string[] {
                    "ignore"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Verify array records content on GET All", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 59
        this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 3
        await this.FeatureBackgroundAsync();
#line hidden
#line 60
             await testRunner.WhenAsync("a GET request is made to \"ed-fi/absenceEventCategoryDescriptors\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 61
             await testRunner.ThenAsync("it should respond with 200", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 62
              await testRunner.AndAsync("total of records should be \"1\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 63
              await testRunner.AndAsync("the record with ID {id} should exist", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
    }
}
#pragma warning restore
#endregion
