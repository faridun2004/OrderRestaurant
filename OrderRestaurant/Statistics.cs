using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderRestaurant
{
    internal class Statistics
    {
        public static void UpdateStatistics(Order order)
        {
            Console.WriteLine($"Statistics updated for order at table {order.Table.Number}.");
        }
    }
}
