using System;
using System.Collections.Generic;
using System.Text;

namespace IntroCore
{
	class Methods
	{
		public static void Display()
		{
			// (1) - pass by value
			int i1 = 10;
			int i2 = 20;
			int result = Add(i1, i2);
			Console.WriteLine($"{i1} + {i2} = {result}");

			// (2) - out parameter modifier
			int outResult;
			Add(i1, i2, out outResult);
			Console.WriteLine($"out: {i1} + {i2} = {outResult}");

			bool bResult;
			string outstr;
			SetOutParameters(out outstr, out bResult);
			Console.WriteLine($"result: {bResult} outstr: {outstr}");

			// (3) - ref parameter modifier
			Console.WriteLine($"Pre Swap: {i1} - {i2}");
			Swap(ref i1, ref i2);
			Console.WriteLine($"Post Swap: {i1} - {i2}");

			// (4) - parameter arrays
			double average;
			average = CalculateAverage(3.4, 5.4, 12.3, 1.4);
			Console.WriteLine($"params: {average}");
			double[] values = { 7.6, 83.2, 19.3, 0.25 };
			average = CalculateAverage(values);
			Console.WriteLine($"params: {average}");
			average = CalculateAverage();
			Console.WriteLine($"params: {average}");

			// (5) - optional parameters
			NetflixUser("Austin");
			NetflixUser("Charles", 2);
			NetflixUser("Dennis", 4, false);

			// (6) - named parameters
			NetflixUser(name: "Fernando", years: 1);
			NetflixUser(premium: false, name: "Alex");

			// (7) - method overloading
			Console.WriteLine($"Add(int, int): {Add(45, 60)}");
			Console.WriteLine($"Add(double, double): {Add(4.3, 18.2)}");

			// (8) - array parameter
			string[] kidsMovies = { "Requiem for a Dream", "Mandy", "Hereditary" };
			PrintStrings(kidsMovies);

			// (9) - array return type
			string[] matureMovies = GetStrings();
			foreach (string movieName in matureMovies)
			{
				Console.WriteLine(movieName);
			}
		}

		// pass by value
		public static int Add(int i1, int i2)
		{
			int result = i1 + i2;
			i1 = 20;
			i2 = 30;
			
			return result;
		}

		public static double Add(double d1, double d2)
		{
			return d1 + d2;
		}

		// out parameter
		public static void Add(int i1, int i2, out int result)
		{
			result = i1 + i2;
		}
				
		public static void SetOutParameters(out string str, out bool result)
		{
			str = "the string that was set.";
			result = true;
		}

		// ref parameter
		public static void Swap(ref int v1, ref int v2)
		{
			int temp = v1;
			v1 = v2;
			v2 = temp;
		}

		// params
		public static double CalculateAverage(params double[] values)
		{
			double sum = 0.0f;
			
			for (int i = 0; i < values.Length; i++)
			{
				sum += values[i];
			}
			double average = (values.Length == 0) ? 0.0f : sum / values.Length;

			return average;
		}

		// optional parameters
		public static void NetflixUser(string name, int years = 3, bool premium = true)
		{
			Console.WriteLine($"Netflix User: {name} - Years: {years} - Premium: {premium}");
		}

		public static void PrintStrings(string[] strings)
		{
			foreach (string s in strings)
			{
				Console.WriteLine(s);
			}
		}

		// array return type
		public static string[] GetStrings()
		{
			string[] strings = { "Snow Dogs", "Barney", "Pound Puppies" };
			return strings;
		}

	}
}
