using System;
using System.Collections.Generic;

namespace CoachManagement
{
    public partial class Trip
    {
        public Trip()
        {
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
