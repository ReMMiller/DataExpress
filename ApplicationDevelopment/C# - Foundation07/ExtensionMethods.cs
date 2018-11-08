using System;
using System.Collections.Generic;
using System.Text;

namespace IntroCore
{
	/// <summary>
	/// Extension methods enable you to "add" methods to existing types without 
	/// creating a new derived type, recompiling, or otherwise modifying 
	/// the original type. 
	/// </summary>
	class ExtensionMethods
	{
		public static void Display()
		{
			// (1) - Extension Methods
			int i = 8;

			Console.WriteLine("int value: " + i);
			Console.WriteLine("Extension Max (10): " + i.Max(10));
			Console.WriteLine("Extension Max (8): " + i.Max(5));

			Console.WriteLine("Extension Sqr: " + i.Sqr());

			Console.WriteLine("Is Greater Than (5): " + i.IsGreaterThan(5));

			string numString = "43.5";
			Console.WriteLine("Is numeric: " + numString.IsNumeric());

			// (2) - Anonymous Types
			// An anonymous type  is a simple class created on the fly to store
			// a set of values. It is read-only.
			var person1 = new { Name = "Reanna", Age = 19 };
			// cannot assign to anonymous types
			// person1.Name = "Terence";
			Console.WriteLine("Anonymous Type: " + person1);

			int id = 435;
			var person2 = new { Name = "Iaro", id };
			// equivalent to 
			// var person2 = new { Name = "Iaro", id = id };
			Console.WriteLine("Anonymous Type: " + person2);
		}
	}

	static class IntExtensions
	{
		/// <summary>
		/// Extension methods have the keyword 'this' proceeding the type that
		/// is going to be operated on.
		/// </summary>
		public static int Sqr(this int i)
		{
			return (i * i);
		}

		public static int Max(this int i, int max)
		{
			return (i > max) ? max : i;
		}

		public static int Min(this int i, int min)
		{
			return (i < min) ? min : i;
		}

		public static bool IsGreaterThan(this int i, int value)
		{
			return i > value;
		}

		public static bool IsEven(this int i)
		{
			return ((i % 2) == 0);
		}
	}

	static class StringExtensions
	{
		/// <summary>
		/// Extension methods have the keyword 'this' proceeding the type that
		/// is going to be operated on.
		/// </summary>
		public static bool IsNumeric(this string str)
		{
			double output;
			return double.TryParse(str, out output);
		}
	}
}
