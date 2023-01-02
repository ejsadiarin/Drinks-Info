using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Text.Json;

// Http client instance
HttpClient client = new HttpClient();

// set API key in request headers
client.DefaultRequestHeaders.Add("API-key", "1");


