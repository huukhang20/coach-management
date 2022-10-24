using System;
using System.Collections.Generic;

namespace CoachManagement
{
    public partial class Coach
    {
        public Coach()
        {
            Drivers = new HashSet<Driver>();
            Trips = new HashSet<Trip>();
        }

        public string NumberPlate { get; set; } = null!;
        public int Seats { get; set; }
        public bool Active { get; set; }
        public string? Brand { get; set; }
        public string? Location { get; set; }

        public virtual ICollection<Driver> Drivers { get; set; }

        public virtual ICollection<Trip> Trips { get; set; }
    }
}
