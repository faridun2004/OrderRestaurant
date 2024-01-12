using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderRestaurant
{
    internal class Delivery
    {
        public string Name { get; set; }

        public Delivery(string name)
        {
            Name = name;
        }

        public void Deliver(Order order)
        {
            Console.WriteLine($"{Name} is delivering the order to table {order.Table.Number}.");
        }
    }
}
