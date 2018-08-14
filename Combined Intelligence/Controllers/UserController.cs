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
		#region MockInfo
		User mockUser = new User("John", "John.Murray@gmail.com", "Actuaris", "IMAGE");
		List<Question> mockQuestions;
		List<Answer> mockAnswers;
		List<Reward> mockRewards;

		public UserController()
		{
			Tag.Tags.Add(new Tag("A"));
			Tag.Tags.Add(new Tag("B"));
			Tag.Tags.Add(new Tag("C"));
			Tag.Tags.Add(new Tag("D"));
			Tag.Tags.Add(new Tag("E"));
			Tag.Tags.Add(new Tag("F"));
			Tag.Tags.Add(new Tag("G"));
			Tag.Tags.Add(new Tag("H"));
			Tag.Tags.Add(new Tag("I"));
			Tag.Tags.Add(new Tag("J"));
			Tag.Tags.Add(new Tag("K"));
			Tag.Tags.Add(new Tag("L"));
			Tag.Tags.Add(new Tag("M"));
			Tag.Tags.Add(new Tag("N"));
			Tag.Tags.Add(new Tag("O"));
			Tag.Tags.Add(new Tag("P"));
			Tag.Tags.Add(new Tag("Q"));
			Tag.Tags.Add(new Tag("R"));
			Tag.Tags.Add(new Tag("S"));
			Tag.Tags.Add(new Tag("T"));
			Tag.Tags.Add(new Tag("U"));
			Tag.Tags.Add(new Tag("V"));
			Tag.Tags.Add(new Tag("W"));
			Tag.Tags.Add(new Tag("X"));
			Tag.Tags.Add(new Tag("Y"));
			Tag.Tags.Add(new Tag("Z"));


			mockUser.AddTag(new Tag("C++"));
			mockUser.AddTag(new Tag("C#"));
			mockUser.AddTag(new Tag("R"));
			mockUser.AddTag(new Tag(".NET"));
			mockUser.AddTag(new Tag("ASP.NET"));

			mockQuestions = new List<Question>();

			List<Tag> mockTags = new List<Tag>();

			mockTags.Add(new Tag("C#"));
			mockTags.Add(new Tag("C++"));
			mockTags.Add(new Tag("ASP.NET"));

			DateTime date = System.DateTime.Now;

			mockQuestions.Add(new Question(mockUser.Id, "What is the true meaning of Life?", "LoremIpsumExplanation", mockTags, date));
			mockQuestions.Add(new Question(mockUser.Id, "What is 2 + 2", "LoremIpsumExplanation", mockTags, date));
			mockQuestions.Add(new Question(mockUser.Id, "What is mathematics", "LoremIpsumExplanation", mockTags, date));
			mockQuestions.Add(new Question(mockUser.Id, "Templates", "LoremIpsumExplanation", mockTags, date));
			mockQuestions.Add(new Question(mockUser.Id, "What is the true meaning of Life?", "LoremIpsumExplanation", mockTags, date));
			mockQuestions.Add(new Question(mockUser.Id, "What is 2 + 2", "LoremIpsumExplanation", mockTags, date));
			mockQuestions.Add(new Question(mockUser.Id, "What is mathematics", "LoremIpsumExplanation", mockTags, date));
			mockQuestions.Add(new Question(mockUser.Id, "Templates", "LoremIpsumExplanation", mockTags, date));
			mockQuestions.Add(new Question(mockUser.Id, "What is the true meaning of Life?", "LoremIpsumExplanation", mockTags, date));
			mockQuestions.Add(new Question(mockUser.Id, "What is 2 + 2", "LoremIpsumExplanation", mockTags, date));
			mockQuestions.Add(new Question(mockUser.Id, "What is mathematics", "LoremIpsumExplanation", mockTags, date));
			mockQuestions.Add(new Question(mockUser.Id, "Templates", "LoremIpsumExplanation", mockTags, date));
			mockQuestions.Add(new Question(mockUser.Id, "What is the true meaning of Life?", "LoremIpsumExplanation", mockTags, date));
			mockQuestions.Add(new Question(mockUser.Id, "What is 2 + 2", "LoremIpsumExplanation", mockTags, date));
			mockQuestions.Add(new Question(mockUser.Id, "What is mathematics", "LoremIpsumExplanation", mockTags, date));
			mockQuestions.Add(new Question(mockUser.Id, "Templates", "LoremIpsumExplanation", mockTags, date));
			mockQuestions.Add(new Question(mockUser.Id, "What is the true meaning of Life?", "LoremIpsumExplanation", mockTags, date));
			mockQuestions.Add(new Question(mockUser.Id, "What is 2 + 2", "LoremIpsumExplanation", mockTags, date));
			mockQuestions.Add(new Question(mockUser.Id, "What is mathematics", "LoremIpsumExplanation", mockTags, date));
			mockQuestions.Add(new Question(mockUser.Id, "Templates", "LoremIpsumExplanation", mockTags, date));
			mockQuestions.Add(new Question(mockUser.Id, "What is the true meaning of Life?", "LoremIpsumExplanation", mockTags, date));
			mockQuestions.Add(new Question(mockUser.Id, "What is 2 + 2", "LoremIpsumExplanation", mockTags, date));
			mockQuestions.Add(new Question(mockUser.Id, "What is mathematics", "LoremIpsumExplanation", mockTags, date));
			mockQuestions.Add(new Question(mockUser.Id, "Templates", "LoremIpsumExplanation", mockTags, date));
			mockQuestions.Add(new Question(mockUser.Id, "What is the true meaning of Life?", "LoremIpsumExplanation", mockTags, date));
			mockQuestions.Add(new Question(mockUser.Id, "What is 2 + 2", "LoremIpsumExplanation", mockTags, date));
			mockQuestions.Add(new Question(mockUser.Id, "What is mathematics", "LoremIpsumExplanation", mockTags, date));
			mockQuestions.Add(new Question(mockUser.Id, "Templates", "LoremIpsumExplanation", mockTags, date));
			mockQuestions.Add(new Question(mockUser.Id, "What is the true meaning of Life?", "LoremIpsumExplanation", mockTags, date));
			mockQuestions.Add(new Question(mockUser.Id, "What is 2 + 2", "LoremIpsumExplanation", mockTags, date));
			mockQuestions.Add(new Question(mockUser.Id, "What is mathematics", "LoremIpsumExplanation", mockTags, date));
			mockQuestions.Add(new Question(mockUser.Id, "Templates", "LoremIpsumExplanation", mockTags, date));
			mockQuestions.Add(new Question(mockUser.Id, "What is the true meaning of Life?", "LoremIpsumExplanation", mockTags, date));
			mockQuestions.Add(new Question(mockUser.Id, "What is 2 + 2", "LoremIpsumExplanation", mockTags, date));
			mockQuestions.Add(new Question(mockUser.Id, "What is mathematics", "LoremIpsumExplanation", mockTags, date));
			mockQuestions.Add(new Question(mockUser.Id, "Templates", "LoremIpsumExplanation", mockTags, date));

			Random amountOfViewers = new Random();

			mockQuestions.ForEach(question =>
			{
				int people = amountOfViewers.Next(500, 4000);
				Random newVoteType = new Random();
				for (int userId = 0; userId < people; userId++)
				{
					int val = newVoteType.Next(-1, 2);
					question.UpdateVote(new Vote(userId, (VoteTypes)val));

				}
			});



			mockAnswers = new List<Answer>();

			mockAnswers.Add(new Answer(1, mockUser.Id, "LoremIpsumAnswerLoremIpsum Answer LoremIpsum AnswerL o r e m I p s u m AnswerLoremIpsumAnswerLoremIpsumAnswerLoremIpsumAnswerLoremIpsumAnswerLoremIpsumAnswerLoremIpsumAnswerLoremIpsumAnswer LoremIpsumAnswerLoremIpsumAnswerLoremIpsumAnswerLoremIpsumAnswerLoremIpsumAnswerLoremIpsumAnswerLoremIpsumAnswer", date));
			mockAnswers.Add(new Answer(1, mockUser.Id, "LoremIpsumAnswer", date));
			mockAnswers.Add(new Answer(1, mockUser.Id, "LoremIpsumAnswer", date));
			mockAnswers.Add(new Answer(1, mockUser.Id, "LoremIpsumAnswer", date));
			mockAnswers.Add(new Answer(1, mockUser.Id, "LoremIpsumAnswer", date));
			mockAnswers.Add(new Answer(1, mockUser.Id, "LoremIpsumAnswer", date));
			mockAnswers.Add(new Answer(1, mockUser.Id, "LoremIpsumAnswer", date));
			mockAnswers.Add(new Answer(1, mockUser.Id, "LoremIpsumAnswer", date));
			mockAnswers.Add(new Answer(1, mockUser.Id, "LoremIpsumAnswer", date));
			mockAnswers.Add(new Answer(1, mockUser.Id, "LoremIpsumAnswer", date));
			mockAnswers.Add(new Answer(1, mockUser.Id, "LoremIpsumAnswer", date));
			mockAnswers.Add(new Answer(1, mockUser.Id, "LoremIpsumAnswer", date));
			mockAnswers.Add(new Answer(1, mockUser.Id, "LoremIpsumAnswer", date));
			mockAnswers.Add(new Answer(1, mockUser.Id, "LoremIpsumAnswer", date));
			mockAnswers.Add(new Answer(1, mockUser.Id, "LoremIpsumAnswer", date));
			mockAnswers.Add(new Answer(1, mockUser.Id, "LoremIpsumAnswer", date));
			mockAnswers.Add(new Answer(1, mockUser.Id, "LoremIpsumAnswer", date));

			mockAnswers.ForEach(answer =>
			{
				int people = amountOfViewers.Next(500, 1000);
				Random newVoteType = new Random();
				for (int userId = 0; userId < people; userId++)
				{
					int val = newVoteType.Next(-1, 2);
					answer.UpdateVote(new Vote(userId, (VoteTypes)val));
				}
			});
			mockAnswers[0].Accepted = true;
			
			mockRewards = new List<Reward>();

			mockRewards.Add(new Reward("PS4", 500));
			mockRewards.Add(new Reward("Free Lunch for a Week", 10));
			mockRewards.Add(new Reward("Some Reward", 99999));
			mockRewards.Add(new Reward("The Speaker", 100000));
			mockRewards.Add(new Reward("The Watcher", 500000));
			mockRewards.Add(new Reward("Smartwatch", 250));

		}

		#endregion
		// GET: User
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Profile(int ID)
		{
			ViewBag.User = mockUser;

			ViewBag.Questions = mockQuestions;
			ViewBag.Answers = mockAnswers;

			ViewBag.Rewards = mockRewards;

			return View();
		}
		public ActionResult Answers(int ID)
		{

			ViewBag.User = mockUser;
			ViewBag.Answers = mockAnswers;
			return View();
		}  

		public ActionResult Questions(int ID)
		{
			ViewBag.User = mockUser;
			ViewBag.Questions = mockQuestions;
			return View();
		}
	}
}