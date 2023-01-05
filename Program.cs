using System;
using System.Net.Http;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json.Linq;
using System.Text.Json;

namespace TateQuotesAPI
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new RestClient();
            var payload = new JObject();

            // Set API endpoint
            var request = new RestRequest("https://www.tateapi.com/api/quote", Method.Get);

            try
            {
                // Call the API
                RestResponse response = client.Execute(request);
                if (response.IsSuccessStatusCode)
                {
                    // Deserialize JSON into object
                   Model quote = JsonSerializer.Deserialize<Model>(response.Content);

                    // Display
                    Console.WriteLine("Quote successful: \n\n" + quote.content);
                }
                else
                {
                    Console.WriteLine("API call failed with status code: " + response.StatusCode);

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);

                
            }

        }


    }
}

