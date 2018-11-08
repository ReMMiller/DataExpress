using System;
using System.Collections.Generic;
using System.Text;
using System.Linq; // include to enable LINQ

namespace IntroCore
{
	/// <summary>
	/// Language-Integrated Query (LINQ) is the name for a set of technologies 
	/// based on the integration of query capabilities directly into the C# language. 
	/// LINQ is similar to SQL, but it can work with data aside from databases.
	/// You manipulate data using Query Expressions.
	/// </summary>
	class Linq
	{
		static public void Display()
		{
			// Query String Array
			string[] dogs = {"K 9", "Brian Griffin",
			"Scooby Doo", "Old Yeller", "Rin Tin Tin",
			"Benji", "Charlie B. Barkin", "Lassie",
			"Snoopy"};

			var dogSpaces = from dog in dogs
							where dog.Contains(" ")
							orderby dog descending
							select dog;

			foreach (var i in dogSpaces)
			{
				Console.WriteLine(i);
			}

			// Query Int Array
			int[] nums = { 5, 10, 15, 20, 25, 30, 35 };

			// Get numbers bigger then 20
			var largeNums = from num in nums
					   where num > 20
					   orderby num
					   select num;

			foreach (var num in largeNums)
			{
				Console.WriteLine(num);
			}

			// Query List
			var animalList = new List<Animal>()
			{
				new Animal{Name = "German Shepherd",
				Height = 25,
				Weight = 77},
				new Animal{Name = "Chihuahua",
				Height = 7,
				Weight = 4.4},
				new Animal{Name = "Saint Bernard",
				Height = 30,
				Weight = 200}
			};

			var bigDogs = from dog in animalList
						  where (dog.Weight > 70) && (dog.Height > 25)
						  orderby dog.Name
						  select dog;

			foreach (var dog in bigDogs)
			{
				Console.WriteLine("A {0} weighs {1}lbs", dog.Name, dog.Weight);
			}
		}

		class Animal
		{
			public string Name { get; set; }
			public double Weight { get; set; }
			public double Height { get; set; }

			public Animal(string name = "No Name",
				double weight = 0,
				double height = 0)
			{
				Name = name;
				Weight = weight;
				Height = height;
			}

			public override string ToString()
			{
				return string.Format("{0} weighs {1}lbs and is {2} inches tall",
					Name, Weight, Height);
			}
		}
	}
}
