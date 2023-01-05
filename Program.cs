using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace DrinksInfo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient();
            try
            {
                // Call the API 
                HttpResponseMessage response = await client.GetAsync("https://www.tateapi.com/api/quote");

                // Check if API call is successful
                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(responseContent);
                }
                else
                {
                    Console.WriteLine("API call failed with status code: " + response.StatusCode);
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
        }


    }
}

