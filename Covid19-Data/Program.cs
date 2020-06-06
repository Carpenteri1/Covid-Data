using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;
using System.Text.Json;
namespace Covid19_Data
{
    class Program
    {

        private static readonly HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            await ProcessRepositories();
        }
        private static async Task ProcessRepositories()
        {
            var streamTask = client.GetStreamAsync("https://api.coronatracker.com/v2/analytics/country");
            var repositories = await JsonSerializer.DeserializeAsync<List<CovidData>>(await streamTask);
            foreach (var repo in repositories)
                Console.WriteLine($"Country: {repo.country} Confirmed: {repo.confirmed} Deaths: {repo.deaths} Recovered: {repo.recovered} Last update: {repo.lastUpdated}\n" );

            Console.ReadKey();

        }
    }
}
