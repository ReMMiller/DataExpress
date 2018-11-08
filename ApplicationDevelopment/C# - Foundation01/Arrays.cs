using System;

namespace IntroCore
{
	class Arrays
	{
		public static void Display()
		{
			// (1) - arrays
			int[] ints = new int[3];
			ints[0] = 23;

			Console.WriteLine("ints[0] = {0}", ints[0]);

			int[] intsA = new int[] { 4, 6, 12, 3 };
			int[] intsB = { 34, 7, 21, 64 };
			int[] intsC = new int[5];

			// initialize array
			string[] friends = { "Joseph", "Emily", "Gabe" };
			var students = new[] { "Jesse", "Alec", "Joel" };

			Console.WriteLine("Length: {0}", friends.Length);
			foreach(string friend in friends)
			{
				Console.WriteLine($"name: {friend}");
			}

			// (2) - base array
			object[] types = { "Neumont", 5, 34.5f };
			for (int i = 0; i < types.Length; i++)
			{
				Console.WriteLine("{0} : {1}", types[i], types[i].GetType());
			}

			// (3) - multi-dimensional array
			string[,] multi = new string[2, 2] { { "A", "B" }, { "C", "D" } };
			Console.WriteLine("2D Array Value: {0}", multi[1,1]);

			for (int i = 0; i < multi.GetLength(0); i++)
			{
				for (int j = 0; j < multi.GetLength(1); j++)
				{
					Console.Write("{0} ", multi[i, j]);
				}
				Console.WriteLine();
			}
			
			// (4) - array manipulation (sort, reverse)
			int[] numbers = { 1, 6, 3, 7, 5 };

			Array.Sort(numbers);
			PrintArray(numbers, "Sort");
			Array.Reverse(numbers);
			PrintArray(numbers, "Reverse");

			// set value
			numbers.SetValue(100, 0);
			PrintArray(numbers, "Set Value");

			// (5) - copy
			int[] source = { 1, 2, 3 };
			int[] destination = new int[10];

			Array.Copy(source, 0, destination, 0, 2);
			PrintArray(destination, "Copy");
			source.CopyTo(destination, 3);
			PrintArray(destination, "CopyTo");
					   
			// (5) - find (returns -1 if not found)
			Console.WriteLine("Index of 5: {0}", Array.IndexOf(numbers, 5));

			// (6) - find using predicate
			int[] numbersB = { 3, 15, 4, 0, 9 };
			Console.WriteLine("> 5: {0}", Array.FindAll(numbersB, GreaterThan));
		}

		static void PrintArray(int[] array, string message = "")
		{
			Console.WriteLine(message);
			foreach (int v in array)
			{
				Console.Write("{0} ", v);
			}
			Console.WriteLine("");
		}

		static bool GreaterThan(int value)
		{
			return value > 5;
		}
	}
}
