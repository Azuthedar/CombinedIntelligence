using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinedIntelligence.Data
{
	public class Reward
	{
		public string BodyText { get; set; }
		public float Cost { get; set; }

		public Reward(string bodyText, float cost)
		{
			BodyText = bodyText;
			Cost = cost;
		}
	}
}
