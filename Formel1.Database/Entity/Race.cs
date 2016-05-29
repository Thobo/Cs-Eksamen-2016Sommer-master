using System;
using System.Collections.Generic;

namespace Formel1.Database.Entity
{
    public class Race
    {
        public int Id { get; set; }
        public string RaceName { get; set; }
        public string Country { get; set; }
        public DateTime Date { get; set; }
        public decimal CircuitLength { get; set; }
        public string Filename { get; set; }
        public Result Result { get; set; }
        public virtual List<Race> Races { get; set; }
    }
}