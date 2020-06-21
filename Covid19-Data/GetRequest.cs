using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Covid19_Data
{
    //new API
    //https://api.covid19api.com/summary
    //https://documenter.getpostman.com/view/10808728/SzS8rjbc?version=latest

    //Old API
    //https://api.coronatracker.com/v2/analytics/country
    public class GetRequest
    {
        private static readonly HttpClient client = new HttpClient();
        public static async Task ProcessRepositories()
        {
            var streamTask = client.GetStreamAsync("https://api.coronatracker.com/v2/analytics/country");
            var repositories = await JsonSerializer.DeserializeAsync<List<CovidData>>(await streamTask);
            foreach (var repo in repositories)
                Console.WriteLine($"Country: {repo.country} Confirmed: {repo.confirmed} Deaths: {repo.deaths} Recovered: {repo.recovered} Last update: {repo.lastUpdated}\n");

            Console.ReadKey();

        }
    }
}
