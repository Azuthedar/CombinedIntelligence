using System;
using System.Collections.Generic;
using System.Text;

namespace CombinedIntelligence.Data
{
	public class Tag
	{
		public string Name { get; set; }
		public static List<Tag> Tags = new List<Tag>();

		public Tag(string name)
		{
			Name = name;
		}

		public void AddTag(Tag tag)
		{
			foreach (Tag t in Tags)
			{
				if (t.Name == tag.Name)
				{
					return;
				}
			}
			Tags.Add(tag);
		}
	}
}
