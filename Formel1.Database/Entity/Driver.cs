using System.Collections.Generic;

namespace Formel1.Database.Entity
{
    public class Driver
    {
        public int DriverId { get; set; }
        public string DriverName { get; set; }
        public int Age { get; set; }
        public string  Country { get; set; }

        public int TeamId { get; set; } //Foreign key

        public virtual List<Driver> Drivers { get; set; }
    }
}