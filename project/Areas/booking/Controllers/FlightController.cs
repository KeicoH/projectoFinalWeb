using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace project.Areas.booking.Controllers
{
    public class FlightController : Controller
    {
        // GET: booking/Flight
        public ActionResult Index()
        {
            return View();
        }
    }
}