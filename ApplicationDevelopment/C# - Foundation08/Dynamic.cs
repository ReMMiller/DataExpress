using System;
using System.Collections.Generic;
using System.Text;

namespace IntroCore
{
	/// <summary>
	/// The dynamic keyword is used to tell the compiler that a variable's type can 
	/// change or that it is not known until runtime.  At compile time, an element 
	/// that is typed as dynamic is assumed to support any operation. 
	/// However, if the code is not valid, errors are caught at run time.
	/// </summary>
	class Dynamic
	{
		public static void Display()
		{
			dynamic c1 = new ExampleClass();
			c1.Function01(10);
			c1.Function02();

			// Compiler will allow this call because of the use of dynamic
			// This will fail at run-time because Function03 does not exist
			//c1.Function03();

			float result = AddDynamic(4.5f, 3.8f);
			Console.WriteLine("AddDynamic: " + result);

			// var is similar to dynamic except that var is resolved at compile time
			// dynamic is resolved at run-time
			var iv1 = 5; // iv1 is of type int because of assignment type (5 = int)
						 // var iv2; // iv2 would cause an error because iv2 must be resolved when compiled
			Console.WriteLine("var: " + iv1);
			// iv1 = "Nope!"; // can't reassign var type, it is stuck at compile time

			dynamic id1 = 5; // id1 is of type int
			dynamic id2; // id2 will compile because the compiler waits till runtime to resolve

			id2 = "Hello!"; // id2 is of type string
			Console.WriteLine("dynamic: " + id2);
			id2 = 3.14159f; // id2 is of type float
			Console.WriteLine("dynamic: " + id2);

			// expressions involving dynamic operands are typically themselves dynamic
			dynamic x = 2;
			var y = x * 3;
		}

		public static double Add<T>(T v1, T v2)
		{
			return (Convert.ToDouble(v1) + Convert.ToDouble(v2));
		}

		public static dynamic AddDynamic(dynamic v1, dynamic v2)
		{
			return v1 + v2;
		}
	}

	class ExampleClass
	{
		public void Function01(int i) { Console.WriteLine("function 1: " + i); }
		public void Function02() { Console.WriteLine("function 2:"); }
	}
}
