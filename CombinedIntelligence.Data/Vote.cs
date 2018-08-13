using System;
using System.Collections.Generic;

namespace CombinedIntelligence.Data
{
	public class Vote
	{
		public VoteTypes vote = VoteTypes.NoVote;
		public int UserId { get; set; }

		public Vote(int userId, VoteTypes voteVal)
		{
			UserId = userId;
			vote = voteVal;
		}
	}
}
