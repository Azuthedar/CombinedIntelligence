using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CombinedIntelligence.Data;

namespace Combined_Intelligence.Controllers
{
	public class UserController : Controller
	{

		User mockUser = new User("John", "John.Murray@gmail.com", "Actuaris", "IMAGE");
		// GET: User
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Profile(int ID)
		{
			mockUser.AddTag(new Tag("C++"));
			mockUser.AddTag(new Tag("C#"));
			mockUser.AddTag(new Tag("R"));
			mockUser.AddTag(new Tag(".NET"));
			mockUser.AddTag(new Tag("ASP.NET"));

			ViewBag.ID = mockUser.Id;
			ViewBag.userName = mockUser.Name;
			ViewBag.email = mockUser.Email;
			ViewBag.team = mockUser.Team;
			ViewBag.score = mockUser.Score;
			ViewBag.Preferences = mockUser.Tags;


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