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
        public ActionResult Index(Land land)
        {
            return RedirectToAction("DisplayLandDetails");
        }
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
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Land land)
        {
            LandRepositary.Add(land);
            TempData["Message"] = "Added";
            return RedirectToAction("DisplayLandDetails");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Land land = LandRepositary.GetLandById(id);
            return View(land);
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            LandRepositary.Delete(id);
            return RedirectToAction("DisplayLandDetails");
        }
        [HttpPost]
        public ActionResult Update(Land land)
        {
            LandRepositary.Update(land);
            return RedirectToAction("DisplayLandDetails");

        }
         
    }
}