using System;
using System.Collections.Generic;

namespace CoachManagement
{
    public partial class Ticket
    {
        public long Id { get; set; }
        public DateTime BookTime { get; set; }
        public string? PassengerId { get; set; }
        public long? TripId { get; set; }

        public virtual Passenger? Passenger { get; set; }
        public virtual Trip? Trip { get; set; }
    }
}
