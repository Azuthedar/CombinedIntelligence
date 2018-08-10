using System;
using System.Collections.Generic;

namespace CombinedIntelligence.Data
{
    public class User
    {
        public int Id;
        public string Name;
        public string Email;
        public string Team;
        public int score;
        public List<Tag> Tag;
    }
}
