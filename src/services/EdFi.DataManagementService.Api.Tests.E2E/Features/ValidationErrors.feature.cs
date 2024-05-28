﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by Reqnroll (https://www.reqnroll.net/).
//      Reqnroll Version:1.0.0.0
//      Reqnroll Generator Version:1.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace EdFi.DataManagementService.Api.Tests.E2E.Features
{
    using Reqnroll;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Reqnroll", "1.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ValidationErrors")]
    public partial class ValidationErrorsFeature
    {
        
        private Reqnroll.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "ValidationErrors.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual async System.Threading.Tasks.Task FeatureSetupAsync()
        {
            testRunner = Reqnroll.TestRunnerManager.GetTestRunnerForAssembly(null, NUnit.Framework.TestContext.CurrentContext.WorkerId);
            Reqnroll.FeatureInfo featureInfo = new Reqnroll.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "ValidationErrors", "    POST a request that has an invalid payload.", ProgrammingLanguage.CSharp, featureTags);
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
        
        public void ScenarioInitialize(Reqnroll.ScenarioInfo scenarioInfo)
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
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post an empty request object")]
        public async System.Threading.Tasks.Task PostAnEmptyRequestObject()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            Reqnroll.ScenarioInfo scenarioInfo = new Reqnroll.ScenarioInfo("Post an empty request object", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 4
        this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 5
             await testRunner.WhenAsync("a POST request is made to \"data/ed-fi/schools\" with", "", ((Reqnroll.Table)(null)), "When ");
#line hidden
#line 8
             await testRunner.ThenAsync("it should respond with 400", ((string)(null)), ((Reqnroll.Table)(null)), "Then ");
#line hidden
#line 9
              await testRunner.AndAsync("the response body is", "{\"detail\":\"The request could not be processed. See \'errors\' for details.\",\"type\":" +
                        "\"urn:ed-fi:api:bad-request\",\"title\":\"Bad Request\",\"status\":400,\"correlationId\":n" +
                        "ull,\"validationErrors\":{},\"errors\":[\"A non-empty request body is required.\"]}", ((Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post an invalid body for academicWeeks when weekIdentifier length should be at le" +
            "ast 5 characters")]
        public async System.Threading.Tasks.Task PostAnInvalidBodyForAcademicWeeksWhenWeekIdentifierLengthShouldBeAtLeast5Characters()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            Reqnroll.ScenarioInfo scenarioInfo = new Reqnroll.ScenarioInfo("Post an invalid body for academicWeeks when weekIdentifier length should be at le" +
                    "ast 5 characters", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 14
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 15
 await testRunner.WhenAsync("a POST request is made to \"data/ed-fi/academicWeeks\" with", "{\r\n \"weekIdentifier\": \"one\",\r\n \"schoolReference\": {\r\n   \"schoolId\": 17012391\r\n }," +
                        "\r\n \"beginDate\": \"2023-09-11\",\r\n \"endDate\": \"2023-09-11\",\r\n \"totalInstructionalDa" +
                        "ys\": 300\r\n}", ((Reqnroll.Table)(null)), "When ");
#line hidden
#line 27
  await testRunner.ThenAsync("it should respond with 400", ((string)(null)), ((Reqnroll.Table)(null)), "Then ");
#line hidden
#line 28
    await testRunner.AndAsync("the response body is", @"{""detail"":""Data validation failed. See 'validationErrors' for details."",""type"":""urn:ed-fi:api:bad-request:data"",""title"":""Data Validation Failed"",""status"":400,""correlationId"":null,""validationErrors"":{""$.weekIdentifier"":[""weekIdentifier Value should be at least 5 characters""]},""errors"":[]}", ((Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post an invalid body for academicWeeks missing schoolid for schoolReference and t" +
            "otalInstructionalDays")]
        public async System.Threading.Tasks.Task PostAnInvalidBodyForAcademicWeeksMissingSchoolidForSchoolReferenceAndTotalInstructionalDays()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            Reqnroll.ScenarioInfo scenarioInfo = new Reqnroll.ScenarioInfo("Post an invalid body for academicWeeks missing schoolid for schoolReference and t" +
                    "otalInstructionalDays", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 33
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 34
  await testRunner.WhenAsync("a POST request is made to \"data/ed-fi/academicWeeks\" with", "{\r\n  \"weekIdentifier\": \"seven\",\r\n  \"schoolReference\": {\r\n  },\r\n  \"beginDate\": \"20" +
                        "23-09-11\",\r\n  \"endDate\": \"2023-09-11\"\r\n}", ((Reqnroll.Table)(null)), "When ");
#line hidden
#line 44
 await testRunner.ThenAsync("it should respond with 400", ((string)(null)), ((Reqnroll.Table)(null)), "Then ");
#line hidden
#line 45
    await testRunner.AndAsync("the response body is", @"{""detail"":""Data validation failed. See 'validationErrors' for details."",""type"":""urn:ed-fi:api:bad-request:data"",""title"":""Data Validation Failed"",""status"":400,""correlationId"":null,""validationErrors"":{""$.totalInstructionalDays"":[""totalInstructionalDays is required.""],""$.schoolReference.schoolId"":[""schoolId is required.""]},""errors"":[]}", ((Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post a valid Descriptor")]
        public async System.Threading.Tasks.Task PostAValidDescriptor()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            Reqnroll.ScenarioInfo scenarioInfo = new Reqnroll.ScenarioInfo("Post a valid Descriptor", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 50
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 51
  await testRunner.WhenAsync("a POST request is made to \"data/ed-fi/absenceEventCategoryDescriptors\" with", "{\r\n\"codeValue\": \"Sample\",\r\n\"shortDescription\": \"Bereavement\",\r\n\"namespace\": \"uri:" +
                        "//ed-fi.org/AbsenceEventCategoryDescriptor\"\r\n}", ((Reqnroll.Table)(null)), "When ");
#line hidden
#line 59
  await testRunner.ThenAsync("it should respond with 201", ((string)(null)), ((Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post an invalid body for academicWeeks missing more than one required field")]
        public async System.Threading.Tasks.Task PostAnInvalidBodyForAcademicWeeksMissingMoreThanOneRequiredField()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            Reqnroll.ScenarioInfo scenarioInfo = new Reqnroll.ScenarioInfo("Post an invalid body for academicWeeks missing more than one required field", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 62
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 63
  await testRunner.WhenAsync("a POST request is made to \"data/ed-fi/academicWeeks\" with", "{\r\n  \"_weekIdentifier\": \"abcdef\",\r\n  \"_schoolReference\": {\r\n      \"schoolId\": 255" +
                        "901001\r\n  },\r\n  \"_beginDate\": \"2024-04-04\",\r\n  \"_endDate\": \"2024-04-04\",\r\n  \"_to" +
                        "talInstructionalDays\": 300\r\n}", ((Reqnroll.Table)(null)), "When ");
#line hidden
#line 75
  await testRunner.ThenAsync("it should respond with 400", ((string)(null)), ((Reqnroll.Table)(null)), "Then ");
#line hidden
#line 76
    await testRunner.AndAsync("the response body is", @"{""detail"":""Data validation failed. See 'validationErrors' for details."",""type"":""urn:ed-fi:api:bad-request:data"",""title"":""Data Validation Failed"",""status"":400,""correlationId"":null,""validationErrors"":{""$.schoolReference"":[""schoolReference is required.""],""$.weekIdentifier"":[""weekIdentifier is required.""],""$.beginDate"":[""beginDate is required.""],""$.endDate"":[""endDate is required.""],""$.totalInstructionalDays"":[""totalInstructionalDays is required.""]},""errors"":[]}", ((Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post an invalid body for academicWeeks missing a required field in a nested objec" +
            "t schoolid for schoolReference")]
        public async System.Threading.Tasks.Task PostAnInvalidBodyForAcademicWeeksMissingARequiredFieldInANestedObjectSchoolidForSchoolReference()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            Reqnroll.ScenarioInfo scenarioInfo = new Reqnroll.ScenarioInfo("Post an invalid body for academicWeeks missing a required field in a nested objec" +
                    "t schoolid for schoolReference", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 81
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 82
  await testRunner.WhenAsync("a POST request is made to \"data/ed-fi/academicWeeks\" with", "{\r\n  \"weekIdentifier\": \"abcdef\",\r\n  \"schoolReference\": {\r\n      \"_schoolId\": 2559" +
                        "01001\r\n  },\r\n  \"beginDate\": \"2024-04-04\",\r\n  \"endDate\": \"2024-04-04\",\r\n  \"totalI" +
                        "nstructionalDays\": 300\r\n}", ((Reqnroll.Table)(null)), "When ");
#line hidden
#line 94
  await testRunner.ThenAsync("it should respond with 400", ((string)(null)), ((Reqnroll.Table)(null)), "Then ");
#line hidden
#line 95
    await testRunner.AndAsync("the response body is", @"{""detail"":""Data validation failed. See 'validationErrors' for details."",""type"":""urn:ed-fi:api:bad-request:data"",""title"":""Data Validation Failed"",""status"":400,""correlationId"":null,""validationErrors"":{""$.schoolReference.schoolId"":[""schoolId is required.""]},""errors"":[]}", ((Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post an invalid body for academicWeeks missing a comma before beginDate")]
        public async System.Threading.Tasks.Task PostAnInvalidBodyForAcademicWeeksMissingACommaBeforeBeginDate()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            Reqnroll.ScenarioInfo scenarioInfo = new Reqnroll.ScenarioInfo("Post an invalid body for academicWeeks missing a comma before beginDate", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 100
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 101
  await testRunner.WhenAsync("a POST request is made to \"data/ed-fi/academicWeeks\" with", "{\r\n  \"weekIdentifier\": \"abcdef\",\r\n  \"schoolReference\": {\r\n      \"schoolId\": 25590" +
                        "1001\r\n  }\r\n  \"beginDate\": \"2024-04-04\",\r\n  \"endDate\": \"2024-04-04\",\r\n  \"totalIns" +
                        "tructionalDays\": 300\r\n}", ((Reqnroll.Table)(null)), "When ");
#line hidden
#line 113
  await testRunner.ThenAsync("it should respond with 400", ((string)(null)), ((Reqnroll.Table)(null)), "Then ");
#line hidden
#line 114
    await testRunner.AndAsync("the response body is", @"{""detail"":""Data validation failed. See 'validationErrors' for details."",""type"":""urn:ed-fi:api:bad-request:data"",""title"":""Data Validation Failed"",""status"":400,""correlationId"":null,""validationErrors"":{""$."":[""'\""' is invalid after a value. Expected either ',', '}', or ']'. LineNumber: 5 | BytePositionInLine: 2.""]},""errors"":[]}", ((Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post an invalid body for courseOfferings missing a two required fields for a nest" +
            "ed object CourseReference and also schoolReference")]
        public async System.Threading.Tasks.Task PostAnInvalidBodyForCourseOfferingsMissingATwoRequiredFieldsForANestedObjectCourseReferenceAndAlsoSchoolReference()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            Reqnroll.ScenarioInfo scenarioInfo = new Reqnroll.ScenarioInfo("Post an invalid body for courseOfferings missing a two required fields for a nest" +
                    "ed object CourseReference and also schoolReference", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 119
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 120
  await testRunner.WhenAsync("a POST request is made to \"data/ed-fi/courseOfferings\" with", @"{
  ""localCourseCode"": ""1"",
  ""courseReference"": {
      ""_courseCode"": ""1"",
      ""_educationOrganizationId"": 1
  },
   ""_schoolReference"": {
      ""schoolId"": 255901001
  },
  ""sessionReference"": {
      ""schoolId"": 255901001,
      ""schoolYear"": 2022,
      ""sessionName"": ""Test""
  }
}", ((Reqnroll.Table)(null)), "When ");
#line hidden
#line 138
  await testRunner.ThenAsync("it should respond with 400", ((string)(null)), ((Reqnroll.Table)(null)), "Then ");
#line hidden
#line 139
    await testRunner.AndAsync("the response body is", @"{""detail"":""Data validation failed. See 'validationErrors' for details."",""type"":""urn:ed-fi:api:bad-request:data"",""title"":""Data Validation Failed"",""status"":400,""correlationId"":null,""validationErrors"":{""$.schoolReference"":[""schoolReference is required.""],""$.courseReference.courseCode"":[""courseCode is required.""],""$.courseReference.educationOrganizationId"":[""educationOrganizationId is required.""]},""errors"":[]}", ((Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
    }
}
#pragma warning restore
#endregion
