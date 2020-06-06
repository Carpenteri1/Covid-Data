using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading.Tasks;

namespace Covid19_Data
{
    class GetRequest
    {
        //string path = "https://api.coronatracker.com/v2/analytics/country";
        public static async Task<CovidData> GetProductAsync(string path)
        {
            HttpClient client = new HttpClient();
            CovidData covid = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {

                covid = await response.Content.ReadAsAsync<CovidData>();
                var formatters = new List<MediaTypeFormatter>() {new JsonMediaTypeFormatter()};
;               
            }
            
                return covid;
        }

        public static void ShowProduct(CovidData covid)
        {
            Console.WriteLine($"Country: {covid.country}");
        }


    }
}
