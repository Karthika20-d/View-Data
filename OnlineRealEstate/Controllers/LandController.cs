using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineRealEstateRepositary;
using OnlineRealEstateEntity;

namespace OnlineRealEstate.Controllers
{
    public class LandController : Controller
    {
        // GET: Land
        public ActionResult DisplayLandDetails()
        {
            IEnumerable<Land> land = LandRepositary.GetLandDetails();
            ViewBag.Land = land;
            ViewData["land"] = land;
            TempData["land"] = land;
            return RedirectToAction("DisplayDetails");
        }
        public ActionResult DisplayDetails()
        {
            return View();
        }
    }
}