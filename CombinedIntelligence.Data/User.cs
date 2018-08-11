using System;
using System.Collections.Generic;

namespace CombinedIntelligence.Data
{
	public class User
	{
		/*TEMP*/
		public static int IDCOUNTER = 0;

		public int Id { get; }
		public string Name { get; }
		public string Email { get; }
		public string Team { get; }
		public string Image { get; set; }
		public int Score { get; set; }
		public List<Tag> Tags { get; }

		public User()
		{
			Score = 0;
			Tags = new List<Tag>();
		}

		public User(string name, string email, string team, string image)
		{
			Name = name;
			Email = email;
			Team = team;
			Image = image;
			Score = 0;
			Tags = new List<Tag>();
		}

		public void UpdateImage(string image)
		{
			Image = image;
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

		public void IncrementScore()
		{
			Score += 1;
		}

		public void DecrementScore()
		{
			Score -= 1;
		}
	}
}
