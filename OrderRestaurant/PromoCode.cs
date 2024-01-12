using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderRestaurant
{
    internal class PromoCode
    {
        public string Code { get; set; }
        public double DiscountPercentage { get; set; }

        public PromoCode(string code, double discountPercentage)
        {
            Code = code;
            DiscountPercentage = discountPercentage;
        }

        public void ApplyDiscount(Order order)
        {
            double discountAmount = order.CalculateTotal() * DiscountPercentage;
            Console.WriteLine($"Promo code '{Code}' applied. Discount: ${discountAmount}");
        }
    }
}
