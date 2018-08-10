using System;
using System.Collections.Generic;

namespace CombinedIntelligence.Data
{
    public class Answer
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int QuestionId { get; set; }
        public string BodyText { get; set; }
        public DateTime DatePosted { get; set; }
        public List<Vote> Votes { get; set; }
        public bool Accepted { get; set; }

        public int VoteScore
        {
            get
            {
                int voteScore = 0;
                foreach (Vote vote in Votes)
                {
                    voteScore += (int)vote.vote;
                }

                return voteScore;
            }
        }

        public Answer()
        {
            Votes = new List<Vote>();
        }
    }
}
