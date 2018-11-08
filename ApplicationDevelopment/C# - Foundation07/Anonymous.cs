using System;
using System.Collections.Generic;
using System.Text;

namespace IntroCore
{
	class Anonymous
	{
		delegate int Delegate1(int i);

		/// <summary>
		/// Anonymous types and methods condense the writing of coding for 
		/// creating types and delegates.
		/// </summary>
		public static void Display()
		{
			// (1) - Anonymous Types
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

			// (4) - Anonymous Method

			// An anonymous method is a method without a name. 
			// Anonymous methods in C# can be defined using the delegate keyword 
			// and can be assigned to a variable of delegate type.
			Delegate1 transform2 = delegate (int i)
			{
				return i + i;
			};

			Console.WriteLine("Anonymous Method: " + transform2(9));

			// Anonymous methods can access variables outside of the block
			int scalar = 3;
			Delegate1 transform3 = delegate (int i)
			{
				return scalar * i;
			};
			Console.WriteLine("Anonymous Method: " + transform3(10));
		}
	}
}
