using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderRestaurant
{
    internal class Tableware
    {
        public string Name { get; set; }

        public Tableware(string name)
        {
            Name = name;
        }

        public void SetTable(Table table)
        {
            Console.WriteLine($"{Name} is set on table {table.Number}.");
        }
    }
}
