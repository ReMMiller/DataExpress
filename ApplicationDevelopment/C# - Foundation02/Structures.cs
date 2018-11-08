using System;
using System.Collections.Generic;
using System.Text;

namespace IntroCore
{
	class Structures
	{
		public static void Display()
		{
			// (1) - structures
			Point p1;
			p1.X = 20;
			p1.Y = 12;
			p1.Display();

			Point p2 = new Point(); // default constructor
			p2.Display();

			Point p3 = new Point(43, 78);
			p3.Display();
		}

		struct Point
		{
			// fields/members are all data in a struct
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
	}
}
