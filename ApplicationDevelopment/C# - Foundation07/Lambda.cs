using System;
using System.Collections.Generic;
using System.Text;

namespace IntroCore
{
	/// <summary>
	/// A lambda expression is an anonymous function that you can use 
	/// to create delegates or expression tree types. By using lambda expressions, 
	/// you can write local functions that can be passed as arguments or 
	/// returned as the value of function calls. 
	/// Lambda expressions are particularly helpful for writing LINQ query expressions.
	/// The => token is called the lambda operator. 
	/// </summary>
	class Lambda
	{
		delegate int Delegate1(int i);
		delegate void Delegate2(int i1, int i2);

		public static void Display()
		{
			Delegate1 transform = SqrFunction;
			Console.WriteLine("Delegate: " + transform(5));

			// (1) - Lambda
			// (parameters) => expression or statement block
			// The parentheses are optional only if the lambda has one input 
			// parameter; otherwise they are required. 
		
			// no parentheses required for one parameter
			Delegate1 lambda1 = x => x * x; 
			Console.WriteLine("Lambda: " + lambda1(10));

			// parentheses required for more than one parameter
			Delegate2 lambda2 = (x, y) => { Console.WriteLine($"{x} - {y}"); };
			Console.Write("Lambda: ");
			lambda2(7, 11);

			// you can specify the types explicitly as shown 
			// in the following example
			// (int x, string s) => s.Length > x

			// Specify zero input parameters with empty parentheses:
			// () => SomeMethod()

			// (2) - Func

			// Func is a generic delegate that encapsulates a method 
			// that can accept parameters and return some value.
			// Func<in, in, ..., out>

			// Func using a method
			Func<int, int> func1 = SqrFunction;
			Console.WriteLine("Func: " + func1(8));

			// Func using a lambda
			Func<int, int, string> func2 = (x, y) => { return (x + y).ToString(); };
			Console.WriteLine("Func: " + func2(23, 36));

			// (3) - Action

			// The difference between Func and Action is simply whether 
			// you want the delegate to return a value (use Func) 
			// or not (use Action).
			// Action<in, in, ...>

			// Action using a method
			Action<int> action1 = PrintFunction;
			Console.Write("Action: ");
			action1(123);

			Action<int, int> action2 = (x, y) => { Console.WriteLine("Action: " + (x + y)); };
			action2(21, 75);
		}

		public static int SqrFunction(int i)
		{
			return i * i;
		}

		public static void PrintFunction(int i)
		{
			Console.WriteLine(i);
		}
	}
}
