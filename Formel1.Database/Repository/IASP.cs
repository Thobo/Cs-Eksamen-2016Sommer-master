using Formel1.Database.Entity;
using System.Collections.Generic;

namespace Formel1.Database.Repository
{
    public  interface IASP
    {
        List<Driver> GetDrivers();
    }
}