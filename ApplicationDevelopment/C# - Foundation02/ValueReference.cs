using System;
using System.Collections.Generic;
using System.Text;

namespace IntroCore
{
	class ValueReference
	{
		public static void Display()
		{
			// (1) - value type 
			Point p1 = new Point(20, 20);
			Point p2 = p1;
			
			p1.Display();
			p2.Display();
			// p1 and p2 are unique value type objects, changes to one will not affect the other
			p1.X = 123;
			p1.Y = 456;

			p1.Display();
			p2.Display();

			// (2) - reference type
			PointRef pr1 = new PointRef(40, 40);
			PointRef pr2 = pr1;

			pr1.Display();
			pr2.Display();
			// p1 and p2 point (refer) to the same object on the heap (memory)
			// changes made will change the object they point to in memory affecting both
			pr1.X = 789;
			pr1.Y = 012;

			pr1.Display();
			pr2.Display();
		}

		struct Point
		{
			// fields
			public int X;
			public int Y;

			public Point(int _X, int _Y)
			{
				X = _X;
				Y = _Y;
			}

			public void Display()
			{
				Console.WriteLine($"X = {X} - Y = {Y}");
			}
		}

		class PointRef
		{
			// fields
			public int X;
			public int Y;

			public PointRef(int _X, int _Y)
			{
				X = _X;
				Y = _Y;
			}

			public void Display()
			{
				Console.WriteLine($"X = {X} - Y = {Y}");
			}
		}
	}
}
