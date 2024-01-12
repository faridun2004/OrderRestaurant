using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderRestaurant
{
    internal class Chef
    {
        public string Name { get; set; }

        public Chef(string name)
        {
            Name = name;
        }

        public void Cook(Dish dish)
        {
            Console.WriteLine($"{Name} is cooking {dish.Name}!");
        }
    }
}
