using System;
using System.Collections.Generic;

namespace CombinedIntelligence.Data
{
    public class Forum
    {
        public User User { get; set; }

        public List<Question> Questions { get; }

        public Forum()
        {
            Questions = new List<Question>();
        }
        //userinfo 
        //questions

        //onload gimme a user
    }
}
