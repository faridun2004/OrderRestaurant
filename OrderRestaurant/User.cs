using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderRestaurant
{
    internal class User
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public User(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public void PlaceOrder(Order order)
        {
            Console.WriteLine($"{Name} placed an order for table {order.Table.Number}.");
        }
    }
}
