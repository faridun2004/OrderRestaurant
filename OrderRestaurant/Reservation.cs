using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderRestaurant
{
    internal class Reservation
    {
        public User Customer { get; set; }
        public Table Table { get; set; }
        public DateTime Date { get; set; }
        public bool IsConfirmed { get; private set; }

        public Reservation(User customer, Table table, DateTime date)
        {
            Customer = customer;
            Table = table;
            Date = date;
        }

        public void ConfirmReservation()
        {
            IsConfirmed = true;
            Console.WriteLine($"Reservation for {Customer.Name} at table {Table.Number} on {Date} confirmed.");
        }
    }
}
