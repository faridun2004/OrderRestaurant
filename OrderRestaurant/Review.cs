using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderRestaurant
{
    internal class Review
    {
        public User User { get; set; }
        public string Comment { get; set; }

        public Review(User user, string comment)
        {
            User = user;
            Comment = comment;
        }

    }
}
