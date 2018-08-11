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
			Tags = new List<Tag>();
			Score = 0;
		}

		public User(String name, String email, String team)
		{
			Name = name;
			Email = email;
			Team = team;
			Tags = new List<Tag>();
			Score = 0;
		}

		public void AddTag(Tag tag)
		{
			Tags.ForEach(cTag =>
			{
				if (cTag.GetHashCode() == tag.GetHashCode())
				{
					tag.AddTag(tag);
				}
			});
		}

		public override int GetHashCode()
		{
			int result = 17;

			result += 31 * result + Id;
			result += 31 * result + Name.Length;
			result += 31 * result + Email.Length;
			result += 31 * result + Image.Length;

			return result;
		}

		public void updateImage(string image)
		{
			Image = image;
		}

		public void incrementScore()
		{
			Score += 1;
		}

		public void decrementScore()
		{
			Score -= 1;
		}
	}
}
