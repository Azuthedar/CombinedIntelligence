using System;
using System.Collections.Generic;

namespace CombinedIntelligence.Data
{
	public class Question : AUserResponse
	{
		public string HeaderText { get; set; }
		public List<Tag> Tags { get; }

		public int totalViews
		{
			get
			{
				return (Votes.Count);
			}
		}

		public Question(int userId, string headerText, string bodyText, List<Tag> tags, DateTime datePosted)
		{
			UserId = userId;
			HeaderText = headerText;
			BodyText = bodyText;
			Tags = tags;
			DatePosted = datePosted;

			Votes = new List<Vote>();
		}

		public void AddTag(Tag tag)
		{
			Boolean foundTag = false;

			//Loop through all tags and if it finds a tag with the same name it doesn't add the tag to the array
			//Could potentially be pretty slow because O(n) time
			Tags.ForEach(cTag =>
			{
				if (cTag.Name == tag.Name)
					foundTag = true;
			});

			if (!foundTag)
			{
				Tags.Add(tag);
			}
		}
	}
}
