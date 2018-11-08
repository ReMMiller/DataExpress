using System;
using System.Collections.Generic;
using System.Text;

namespace IntroCore
{
	class Exceptions
	{
		public static void Display()
		{
			// (1) - exceptions
			// exceptions will try to catch and handle errors rather than crash the program

			// code inside the try block will throw an exception if there is an error
			try
			{
				Console.Write("Enter divisor: ");
				string s = Console.ReadLine();
				int divisor = int.Parse(s);
				Console.WriteLine("5 / {0} = {1}", divisor, 5 / divisor);
				//Console.WriteLine("more code...");
			}
			// if there is an exception thrown it will enter the catch block
			catch (DivideByZeroException exception)
			{
				Console.WriteLine(exception.GetType().Name);
				Console.WriteLine(exception.Message);
			}

			try
			{
				//Console.WriteLine("ints[12] = 5");
				//int[] ints = new int[10];
				//ints[12] = 5;

				int i = 0;
				if (i == 0)
				{
					throw new Exception("0 value is not allowed.");
				}
			}

			catch (System.IndexOutOfRangeException exception)
			{
				Console.WriteLine("catch: index out of range");
				Console.WriteLine(exception.GetType().Name);
				Console.WriteLine(exception.Message);
			}

			// general "catch all" exception
			catch (System.Exception exception)
			{
				Console.WriteLine("catch: exception");
				Console.WriteLine(exception.GetType().Name);
				Console.WriteLine(exception.Message);
			}
			// finally will always be called (in normal execution or exception)
			// good to use to clean up resources, close files
			finally
			{
				Console.WriteLine("finally: clean up");
			}
		}
	}
}

// available exceptions

//System.IO.IOException
//Handles I/O errors.

//System.IndexOutOfRangeException
//Handles errors generated when a method refers to an array index out of range.

//System.ArrayTypeMismatchException
//Handles errors generated when type is mismatched with the array type.

//System.NullReferenceException
//Handles errors generated from referencing a null object.

//System.DivideByZeroException
//Handles errors generated from dividing a dividend with zero.

//System.InvalidCastException
//Handles errors generated during typecasting.

//System.OutOfMemoryException
//Handles errors generated from insufficient free memory.

//System.StackOverflowException
//Handles errors generated from stack overflow.
