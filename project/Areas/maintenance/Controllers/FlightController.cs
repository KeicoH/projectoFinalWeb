using System;
using System.Net;
using System.Web.Mvc;

namespace project.Areas.maintenance.Controllers
{
    public class FlightController : Controller
    {
        // GET
        public ActionResult Index()
        {
            if (ValidateUser())
            {
                
            }
            return View();
        }

        public bool ValidateUser()
        {
            var res = Session["User"] != null;
            return res;
        }
    }
}