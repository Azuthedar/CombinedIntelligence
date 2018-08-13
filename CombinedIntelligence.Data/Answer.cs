using System;
using System.Collections.Generic;

namespace CombinedIntelligence.Data
{
	public class Answer : AUserResponse
	{
		public int QuestionId { get; set; }
		public bool Accepted { get; set; }

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
