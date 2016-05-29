using Formel1.Database.Entity;

namespace Formel1.Database.Repository
{
    public class WPF
    {
        public void InsertSeason(Season season)
        {
            using (var context = new Formel1Context())
            {
                context.Seasons.Add(season);
                context.SaveChanges();
            }
        }

        public void InsertTeam(Team team)
        {
            using(var context = new Formel1Context())
            {
                context.Teams.Add(team);
                context.SaveChanges();
            }
        }

        public void InsertDrivers(Driver driver)
        {
            using (var context = new Formel1Context())
            {
                context.Drivers.Add(driver);
                context.SaveChanges();
            }
        }

        public void InsertRace(Race race)
        {
            using (var context = new Formel1Context())
            {
                context.Races.Add(race);
                context.SaveChanges();
            }
        }

        public void InsertResult(Result result)
        {
            using (var context = new Formel1Context())
            {
                context.Results.Add(result);
                context.SaveChanges();
            }
        }
    }
}
