using System.Collections.Generic;

namespace Formel1.Database.Entity
{
    public class Team
    {
        public int TeamId { get; set; } //Primary key
        public string TeamName { get; set; }
        public string EngineSupplier { get; set; }

        //Navigation property
        public virtual List<Driver> Drivers { get; set; }
    }
}