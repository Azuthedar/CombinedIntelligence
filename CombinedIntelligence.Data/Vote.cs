using System;
using System.Collections.Generic;

namespace CombinedIntelligence.Data
{
    public class Vote
    {
        public VoteTypes vote = VoteTypes.NoVote;
        public int UserId { get; set; }
    }
}
