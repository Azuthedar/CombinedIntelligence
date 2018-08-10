using System;
using System.Collections.Generic;
using System.Text;

namespace CombinedIntelligence.Data
{
    public class Tag
    {
        public string Name;
        public static List<Tag> Tags;

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
