using System;
using System.Collections.Generic;
using System.Text;

namespace IntroCore
{
	class Generics
	{
		public delegate T operation<T>(T param1, T param2);

		public static void Display()
		{
			// (1) - generics
			// Generics allow you to define a class, struct or method with a placeholder type <>.
			// The placeholder type <> is replaced by an actual data type
			// when the class or struct is created or the method is called.
			// The idea is that the same algorithm can be used with multiple data types
			// example: <T> - T is the placeholder 
			// Add<T>(T num1, T num2)
			// T is replaced by the type used in the calling method
			// Add<int>(34, 76);
			// Add<float>(9.4f, 23.8f);

			Add<int>(87, 123); // the <int> is optional, the type is inferred by the parameters
			Add(54.4f, 23);

			// (2) - Class Generics
			// Classes can use generics for the data members
			Console.WriteLine("Generic Class:");
			Data<int> data = new Data<int>(20);
			data.Display();

			Rectangle<float> rect1 = new Rectangle<float>(23.5f, 54.7f);
			Console.WriteLine($"Rectangle<float>: {rect1.GetArea()}");

			Rectangle<int> rect2 = new Rectangle<int>(4, 7);
			Console.WriteLine($"Rectangle<int>: {rect2.GetArea()}");

			// (3) - Delegate Generics
			Console.WriteLine("Generic Delegates:");
			operation<int> add = Addition;
			Console.WriteLine($"5 + 10 = {add(5, 10)}");

			operation<float> sub = Subtraction;
			Console.WriteLine($"105.6f - 39.6f = {sub(105.6f, 39.6f)}");

			operation<double> multiply1 = Multiplication;
			Console.WriteLine($"8.2 * 4.5 = {multiply1(8.2, 4.5)}");
			
			operation<int> multiply2 = Multiplication;
			Console.WriteLine($"8 * 4 = {multiply2(8, 4)}");

			// Generics can be used on these type:
			// Interface
			// Abstract class
			// Class
			// Method
			// Static method
			// Property
			// Event
			// Delegates
			// Operator

			// (4) - Container Generics
			// Containers can use generics to specify the exact type contained.
			// This can be used to increase performance and
			// to more clearly describe what is contained in the container.

			// List<T>
			List<int> ints = new List<int>() { 1, 2, 3, 4 };
			Console.Write("List<int>: ");
			foreach(int i in ints)
			{
				Console.Write($"{i} ");
			}
			Console.WriteLine();
			Console.WriteLine("List<int> count: {0}", ints.Count);

			List<Animal> animals = new List<Animal>();
			animals.Add(new Animal("cat"));
			animals.Add(new Animal("dog"));
			animals.Add(new Animal("bird"));
			Console.Write("List<Animal>: ");
			foreach (Animal animal in animals)
			{
				Console.Write($"{animal.name} ");
			}
			Console.WriteLine();

			Console.WriteLine($"Animal at index 1: {animals[1].name}");

			Console.Write("ForEach: ");
			animals.ForEach(element => Console.Write($"{element.name} "));
			Console.WriteLine();

			// Stack<T> (FILO) - First In Last Out

			// Queue<T> (FIFO) - First In First Out

			// Dictionary<TKey, TValue>
			IDictionary<int, string> dictionary = new Dictionary<int, string>()	{ {1, "One"}, {2, "Two"}, {3,"Three" } };
			dictionary.Add(new KeyValuePair<int, string>(4, "Four"));
			dictionary[5] = "Five";
			Console.WriteLine("Dictionary");
			foreach (var v in dictionary)
			{
				Console.WriteLine($"key: {v.Key} - value: {v.Value} ");
			}

			// use TryGetValue to get value from string
			string value;
			bool success = dictionary.TryGetValue(3, out value);
			if (success)
			{
				Console.WriteLine($"TryGetValue (true): {value}");
			}
			// may throw exception using this accessor
			value = dictionary[3];

			dictionary.ContainsKey(1);
			dictionary.Contains(new KeyValuePair<int, string>(1, "One"));
			dictionary.Remove(1);
			
			// (5) - Boxing / Unboxing
			// Boxing is converting a Value Type (int, float, char, bool) to a Reference Type (object)
			// Unboxing is converting a Reference Type to a Value Type

			int number = 45; // value type - stored on the stack

			// Boxing : int -> object
			object numberObject = number; // Boxing - turns value type (stack) to reference type (heap)
			
			number = 55;
						
			// Unboxing: object -> int
			int otherNumber = (int)numberObject; // Unboxing - turns reference type (heap) to value type (stack)

			Console.WriteLine("Boxing / Unboxing");
			Console.WriteLine($"number: {number}");
			Console.WriteLine($"number: {numberObject}");
			Console.WriteLine($"number: {otherNumber}");
		}

		// no need to create multiple methods where the only different is the parameter type
		public static int Addition(int num1, int num2)
		{
			return (num1 + num2);
		}

		public static float Subtraction(float num1, float num2)
		{
			return (num1 - num2);
		}

		public static T Multiplication<T>(T num1, T num2)
		{
			double d1 = Convert.ToDouble(num1);
			double d2 = Convert.ToDouble(num2);
			double result = d1 * d2;

			// convert type (double) to T
			return (T)Convert.ChangeType(result, typeof(T));
		}

		public static void Add<T>(T num1, T num2)
		{
			double d1 = Convert.ToDouble(num1);
			double d2 = Convert.ToDouble(num2);
			Console.WriteLine($"{d1} + {d2} = {d1 + d2:f2}");
		}

		class Data<T>
		{
			private T data;
			public T dataProperty { get; set; }

			public Data(T value)
			{
				data = value;
			}

			public void Display()
			{
				Console.WriteLine("Class Data Type: {0} - {1}", data, data.GetType());
			}
		}

		class Rectangle<T>
		{
			private T width;
			private T height;

			public Rectangle(T width, T height)
			{
				this.width = width;
				this.height = height;
			}

			public T GetArea()
			{
				double result =  Convert.ToDouble(width) + Convert.ToDouble(height);
				// convert type (double) to T
				return (T)Convert.ChangeType(result, typeof(T));
			}
		}

		class Animal
		{
			public string name;

			public Animal(string name)
			{
				this.name = name;
			}
		}
	}
}
