﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderAgent = new OrderAgent();
            orderAgent.SyncOrders().Wait();
        }
    }
}
