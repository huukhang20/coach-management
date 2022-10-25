using System;
using System.Collections.Generic;

namespace BusinessObject
{
    public partial class Driver
    {
        public Driver()
        {
        }

        public Driver(string id, string name, string position, DateTime birthday, string? numberPlate)
        {
            Id = id;
            Name = name;
            Position = position;
            Birthday = birthday;
            NumberPlate = numberPlate;
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Position { get; set; } = null!;
        public DateTime Birthday { get; set; }
        public string? NumberPlate { get; set; }

        public virtual Coach? NumberPlateNavigation { get; set; }
    }
}
