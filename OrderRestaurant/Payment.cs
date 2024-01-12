using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderRestaurant
{
    internal class Payment
    {
        public Order Order { get; set; }

        public Payment(Order order)
        {
            Order = order;
        }

        public void ProcessPayment()
        {
            double totalAmount = Order.CalculateTotal();
            Console.WriteLine($"Payment processed for order at table {Order.Table.Number}. Amount: ${totalAmount}");
        }

        public void DisplayPaymentDetails()
        {
            Console.WriteLine($"Payment details - Order at table {Order.Table.Number}");
            Console.WriteLine($"Customer: {Order.Customer.Name}");
            Console.WriteLine($"Total Amount: ${Order.CalculateTotal()}");
        }
    }
}
