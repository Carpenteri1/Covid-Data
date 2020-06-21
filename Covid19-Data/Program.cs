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

        static async Task Main(string[] args)
        {
            await GetRequest.ProcessRepositories();
        }
    }
}
