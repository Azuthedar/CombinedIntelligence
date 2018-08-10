using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Combined_Intelligence.Controllers
{
	public class UserController : Controller
	{
		// GET: User
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Profile(int ID)
		{
			ViewBag.ID = ID;

			return View();
		}

		public ActionResult Answers(int ID)
		{
			return View();
		}  

		public ActionResult Questions(int ID)
		{
			return View();
		}
	}
}