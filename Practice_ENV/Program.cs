using System;
using Practice_ENV;

namespace Practice_ENV
{
    class Program
    {
        static readonly HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            try
            {
                using HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/todos");

                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                Console.WriteLine(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message: {0}", e.Message, "\n");
            }
        }
    }
}