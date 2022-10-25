using System;
using System.Collections.Generic;

namespace BusinessObject
{
    public partial class Trip
    {
        public Trip()
        {
            Tickets = new HashSet<Ticket>();
            NumberPlates = new HashSet<Coach>();
        }

        public Trip(long id, DateTime departTime, string status, int? routeId)
        {
            Id = id;
            DepartTime = departTime;
            Status = status;
            RouteId = routeId;
            Tickets = new HashSet<Ticket>();
            NumberPlates = new HashSet<Coach>();
        }

        public long Id { get; set; }
        public DateTime DepartTime { get; set; }
        public string Status { get; set; } = null!;
        public int? RouteId { get; set; }

        public virtual Route? Route { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }

        public virtual ICollection<Coach> NumberPlates { get; set; }
    }
}
