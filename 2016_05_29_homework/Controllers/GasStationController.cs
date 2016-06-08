using _2016_05_29_homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2016_05_29_homework.Controllers
{
    public class GasStationController : Controller
    {
		private GasStationModel gasStation = new GasStationModel();
        // GET: GasStation
        public ActionResult Index()
        {
            return View();
        }

		[HttpPost]
		public ActionResult Calculate(double price, double count) {
			gasStation.calculate(count, price);
			gasStation.Price = price;
			gasStation.Count = count;
			ViewBag.GasStation = gasStation;
			return View();
		}

    }
}