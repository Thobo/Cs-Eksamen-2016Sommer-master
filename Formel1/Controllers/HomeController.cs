using System.Web.Mvc;
using Formel1.Database.Entity;
using System.Collections.Generic;

namespace Formel1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            //var wpf = new Database.Repository.WPF();
            //wpf.InsertDrivers(new Driver { DriverName = "Ulrik 2" });

            Database.Repository.IASP aspRepo = new Database.Repository.ASP();
            var driverList = aspRepo.GetDrivers();

            return View(driverList);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}