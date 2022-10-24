using System;
using System.Collections.Generic;

namespace CoachManagement
{
    public partial class Route
    {
        public Route()
        {
            Trips = new HashSet<Trip>();
        }

        public int Id { get; set; }
        public string From { get; set; } = null!;
        public string To { get; set; } = null!;
        public int Price { get; set; }

        public virtual ICollection<Trip> Trips { get; set; }
    }
}
