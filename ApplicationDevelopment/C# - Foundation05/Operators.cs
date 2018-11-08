using System;
using System.Collections.Generic;
using System.Text;

namespace IntroCore
{
	class Operators
	{
		public static void Display()
		{
			// (1) - Operator Overloading
			// Operator Overloading are user defined implementations of Unary and Binary operators
			Vec2 v1 = new Vec2(5, 5);
			Vec2 v2 = new Vec2(10, 10);

			Console.WriteLine("vec1: {0}", v1.ToString());
			Console.WriteLine("vec2: {0}", v2.ToString());
			Console.WriteLine("-vec2: {0}", (-v2).ToString());

			Vec2 v3 = v1 + v2;
			Vec2 v4 = v1 - v2;

			Console.WriteLine("vec1 + vec2: {0}", v3.ToString());
			Console.WriteLine("vec1 - vec2: {0}", v4.ToString());
		}
	}
	
	// +, -, !, ~, ++, ––		Unary operators take one operand and can be overloaded.
	// +, -, *, /, %			Binary operators take two operands and can be overloaded.
	// ==, !=, =				Comparison operators can be overloaded.
	// &&, ||					(NO) Conditional logical operators cannot be overloaded directly
	// +=, -+, *=, /=, %=, =	(NO) Assignment operators cannot be overloaded.

	class Vec2
	{
		public float x;
		public float y;

		public Vec2(float x = 0.0f, float y = 0.0f)
		{
			this.x = x;
			this.y = y;
		}

		public static Vec2 operator + (Vec2 v1, Vec2 v2)
		{
			Vec2 vec2 = new Vec2();

			vec2.x = v1.x + v2.x;
			vec2.y = v1.y + v2.y;

			return vec2;
		}

		public static Vec2 operator - (Vec2 v1, Vec2 v2)
		{
			Vec2 vec2 = new Vec2();

			vec2.x = v1.x - v2.x;
			vec2.y = v1.y - v2.y;

			return vec2;
		}

		public static bool operator == (Vec2 v1, Vec2 v2)
		{
			return (v1.x == v2.x && v1.y == v2.y);
		}

		public static bool operator != (Vec2 v1, Vec2 v2)
		{
			return (v1.x != v2.x || v1.y != v2.y);
		}

		public static bool operator < (Vec2 v1, Vec2 v2)
		{
			return (v1.x < v2.x && v1.y < v2.y);
		}

		public static bool operator > (Vec2 v1, Vec2 v2)
		{
			return (v1.x > v2.x && v1.y > v2.y);
		}

		public static Vec2 operator - (Vec2 v1)
		{
			Vec2 vec2 = new Vec2();
			vec2.x = -v1.x;
			vec2.y = -v1.y;

			return vec2;
		}

		public override string ToString()
		{
			return $"{x} , {y}";
		}

		public override bool Equals(object obj)
		{
			if (obj is Vec2)
			{
				return this == (Vec2)obj;
			}

			return false;
		}

		public override int GetHashCode()
		{
			return new { x, y }.GetHashCode();
		}
	}
}
