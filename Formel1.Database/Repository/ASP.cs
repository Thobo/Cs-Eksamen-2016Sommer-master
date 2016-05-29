using Formel1.Database.Entity;
using System.Collections.Generic;
using System.Linq;

namespace Formel1.Database.Repository
{
    public class ASP : IASP
    {
        public List<Driver> GetDrivers()
        {
            List<Driver> drivers;
            using (var context = new Formel1Context())
            {
                drivers = context.Drivers.Where(d => d.DriverName != "").ToList();
            }

            return drivers;
        }
    }
}
