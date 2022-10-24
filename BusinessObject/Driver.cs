using System;
using System.Collections.Generic;

namespace CoachManagement
{
    public partial class Driver
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Position { get; set; } = null!;
        public DateTime Birthday { get; set; }
        public string? NumberPlate { get; set; }

        public virtual Coach? NumberPlateNavigation { get; set; }
    }
}
