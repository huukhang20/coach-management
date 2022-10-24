using System;
using System.Collections.Generic;

namespace CoachManagement
{
    public partial class Passenger
    {
        public Passenger()
        {
            Tickets = new HashSet<Ticket>();
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Phone { get; set; } = null!;

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
