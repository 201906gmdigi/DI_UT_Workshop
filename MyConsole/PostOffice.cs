using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MyConsole
{
    public class PostOffice
    {
        public static async Task PlaceOrder(Order order)
        {
            var httpClient = new HttpClient() {BaseAddress = new Uri("http://postoffice.com/")};
            var response = await httpClient.PostAsJsonAsync("api/order", order);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"web api error, order:{order}");
            }
        }
    }
}