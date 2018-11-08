using System;
using System.Collections.Generic;
using System.Text;

namespace IntroCore
{
	class Interation
	{
		public static void Display()
		{
			// (1) - for loop
			for (int i = 0; i < 4; i++)
			{
				Console.WriteLine("i: {0} ", i);
			}
			for (int i = 0; i < 10; i++)
			{
				if ((i % 2) == 0)
				{
					Console.WriteLine("i even: {0} ", i);
				}
			}

			// (2) - foreach in
			string[] animals = { "cat", "dog", "zebra", "rhino" };
			foreach (string animal in animals)
			{
				Console.WriteLine(animal);
			}
			foreach (string animal in animals)
			{
				if (animal == "zebra")
				{
					break;
				}
				Console.WriteLine(animal);
			}

			// (3) - while
			string userInput = "";

			while (!userInput.Equals("yes", StringComparison.OrdinalIgnoreCase))
			{
				Console.WriteLine("While Loop");
				Console.Write("Exit? [yes] [no]: "); userInput = Console.ReadLine();
			}

			//userInput = "";
			//while (userInput.ToLower() != "yes")
			//{
			//	Console.WriteLine("While Loop");
			//	Console.Write("Exit? [yes] [no]: "); userInput = Console.ReadLine();
			//}

			// (4) - do-while
			//do
			//{
			//	Console.WriteLine("While Loop");
			//	Console.Write("Exit? [yes] [no]: ");
			//	userInput = Console.ReadLine();
			//}
			//while (userInput.ToLower() != "yes");

			// (5) - equality operators
			// == != < > <= >=
			//if (5 > 10)
			//if (6 == 2)

			// (6) - conditional operators
			// && - AND 
			// || - OR
			// !  - NOT
			//if (health <= 0 && name == "player")


			// (7) - switch
			// #
			// string
			// enums
		}
	}
}
