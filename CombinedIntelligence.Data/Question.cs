using System;
using System.Collections.Generic;

namespace CombinedIntelligence.Data
{
    public class Question
    {
        public int Id;
        public int UserId;
        public string HeaderText;
        public string BodyText;
        public List<Tag> Tags;
        public DateTime DatePosted;
        public List<Vote> Votes;
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
    }
}
