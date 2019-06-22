using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MyConsole
{
    public static class Blackcat
    {
        public static async Task Ship(Order order)
        { 
            var httpClient = new HttpClient() { BaseAddress = new Uri("http://blackcat.com/") };
            var response = await httpClient.PostAsJsonAsync("api/ship", order);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"web api error, order:{order}");
            }
        }
    }
}