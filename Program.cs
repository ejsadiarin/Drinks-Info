﻿using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Text.Json;

// Http client instance
HttpClient client = new();

// GET method from API endpoint
var response = await client.GetAsync("www.thecocktaildb.com/api/json/v1/1/filter.php?c=Cocktail");

if (response.IsSuccessStatusCode)
{
    string responseContent = await response.Content.ReadAsStringAsync();
    Console.WriteLine("Content response from API:" + responseContent + "\n");
    Console.ReadLine();
}


