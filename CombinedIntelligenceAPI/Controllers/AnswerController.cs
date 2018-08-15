using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CombinedIntelligence.Data;

namespace CombinedIntelligenceAPI.Controllers
{
    public class AnswerController : ApiController
    {
        // GET api/values
        public IEnumerable<string> GetAnswer()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string GetAnswer(int id)
        {
            return "value";
        }

        // POST api/values
        public void PostAnswer([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void PutAnswer(int id, [FromBody]string value)
        {

        }

        // DELETE api/values/5
        public void DeleteAnswer(int id)
        {
        }

        public List<Answer> getAnswers(int QID)
        {
            List<Answer> ansList = new List<Answer>();
            using (Models.CombinedIntelligenceEntities CI = new Models.CombinedIntelligenceEntities())
            {
                var result = CI.GetAnswers(QID).ToList();
                foreach (var answer in result)
                {
                    Answer cur = new Answer()
                    {
                        Id = answer.AnswerID,
                        UserId = answer.UserId,
                        BodyText = answer.Body,
                        DatePosted = answer.DatePosted,
                        Accepted = answer.Accepted == 1, 
                        QuestionId = QID
                    };

                    var votes = CI.getAVotes(answer.AnswerID).ToList();
                    foreach (var vote in votes)
                        cur.Votes.Add(new Vote(vote.UserId, (VoteTypes)vote.Value));
                    ansList.Add(cur);

                }
                return ansList;
            }

        }

    }
}
