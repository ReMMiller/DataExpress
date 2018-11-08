using System;
using System.Numerics;

namespace IntroCore
{
	class DataTypes
	{
		public static void Display()
		{
			//sbyte		-128 to 127 Signed 8 - bit integer
			//byte		0 to 255    Unsigned 8 - bit integer
			//char		U+0000 to U+ffff    Unicode 16 - bit character
			//short		-32,768 to 32,767   Signed 16 - bit integer
			//ushort	0 to 65,535 Unsigned 16 - bit integer
			//int		-2,147,483,648 to 2,147,483,647 Signed 32 - bit integer
			//uint		0 to 4,294,967,295  Unsigned 32 - bit integer
			//long		-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 Signed 64 - bit integer
			//ulong		0 to 18,446,744,073,709,551,615 Unsigned 64 - bit integer

			// (1) bool
			bool boolean = true;
			boolean = bool.Parse("True");
			string strBoolean = boolean.ToString();
			Console.WriteLine("bool {0} : {1}", boolean, strBoolean);

			// (2) integer
			// int - 32-bit
			int integer = 10;
			integer = integer / 10;
			//uint uinteger = -20;
			Console.WriteLine("int (32-bit): {0}", integer);
			Console.WriteLine("int min: {0}", int.MinValue);
			Console.WriteLine("int max: {0}", int.MaxValue);

			int strInteger = int.Parse("100");
			bool isValid = int.TryParse("500", out integer);

			// (3) long - 64-bit
			long longInteger = 3200;
			Console.WriteLine("long (64-bit): {0}", longInteger);
			Console.WriteLine("long min: {0}", long.MinValue);
			Console.WriteLine("long max: {0}", long.MaxValue);

			// (4) float - 32-bit
			float fp = 32.45f;
			Console.WriteLine("float (32-bit): {0}", fp);
			Console.WriteLine("float -> int: {0}", (int)fp);
			Console.WriteLine("min: {0}", float.MinValue);
			Console.WriteLine("max: {0}", float.MaxValue);

			// (5) doubles - 64-bit
			double db = 2.5445;
			Console.WriteLine("double (64-bit): {0}", db);
			Console.WriteLine("min: {0}", double.MinValue);
			Console.WriteLine("max: {0}", double.MaxValue);
			
			// (6) decimal - 128 bit
			decimal dec = 5.434023M;
			Console.WriteLine("decimal (128 bit): {0}", dec);
			Console.WriteLine("min: {0}", decimal.MinValue);
			Console.WriteLine("max: {0}", decimal.MaxValue);
			
			// (7) cast
			//integer = longInteger;
			integer = (int)longInteger;
			int i = 320;
			byte b = (byte)i;
			i = b;
			Console.WriteLine("cast int(320) -> byte (narrowing): {0}", b);
			Console.WriteLine("cast byte -> int (widening): {0}", i);

			// (8) numeric format
			// "C" or "c"	Currency ($###.##)
			// "D" or "d"	Decimal (00##)
			// "E" or "e"	Exponential (scientific)
			// "F" or "f"	Fixed-point (##.##00)
			// "P" or "p"	Percent (##.#%)
			// "N" or "n"	Number (#,###)
			// "X" or "x"	Hexadecimal
			Console.WriteLine("Currency: {0:c}", 29.455);
			Console.WriteLine("Decimal: {0:d4}", 65);
			Console.WriteLine("Exponential: {0:e1}", 6313.435);
			Console.WriteLine("Fixed Point: {0:f3}", 53.4555);
			Console.WriteLine("Percent: {0:p1}", .53462);
			Console.WriteLine("Number: {0:n0}", 2300);

			// (9) char
			char c = 'a';
			Console.WriteLine("IsDigit: {0}", char.IsDigit(c));
			Console.WriteLine("IsLetter: {0}", char.IsLetter(c));

			// (9) implicit types
			var value = 345;
			Console.WriteLine("type: {0}", value.GetType());
			//var valueA;
			int integerA = 4565;
			var vinteger = integerA;
			//vinteger = "something";

			// (10) Date Time
			DateTime dt = new DateTime(2017, 10, 3);
			Console.WriteLine("Your birthday on {0} was {1}", dt.Date, dt.DayOfWeek);
			dt = DateTime.Today;
			Console.WriteLine("Today is {0} {1}", dt.Date.ToString("dd/MM/yyyy"), dt.DayOfWeek);

			// (11) Time Span
			TimeSpan ts = new TimeSpan(2, 30, 30);
			Console.WriteLine("TimeSpan: {0}", ts);
			Console.WriteLine("TimeSpan Seconds: {0}", ts.TotalSeconds);
			Console.WriteLine("TimeSpan: {0}", ts - new TimeSpan(1, 15, 15));

			// (12) Big Integer
			BigInteger bigNumber = 99999999999999999;
			Console.WriteLine("BigInteger: {0}", bigNumber);
			Console.WriteLine("BigInteger (^2): {0}", bigNumber * bigNumber);
		}
	}
}
