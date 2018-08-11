using System;
using System.Collections.Generic;

namespace CombinedIntelligence.Data
{
	public class Question
	{
		public int Id { get; }
		public int UserId { get; set; }
		public string HeaderText { get; set; }
		public string BodyText { get; set; }
		public List<Tag> Tags { get; }
		public DateTime DatePosted { get; set; }
		public List<Vote> Votes { get; }

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

		public Question()
		{
			Votes = new List<Vote>();
			Tags = new List<Tag>();
		}

		public void addVote(Vote vote)
		{
			Votes.Add(vote);
		}
	}

}
