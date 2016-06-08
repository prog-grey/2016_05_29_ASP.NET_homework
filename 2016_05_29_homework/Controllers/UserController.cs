using _2016_05_29_homework.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace _2016_05_29_homework.Controllers
{
	public class UserController : Controller
	{
		UserModel um = new UserModel();
		// GET: User
		public ViewResult Index()
		{
			ViewBag.Um = um.getUserList();

			Configuration config = WebConfigurationManager.OpenWebConfiguration(Request.ApplicationPath);
			if( config.AppSettings.Settings["usersCount"] != null && WebConfigurationManager.AppSettings["usersCount"] == ViewBag.Um.Count.ToString() )
				config.AppSettings.Settings["usersCount"].Value = ViewBag.Um.Count.ToString();
			else
				config.AppSettings.Settings.Add("usersCount", ViewBag.Um.Count.ToString());
			config.Save(ConfigurationSaveMode.Modified);

			return View();
		}


	}
}