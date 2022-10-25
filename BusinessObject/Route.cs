using System;
using System.Collections.Generic;

namespace BusinessObject
{
    public partial class Route
    {
        public Route()
        {
            Trips = new HashSet<Trip>();
        }

        public Route(int id, string from, string to, int price)
        {
            Id = id;
            From = from;
            To = to;
            Price = price;
            Trips = new HashSet<Trip>();
        }

        public int Id { get; set; }
        public string From { get; set; } = null!;
        public string To { get; set; } = null!;
        public int Price { get; set; }

        public virtual ICollection<Trip> Trips { get; set; }
    }
}
