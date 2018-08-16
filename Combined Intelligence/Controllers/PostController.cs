using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CombinedIntelligence.Data;

namespace Combined_Intelligence.Controllers
{
	public class PostController : Controller
	{
		Question question;
		List<Answer> questionAnswers;
		public PostController()
		{
			List<Tag> mockTags = new List<Tag>();

			mockTags.Add(new Tag("A"));
			mockTags.Add(new Tag("B"));
			question = new Question(1, "World of Warcraft, is BFA worth playing?", "So I've been on this mission for quite some time, some people say it's worth coming back........\n Data data data\n datadata So I've been on this mission for quite some time, some people say it's worth coming back........\n Data data data\n datadata So I've been on this mission for quite some time, some people say it's worth coming back........\n Data data data\n datadata So I've been on this mission for quite some time, some people say it's worth coming back........\n Data data data\n datadata So I've been on this mission for quite some time, some people say it's worth coming back........\n Data data data\n datadata", mockTags, System.DateTime.Now);

			questionAnswers = new List<Answer>();

			questionAnswers.Add(new Answer(question.Id, 2, "The answer is yes, it is worth coming back, the story is ever so rich and will become even richer", System.DateTime.Now));
			questionAnswers.Add(new Answer(question.Id, 3, "The answer is yes, it is worth coming back, the story is ever so rich and will become even richer", System.DateTime.Now));
			questionAnswers.Add(new Answer(question.Id, 4, "The answer is yes, it is worth coming back, the story is ever so rich and will become even richer", System.DateTime.Now));
			questionAnswers.Add(new Answer(question.Id, 5, "The answer is yes, it is worth coming back, the story is ever so rich and will become even richer", System.DateTime.Now));
			questionAnswers.Add(new Answer(question.Id, 6, "The answer is yes, it is worth coming back, the story is ever so rich and will become even richer\nThe answer is yes, it is worth coming back, the story is ever so rich and will become even richer\nThe answer is yes, it is worth coming back, the story is ever so rich and will become even richer\n The answer is yes, it is worth coming back, the story is ever so rich and will become even richer The answer is yes, it is worth coming back, the story is ever so rich and will become even richer", System.DateTime.Now));



		}

		// GET: UserPost
		//Question ID
		public ActionResult Post(int id)
		{
			ViewBag.Question = question;
			ViewBag.Answers = questionAnswers;

			//Person who asks the question
			ViewBag.Questionee = new User("Joe", "Whatevs", "SARS", "IMAGE");

			//Person(s) who answer questions
			ViewBag.Answerer = new User("Bob", "SomeOther", "SUMTINELSE", "IMAGE");

			return View();
		}
	}
}