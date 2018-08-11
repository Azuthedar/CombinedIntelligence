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
		public int score { get; set; }
		public List<Tag> Tags { get; }

		public User()
		{
			Tags = new List<Tag>();
		}
	}
}
