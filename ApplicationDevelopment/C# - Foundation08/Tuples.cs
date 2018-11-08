using System;
using System.Collections.Generic;
using System.Text;

namespace IntroCore
{
	/// <summary>
	/// Tuples enable you to package multiple values in one single object more easily.
	/// Tuples are values types  with mutable (read/write) elements. This allows you to
	/// modify the elements of the tuple.
	/// </summary>
	class Tuples
	{
		public static void Display()
		{
			// An anonymous type can package multiple values in one object
			var person1 = new { Name = "Reanna", Age = 19 };
			Console.WriteLine("Anonymous Type: " + person1);

			// A tuple can package multiple values in one object
			// This creates a tuple with unnamed elements
			var person2 = ("Yoanny", 123);
			Console.WriteLine("Tuple: " + person2);
			Console.WriteLine("Tuple Item1: " + person2.Item1);
			Console.WriteLine("Tuple Item2: " + person2.Item2);
			// Tuple values can be reassigned
			Console.WriteLine("Tuple reassignment");
			person2.Item1 = "Gage";
			person2.Item2 = 789;
			Console.WriteLine("Tuple Item1: " + person2.Item1);
			Console.WriteLine("Tuple Item2: " + person2.Item2);

			// This creates a tuple with named elements
			var person3 = (name: "Jason", id: 13);
			Console.WriteLine("Tuple name: " + person3.name);
			Console.WriteLine("Tuple id: " + person3.id);
		
			// Unlike anonymous types, var is optional
			// You can specify the tuple types explicitly
			(int, int) values = GetValues("34", "54");
			Console.WriteLine("Tuple return values: " + values.Item1 + " " + values.Item2);

			// Deconstructing tuples allow for easy conversion from tuple elements to
			// individual variables
			var car = (name: "Toyota", year: 2018, speed: 120.0f);
			string _name = car.name;
			int _year = car.year;
			float _speed = car.speed;

			(string name, int year, float speed) = car;
			Console.WriteLine($"Deconstruction: {name} {year} {speed}");
		}

		/// <summary>
		/// The main purpose of tuples is to safely return multiple values from a method.
		/// </summary>
		/// <returns>Tuple value</returns>
		static (int, int) GetValues(string sv1, string sv2)
		{
			int v1 = int.Parse(sv1);
			int v2 = int.Parse(sv2);

			return (v1, v2);
		}
	}
}
