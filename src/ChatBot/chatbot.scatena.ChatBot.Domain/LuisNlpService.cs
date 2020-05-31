using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using chatbot.scatena.ChatBot.Domain.Interfaces;
using Microsoft.Extensions.Configuration;

namespace chatbot.scatena.ChatBot.Domain
{
    public class LuisNlpService : INlpService
    {
        private string _endpoint;
        private string _key;
        private string _appId;

        public LuisNlpService(IConfiguration configuration)
        {
            _endpoint = configuration["nlp:endpoint"]; 
            _key = configuration["nlp:key"];
            _appId = configuration["nlp:appId"];

        }

        public async Task<string> ProcessText(string text)
        {
            using(var client = new HttpClient())
            {
                var queryString = HttpUtility.ParseQueryString(string.Empty);

                client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", _key);
                queryString["query"] = text;

                queryString["verbose"] = "true";
                queryString["show-all-intents"] = "true";
                queryString["staging"] = "false";
                queryString["timezoneOffset"] = "0";
                queryString["log"]="true";

                var endpointUri = string.Format("{0}luis/prediction/v3.0/apps/{1}/slots/production/predict?{2}", _endpoint, _appId, queryString);
                Console.WriteLine("Url: " + endpointUri);
                var response = await client.GetAsync(endpointUri);

                var strResponseContent = await response.Content.ReadAsStringAsync();

                return strResponseContent;

            }
        }
    }
}