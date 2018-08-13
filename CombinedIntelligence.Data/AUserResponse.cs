using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinedIntelligence.Data
{
	public class AUserResponse
	{
		public virtual int Id { get; set; }
		public virtual int UserId { get; set; }
		public virtual string BodyText { get; set; }
		public virtual DateTime DatePosted { get; set; }
		public virtual List<Vote> Votes { get; set; }

		public virtual int VoteScore
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

		public virtual void UpdateVote(Vote vote)
		{
			Boolean foundVote = false;

			Votes.ForEach(cVote =>
			{
				if (cVote.UserId == vote.UserId)
				{
					cVote = vote;
					foundVote = true;
				}
			});
			if (!foundVote)
			{
				Votes.Add(vote);
			}

		}
	}
}
