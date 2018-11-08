using System;
using System.Collections; // include to use IEnumerable
using System.Collections.Generic;
using System.Text;

namespace IntroCore
{
	/// <summary>
	/// IEnumerable allow a class to be iterated over in a foreach loop.
	/// </summary>
	class Enumerable
	{
		public static void Display()
		{
			AnimalFarm animals = new AnimalFarm();
			
			animals[0] = new Animal("Milo");
			animals[1] = new Animal("Otis");
			animals[2] = new Animal("Charlie");
			animals[3] = new Animal("Ed");

			foreach (Animal animal in animals)
			{
				Console.WriteLine(animal.Name);
			}
		}

		class Animal
		{
			public string Name { get; set; }
			public Animal(string name = "No Name")
			{
				Name = name;
			}
		}

		class AnimalFarm : IEnumerable
		{
			private List<Animal> animalList = new List<Animal>();

			public AnimalFarm(List<Animal> animalList)
			{
				this.animalList = animalList;
			}

			public AnimalFarm()
			{
			}

			// Indexer for AnimalFarm created with this[]
			public Animal this[int index]
			{
				get { return (Animal)animalList[index]; }
				set { animalList.Insert(index, value); }
			}

			public int Count
			{
				get	{ return animalList.Count; }
			}

			// Returns an enumerator that is used to 
			// iterate through the collection
			IEnumerator IEnumerable.GetEnumerator()
			{
				return animalList.GetEnumerator();
			}
		}
	}
}
