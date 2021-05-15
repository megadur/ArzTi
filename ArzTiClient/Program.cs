using ArzTiClient.OpenAPIService;
using System;
using System.Net.Http;

namespace ArzTiClient
{
    public class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            using var httpClient = new HttpClient();

            var c= new Client(httpClient);

            //Act
            var result = await c.ApothekeGetAsync();


        }
    }
}
