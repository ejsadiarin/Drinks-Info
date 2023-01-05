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
            using (var client = new RestClient("https://www.tateapi.com/api/quote"))
            {

                var request = new RestRequest();
                request.AddJsonBody()

            }

            // Set API endpoint

            try
            {
                // Call the API
                if ()
                { 
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

        public class Quotes
        {
            public string Quote { get; set; }
        }


    }
}

