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
			List<String> tagPreferences = new List<String>();
			tagPreferences.Add("Hello");
			tagPreferences.Add("World");
			tagPreferences.Add("Hello");
			tagPreferences.Add("World");
			tagPreferences.Add("Hello");
			tagPreferences.Add("World");
			tagPreferences.Add("Hello");
			tagPreferences.Add("World");
			tagPreferences.Add("Hello");
			tagPreferences.Add("World");
			tagPreferences.Add("Hello");
			tagPreferences.Add("World");

			ViewBag.ID = ID;
			ViewBag.userName = "John";
			ViewBag.email = "John@gmail.com";
			ViewBag.team = "Actuaris";
			ViewBag.score = 50;
			ViewBag.Preferences = tagPreferences;


			List<String> questions = new List<string>();
			questions.Add("What is the meaning of life?");
			questions.Add("This is the true meaning of Life");
			questions.Add("What is 2 + 2");
			questions.Add("What is a reallllllllllllllllllllllllly long questionnnnnnnnnnnnnnnnn TITLE");
			questions.Add("What is the meaning of life?");
			questions.Add("This is the true meaning of Life");
			questions.Add("What is 2 + 2");
			questions.Add("What is the meaning of life?");
			questions.Add("This is the true meaning of Life");
			questions.Add("What is 2 + 2");


			List<String> answers = new List<string>();
			answers.Add("42 is the meaning of life");
			answers.Add("2 + 2 is four - 1 is 3 quick mafs, which ultimately means that your question is in valid and you have never passed school");
			answers.Add("some answer");
			answers.Add("some answer");
			answers.Add("some answer");
			answers.Add("some answer");
			answers.Add("some answer");
			answers.Add("some answer");

			ViewBag.Questions = questions;
			ViewBag.Answers = answers;

			List<String> rewards = new List<string>();
			rewards.Add("PS4");
			rewards.Add("Free Lunch for a week");
			rewards.Add("A watch");

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