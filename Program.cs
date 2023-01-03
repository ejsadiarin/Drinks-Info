using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Text.Json;

// Http client instance
using HttpClient client = new HttpClient();

// set API key in request headers
client.DefaultRequestHeaders.Accept.Clear();
client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
client.DefaultRequestHeaders.Add("API-key", "1");

var repositories = await ProcessRepositoriesAsync(client);

foreach (var repo in repositories)
{
    Console.WriteLine($"Name: {repo.Name}");
}

static async Task<List<Repository>> ProcessRepositoriesAsync(HttpClient client)
{
    await using Stream stream = await client.GetStreamAsync("www.thecocktaildb.com/api/json/v1/1/filter.php?c=Cocktail");
    var repositories = await JsonSerializer.DeserializeAsync<List<Repository>>(stream);
    return repositories ?? new();
}


