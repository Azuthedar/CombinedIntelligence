using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using CombinedIntelligenceAPI.Models;
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
			mockUser = getUser(ID);
			//mockQuestions = CombinedIntelligenceAPI.Controllers.QuestionController
			ViewBag.User = mockUser;
			ViewBag.ID = mockUser.Id;
			ViewBag.userName = mockUser.Name;
			ViewBag.email = mockUser.Email;
			ViewBag.team = mockUser.Team;

			ViewBag.score = mockUser.Score;
			ViewBag.Preferences = mockUser.Tags;

			ViewBag.Questions = mockQuestions;
			ViewBag.Answers = mockAnswers;

			ViewBag.Rewards = mockRewards;

			return View();
		}

		public ActionResult Answers(int ID)
		{
			List<Answer> ansList = new List<Answer>();
			using (CombinedIntelligenceAPI.Models.CombinedIntelligenceEntities CI = new CombinedIntelligenceAPI.Models.CombinedIntelligenceEntities())
			{
				var result = CI.getUserAnswers(ID).ToList();
				foreach (var answer in result)
				{
					Answer cur = new Answer()
					{
						Id = answer.AnswerId,
						UserId = answer.UserId,
						BodyText = answer.Body,
						DatePosted = answer.DatePosted,
						Accepted = answer.Accepted == 1,
						QuestionId = answer.QuestionId
					};

					var votes = CI.getAVotes(answer.AnswerId).ToList();
					foreach (var vote in votes)
						cur.Votes.Add(new Vote(vote.UserId, (VoteTypes)vote.Value));
					ansList.Add(cur);

				}
				
			}
			return View();
		}  

		public ActionResult Questions(int ID)
		{
			List<Question> qList = new List<Question>();
			using (CombinedIntelligenceAPI.Models.CombinedIntelligenceEntities CI = new CombinedIntelligenceAPI.Models.CombinedIntelligenceEntities())
			{
				var result = CI.getUserQuestions(ID).ToList();
				foreach (var question in result)
				{
					Question cur = new Question()
					{
						Id = question.QuestionID,
						UserId = ID,
						BodyText = question.Body,
						DatePosted = question.DatePosted,
						HeaderText = question.Header
					};

					var votes = CI.getQVotes(question.QuestionID).ToList();
					foreach (var vote in votes)
						cur.Votes.Add(new Vote(vote.UserId, (VoteTypes)vote.Value));
					qList.Add(cur);

					var tags = CI.getQTags(question.QuestionID).ToList();
					foreach (var tag in tags)
						cur.AddTag(new Tag(tag.Name));

				}

			}
			return View();
		}

		public User getUser(int ID)
		{
			using (CombinedIntelligenceAPI.Models.CombinedIntelligenceEntities CI = new CombinedIntelligenceAPI.Models.CombinedIntelligenceEntities())
			{
				var result = CI.GetUser(ID).ToList().First();
				var user = new User()
				{
					
					Id = result.UserID,
					Email = result.Email,
					Team = result.Name,
					Score = result.Score,
					Name = result.FirstNames,
					//Surname = result.Surname,
					Image = result.Image
				};

				var tagList = CI.getUserTags(ID).ToList();
				foreach (var tag in tagList)
				{
					user.AddTag(new Tag(tag));
				}
				return user;
			}
			
		}

	}
}