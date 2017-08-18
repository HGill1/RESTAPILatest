using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace RESTAPITest.Steps
{
    [Binding]
    class OneSupportedPension142
    {
        private string jsonResponse;

        private IRestResponse response;

        [Given(@"This is the first time I am using the skill")]
        public void GivenThisIsTheFirstTimeIAmUsingTheSkill()
        {
            var client = new RestClient("http://euw1aemyavaw201.avivaaws.com:8095/VoiceAPI/api/voice");
            var request = new RestRequest(Method.POST);
            request.AddHeader("postman-token", "a5ef0176-95d0-7010-b1cd-d54f780bb070");
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("content-type", "application/json");
            request.AddHeader("x-options", "{ \"Oan\": \"5962410379\" }");
            request.AddParameter("application/json", "{\r\n  \"type\": \"IntentRequest\",\r\n   \"id\": \"EdwRequestId.9e45c25b-7ddb-4ded-b0aa-f4ddccbb4cce\",\r\n   \"locale\": \"en-GB\",\r\n   \"timestamp\": \"2017-05-15T09:48:39.8073479+01:00\",\r\n   \"source\": \"Alexa\",\r\n   \"session\": {\r\n     \"id\": \"SessionId.fada60cc-60c5-43ca-acad-b7108adc4335\",\r\n     \"isNew\": true\r\n   },\r\n   \"user\": {\r\n     \"id\": \"amzn1.ask.account.AHW3SBAMKI7A3T24W2E43JUESYUVJ4AD6HXRADHR7P3PFEOL7NDHNZUBY56C7VH7XLEE4L3\",\r\n     \"accessToken\": \"eyJhbGciOiJSUzI1NiJ9.eyJqdGkiOiJvYXV0aC10b2tlbi1mMWVhNzBkMy1mZjBmLTRkOTEtOGQ1Yi0zM.dhNqo1DbSkMWubSpKGjgn273nN\",\r\n     \"consentToken\": \"E4L3YSFW235CQWTHYSI6DS7QCJ47ZDTF5SFQCSMJMC\"\r\n   },\r\n   \"context\": {\r\n         \"attributes\": {\r\n                \"PinVerified\": true,\r\n     }\r\n   },\r\n   \"intent\": {\r\n     \"name\": \"LaunchRequest\",\r\n   },\r\n   \"device\": {\r\n     \"address\": \"51 Hoxton Square, London, N1 6PB\"\r\n   },\r\n   \"rawInput\": {\r\n     \"input\": \"how much is my pension worth\",\r\n     \"confidenceLevel\": 0.8\r\n   }\r\n}\r\n", ParameterType.RequestBody);
            response = client.Execute(request);
            this.jsonResponse = response.Content;
            Console.WriteLine(jsonResponse);
        }

        [When(@"I open the skill")]
        public void WhenIOpenTheSkill()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I will receive my first-time welcome message")]
        public void ThenIWillReceiveMyFirst_TimeWelcomeMessage()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have one supported pension")]
        public void GivenIHaveOneSupportedPension()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have launched the skill")]
        public void GivenIHaveLaunchedTheSkill()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I launch the skill")]
        public void GivenILaunchTheSkill()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I give my correct PIN")]
        public void GivenIGiveMyCorrectPIN()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I am asked whether I want to know the value of my pension")]
        public void WhenIAmAskedWhetherIWantToKnowTheValueOfMyPension()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I receive following responses")]
        public void ThenIReceiveFollowingResponses(Table table)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I am told to have a great morning")]
        public void ThenIAmToldToHaveAGreatMorning()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
