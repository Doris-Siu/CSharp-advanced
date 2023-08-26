using System;
namespace CSharp_advanced
{
	public static class StringExtensions
	{
		// creating an extension method to String instance
		public static string Shorten(this String str, int numberOfWords)
		{
			if (numberOfWords <= 0)
				throw new ArgumentOutOfRangeException("the agrument should be greater than 0.");

			var words = str.Split(' ');

			if (words.Length <= numberOfWords)
				return str;

			return string.Join(' ', words.Take(numberOfWords)) + "...";

		}
		
	}
}

