using System;
using System.Collections.Generic;
using System.Text;

namespace CombinedIntelligence.Data
{
	public class Tag: IComparable<Tag>
	{
        public int id { get; set; }
		public string Name { get; set; }
		public static List<Tag> Tags = new List<Tag>();//Quick q, why does a tag have a list of tags? I've not catered for this in DB, let me know if I should

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

        public int CompareTo(Tag other)
        {
            return string.Compare(Name, other.Name);
        }
    }
}
