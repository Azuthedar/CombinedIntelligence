using System;
using System.Collections.Generic;

namespace CombinedIntelligence.Data
{
	public class Answer : AUserResponse
	{
		//public int Id { get; set; }
		//public int UserId { get; set; }
		public int QuestionId { get; set; }
		public bool Accepted { get; set; }

		/*public int VoteScore
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
		}*/

		public Answer()
		{
			Votes = new List<Vote>();
		}

		public Answer(int questionId, int userId, string bodyText, DateTime datePosted)
		{

			QuestionId = questionId;
			UserId = userId;
			BodyText = bodyText;
			DatePosted = datePosted;

			Votes = new List<Vote>();
		}
	}
}
