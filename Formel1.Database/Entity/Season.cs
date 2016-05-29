using System;

namespace Formel1.Database.Entity
{
    public class Season
    {
        public int SeasonId { get; set; }
        public DateTime Year { get; set; }
        public int RaceId { get; set; }
    }
}