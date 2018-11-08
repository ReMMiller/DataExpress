using System;
using System.Collections.Generic;
using System.Text;

namespace IntroCore
{
	class Delegates
	{
		public delegate void Arithmetic(double num1, double num2);

		public static void Display()
		{
			// (1) - delegates
			// delegates can be thought of as a function pointer
			// the delegate is set to a function
			// then when the delegate is called the function is executed 
			Arithmetic add = new Arithmetic(Add);
			Arithmetic sub = new Arithmetic(Subtract);
			Arithmetic addSub = add + sub;

			Console.Write("add: ");
			add.Invoke(5, 5);
			Console.Write("sub: ");
			sub(10, 5);

			Console.WriteLine("add + sub: ");
			addSub(30, 30);

			Arithmetic operation;
			operation = add;
			Console.Write("add: ");
			operation(30, 10);
		}

		public static void Add(double num1, double num2)
		{
			Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
		}

		public static void Subtract(double num1, double num2)
		{
			Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
		}
	}
}
