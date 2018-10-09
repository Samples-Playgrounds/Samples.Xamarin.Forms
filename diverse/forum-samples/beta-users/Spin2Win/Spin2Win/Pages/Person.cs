using System;

namespace Spin2Win
{
	public enum PrizeType {
		Monkey,
		TShirt
	}

	public class Person
	{
		public string Name { get; set; }
		public string Email { get; set; }
		public string Company { get; set; }
		public bool CompletedAzureChallenge { get; set; }
		public PrizeType Prize { get; set; }
		public DateTime TimeStamp { get; set; }

		internal string FormatForWriting ()
		{
			var result = Name + "^" +
			             Email + "^" +
			             Company + "^" +
			             CompletedAzureChallenge + "^" +
			             Prize + "^" +
			             TimeStamp;
			return result;
		}
	}
}