using System;
using System.Collections.Generic;

namespace BusinessObject
{
    public partial class Ticket
    {
        public Ticket()
        {
        }

        public Ticket(long id, DateTime bookTime, int seatNumber, string passengerId, long tripId)
        {
            Id = id;
            BookTime = bookTime;
            SeatNumber = seatNumber;
            PassengerId = passengerId;
            TripId = tripId;
        }

        public long Id { get; set; }
        public DateTime BookTime { get; set; }
        public int SeatNumber { get; set; }
        public string PassengerId { get; set; } = null!;
        public long TripId { get; set; }

        public virtual Passenger Passenger { get; set; } = null!;
        public virtual Trip Trip { get; set; } = null!;
    }
}
