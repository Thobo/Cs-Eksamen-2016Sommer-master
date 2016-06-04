using Formel1.Database.Entity;
using System.Data.Entity;

namespace Formel1.Database
{
    public class Formel1Context : DbContext
    {
        public Formel1Context() : base("name=formel1Db")
        {

        }
        public virtual DbSet<Driver> Drivers { get; set; }
        public virtual DbSet<Race> Races { get; set; }
        public virtual DbSet<Result> Results { get; set; }
        public virtual DbSet<Season> Seasons { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
    }
}
