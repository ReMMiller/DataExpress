using System;
using System.Collections.Generic;
using System.Text;

namespace IntroCore
{
	class Nullable
	{
		public static void Display()
		{
			// (1) - nullable type (when dealing with databases we may need to decare a null type)
			int? number = null;

			Console.WriteLine($"nullable type: {number}");
			if (number == null)
			{
				Console.WriteLine("number is null");
			}

			if (!number.HasValue)
			{
				Console.WriteLine("number is null");
			}

			// (2) - ?? operator
			int finalNumber = number ?? 100;
			Console.WriteLine($"finalNumber: {finalNumber}");

			// ?? equivalent to this
			if (number == null)
			{
				finalNumber = 100;
			}
		}
	}
}
