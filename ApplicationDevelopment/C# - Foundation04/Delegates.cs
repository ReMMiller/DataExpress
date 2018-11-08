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
			// the delegate is set to a method
			// then when the delegate is called the method is executed 
			Arithmetic operationDelegate = Add;

			// can use () or .Invoke() to call delegate 
			Console.Write("add: ");
			operationDelegate(5, 5);
			Console.Write("add - Invoke(): ");
			operationDelegate.Invoke(10, 5);

			operationDelegate = Subtract;
			Console.Write("sub: ");
			operationDelegate(20.0, 12.75);

			// (2) - multi-cast delegate
			// multi-cast delegate can point to multiple methods
			Arithmetic operationsDelegate = Add;
			operationsDelegate += Subtract;
			Console.Write("add + sub: ");
			operationsDelegate(35.0, 14.0);

			// (3) - delegate as a method parameter
			// methods can also take delegates as a parameter
			Console.WriteLine("delegate method parameter: ");
			Execute(Add, 24.4, 45.5);
			Execute(Subtract, 24.4, 45.5);
		}

		public static void Add(double num1, double num2)
		{
			Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
		}

		public static void Subtract(double num1, double num2)
		{
			Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
		}

		public static void Execute(Arithmetic arithmetic, double num1, double num2)
		{
			arithmetic(num1, num2);
		}
	}
}
