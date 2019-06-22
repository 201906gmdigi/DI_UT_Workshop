using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace MyConsole
{
    public class OrderAgent
    {
        public async Task SyncOrders()
        {
            IEnumerable<Order> orders;
            using (var connection = new SqlConnection("my connection string"))
            {
                orders = connection.Query<Order>("spGetWaitingOrders", new {Date = DateTime.Today},
                                                 commandType: CommandType.StoredProcedure);
            }

            foreach (var order in orders)
            {
                if (order.Type == Platform.Seven)
                {
                    await Blackcat.Ship(order);
                }
                else
                {
                    await PostOffice.PlaceOrder(order);
                }
            }
        }
    }
}