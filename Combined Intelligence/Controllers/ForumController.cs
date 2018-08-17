using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CombinedIntelligence.Data;
using CombinedIntelligenceAPI.Controllers;

namespace Combined_Intelligence.Controllers
{
	public class ForumController : Controller
	{
		public List<Question> allQuestions;
		public ForumController()
		{
			//We need to get all the Question ID's as the forum will have a list of all of the questions
			List<Tag> mockTags = new List<Tag>();

			mockTags.Add(new Tag("A"));
			mockTags.Add(new Tag("B"));
			mockTags.Add(new Tag("C"));
			mockTags.Add(new Tag("D"));
			mockTags.Add(new Tag("E"));
			mockTags.Add(new Tag("F"));
			mockTags.Add(new Tag("G"));
			mockTags.Add(new Tag("H"));
			mockTags.Add(new Tag("I"));
			mockTags.Add(new Tag("J"));

			allQuestions = new List<Question>();

			DateTime date = System.DateTime.Now;

			for (int i = 0; i < 400; i++)
			{
				allQuestions.Add(new Question(i, "User: " + i + "\'s headerText", "User: " + i + "\'s bodyText", mockTags, date));
				allQuestions[i].Id = i;

			}
		}

		// GET: Forum
		public ActionResult Index(int ID)
		{
			ViewBag.User = DBCalls.getUser(ID);
			ViewBag.Questions = allQuestions;
			return View();
		}

		public ActionResult Filter(string sequence)
		{
			return View();
		}
	}
}