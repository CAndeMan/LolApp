using LolApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LolApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "The Champion List page.";

            return View(new ChampionListModel());
        }

        public ActionResult Champion(int? id)
        {
            if (id == null) return Redirect("About");

            ViewBag.Message = "A Champion's Profile";

            return View(new ChampionDataModel(id ?? 0));
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}