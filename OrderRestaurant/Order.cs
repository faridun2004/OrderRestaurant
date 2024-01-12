using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderRestaurant
{
    internal class Order
    {
        public User Customer { get; set; }
        public Table Table { get; set; }
        public List<Dish> OrderedDishes { get; set; } = new List<Dish>();

        public Order(User customer, Table table)
        {
            Customer = customer;
            Table = table;
        }

        public void AddDish(Dish dish)
        {
            OrderedDishes.Add(dish);
            Console.WriteLine($"{dish.Name} added to the order for table {Table.Number}.");
        }

        public double CalculateTotal()
        {
            double total = 0;
            foreach (var dish in OrderedDishes)
            {
                total += dish.Price;
            }
            return total;
        }
    }
}
