using System;
using System.Collections.Generic;

namespace BusinessObject
{
    public partial class Ticket
    {
        public Ticket()
        {
        }

        public Ticket(long id, DateTime bookTime, string? passengerId, long? tripId)
        {
            Id = id;
            BookTime = bookTime;
            PassengerId = passengerId;
            TripId = tripId;
        }

        public long Id { get; set; }
        public DateTime BookTime { get; set; }
        public string? PassengerId { get; set; }
        public long? TripId { get; set; }

        public virtual Passenger? Passenger { get; set; }
        public virtual Trip? Trip { get; set; }
    }
}
