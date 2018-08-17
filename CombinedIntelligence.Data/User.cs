using System;
using System.Collections.Generic;

namespace CombinedIntelligence.Data
{
	public class User
	{
		/*TEMP*/
		public static int IDCOUNTER = 0;

		public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Team { get; set; }
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
			int i = Tags.BinarySearch(tag);
			if (i < 0)
				Tags.Add(tag);
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
