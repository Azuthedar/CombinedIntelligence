using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Combined_Intelligence
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
				name: "Profiles",
				url: "Profiles/{id}",
				defaults: new { controller = "User", action = "Profile" }
			);

			routes.MapRoute(
				name: "ProfileAnswers",
				url: "Profiles/{id}/Answers",
				defaults: new { controller = "User", action = "Answers" }
			);

			routes.MapRoute(
				name: "ProfileQuestions",
				url: "Profiles/{id}/Questions",
				defaults: new { controller = "User", action = "Questions" }
			);

			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
			);

		}
	}
}
