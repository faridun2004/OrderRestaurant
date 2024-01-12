using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderRestaurant
{
    internal class Menu
    {
        public string Name { get; set; }
        public List<Dish> Dishes { get; set; } = new List<Dish>();

        public Menu(string name)
        {
            Name = name;
        }

        public void AddDish(Dish dish)
        {
            Dishes.Add(dish);
            Console.WriteLine($"Added {dish.Name} to the menu.");
        }
    }
}
