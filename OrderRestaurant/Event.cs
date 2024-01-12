using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderRestaurant
{
    internal class Event
    {
        public string Name { get; set; }
        public List<User> Participants { get; set; } = new List<User>();

        public Event(string name)
        {
            Name = name;
        }

        public void AddParticipant(User user)
        {
            Participants.Add(user);
            Console.WriteLine($"{user.Name} joined the event {Name}!");
        }
    }
}
