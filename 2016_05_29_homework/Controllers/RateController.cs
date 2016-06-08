using _2016_05_29_homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace _2016_05_29_homework.Controllers
{
    public class RateController : Controller
    {
		private RateModel rateModel = new RateModel();
		// GET: Home
		public ActionResult Index()
		{
			return View();
		}

		public Object json ()
		{
			var rateList = rateModel.getRateList();
			var json = new JavaScriptSerializer().Serialize( rateList );
			return json;
		}

    }
}