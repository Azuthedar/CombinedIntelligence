using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Combined_Intelligence.Controllers
{
	public class ForumController : Controller
	{
		// GET: Forum
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Filter(string sequence)
		{
			return View();
		}
	}
}