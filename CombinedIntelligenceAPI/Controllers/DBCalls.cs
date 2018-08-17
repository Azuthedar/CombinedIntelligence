using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CombinedIntelligence.Data;


namespace CombinedIntelligenceAPI.Controllers
{
    public static class DBCalls
    {
        static Models.CombinedIntelligenceEntities CI;

        public static List<Question> GetQuestions(int UID)
        {
            List<Question> qList = new List<Question>();
            using (CI = new Models.CombinedIntelligenceEntities())
            {
                var result = CI.getUserQuestions(UID).ToList();
                foreach (var question in result)
                {
                    Question cur = new Question()
                    {
                        Id = question.QuestionID,
                        UserId = UID,
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
            return qList;
        }

        public static List<Answer> GetAnswers(int UID)
        {
            List<Answer> ansList = new List<Answer>();
            using (CI = new Models.CombinedIntelligenceEntities())
            {
                var result = CI.getUserAnswers(UID).ToList();
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
            return ansList;
        }

        public static User getUser(int ID)
        {
            using (CI = new Models.CombinedIntelligenceEntities())
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

        public static void acceptAnswer(int AnsId)
        {
            using (CI = new Models.CombinedIntelligenceEntities())
            {
                var result = CI.AcceptAns(AnsId);
            }
        }

        public static Answer addAnswer(Answer newAnswer)
        {
            using (CI = new Models.CombinedIntelligenceEntities())
            {
                var result = CI.AddAnswer(newAnswer.QuestionId, newAnswer.UserId, newAnswer.BodyText).ToList().First();
                newAnswer.DatePosted = result.DatePosted;
                newAnswer.Id = result.AnswerId;
                newAnswer.Accepted = false;
                return newAnswer;
            }
        }

        public static void addQTag(int QID, int TID)
        {
            using (CI = new Models.CombinedIntelligenceEntities())
            {
                CI.AddQTag(TID, QID);
            }
        }

        public static Question addQuestion(Question newQuestion)
        {
            using (CI = new Models.CombinedIntelligenceEntities())
            {
                var result = CI.AddQuestion(newQuestion.UserId, newQuestion.HeaderText, newQuestion.BodyText).ToList().First();
                newQuestion.DatePosted = result.DatePosted;
                newQuestion.Id = result.QuestionId;
                return newQuestion;
            }
        }

        public static Tag addTag(Tag newTag)
        {
            using (CI = new Models.CombinedIntelligenceEntities())
            {
                var result = CI.AddTag(newTag.Name).ToList().First(); ;
                if (result.HasValue)
                    newTag.id = result.Value;
                return newTag;
            }
        }

        public static void userPreference(int UID, int TID)
        {
            using (CI = new Models.CombinedIntelligenceEntities())
            {
                CI.AddUserPreference(TID, UID);
            }
        }

        /*public static List<Question> GetTagQuestions(int UID)
        {
            List<Question> qList = new List<Question>();
            using (CI = new Models.CombinedIntelligenceEntities())
            {
                var result = CI.GetQuestions().ToList().First();
                foreach (var question in result)
                {
                    Question cur = new Question()
                    {
                        Id = question.QuestionID,
                        UserId = UID,
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
            return qList;
        }*/

        /*public static List<Reward> getRewards()
        {
            using (CI = new Models.CombinedIntelligenceEntities())
            {
                var result = CI.
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
        }*/

    }
}