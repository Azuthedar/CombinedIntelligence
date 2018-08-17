using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CombinedIntelligenceAPI.Controllers;
using CombinedIntelligence.Data;

namespace Combined_Intelligence.Controllers
{
	public class UserController : Controller
	{

        public static List<Reward> rewardList;

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
            mockUser = DBCalls.getUser(ID);
            mockQuestions = DBCalls.GetQuestions(ID);
            mockAnswers = DBCalls.GetAnswers(ID);
            //mockRewards = getRewards();
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
			ViewBag.User = DBCalls.getUser(ID);
            ViewBag.Answers = DBCalls.GetAnswers(ID);
            return View();
		}  

		public ActionResult Questions(int ID)
		{
			ViewBag.User = DBCalls.getUser(ID);
            ViewBag.Questions = DBCalls.GetQuestions(ID);
            return View();
		}
  

	}
}