using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var orderAgent = new OrderAgent();
            await orderAgent.SyncOrders();
        }
    }
}