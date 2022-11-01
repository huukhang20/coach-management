using System;
using System.Collections.Generic;

namespace BusinessObject
{
    public partial class Trip
    {
        public Trip()
        {
            Tickets = new HashSet<Ticket>();
        }

        public Trip(string from, string to, DateTime departTime, int status, decimal price, string? numberPlate)
        {
            From = from;
            To = to;
            DepartTime = departTime;
            Status = status;
            Price = price;
            NumberPlate = numberPlate;
            Tickets = new HashSet<Ticket>();
        }

        public Trip(long id, string from, string to, DateTime departTime, int status, decimal price, string? numberPlate)
        {
            Id = id;
            From = from;
            To = to;
            DepartTime = departTime;
            Status = status;
            Price = price;
            NumberPlate = numberPlate;
            Tickets = new HashSet<Ticket>();
        }

        public long Id { get; set; }
        public string From { get; set; } = null!;
        public string To { get; set; } = null!;
        public DateTime DepartTime { get; set; }
        public int Status { get; set; }
        public decimal Price { get; set; }
        public string? NumberPlate { get; set; }

        public virtual Coach? NumberPlateNavigation { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
