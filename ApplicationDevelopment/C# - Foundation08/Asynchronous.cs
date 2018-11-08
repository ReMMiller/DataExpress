using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks; // include for asynchronous functions

namespace IntroCore
{
	/// <summary>
	/// You can avoid performance bottlenecks and enhance the overall responsiveness 
	/// of your application by using asynchronous programming.
	/// 
	/// Asynchrony is essential for activities that are potentially blocking, 
	/// such as web access. Access to a web resource sometimes is slow or delayed. 
	/// If such an activity is blocked in a synchronous process, 
	/// the entire application must wait. 
	/// In an asynchronous process, the application can continue with other work that
	/// doesn't depend on the web resource until the potentially blocking task finishes.
	/// </summary>
	class Asynchronous
	{
		static public void Display()
		{
			// (1) - async

			// The program has to wait here until this operation is complete
			ComplexCalculation();
			Console.WriteLine("Calculation Complete.");

			Console.WriteLine("Starting Task 1.");
			// The program continues to execute while this operation executes on a
			// different thread
			Task<int> task1 = ComplexCalculationTask();
			Console.WriteLine("Continue...");

			// this executes the delegate when the task is finished
			var awaiter = task1.GetAwaiter();
			awaiter.OnCompleted(() =>
			{
				int result1 = awaiter.GetResult();
				Console.WriteLine("Task Calculation Complete: " + result1);
			});

			Console.WriteLine("Starting Async Task 2.");
			Task<int> task2 = ComplexCalculationAsync();

			Console.WriteLine("Waiting....");
			task2.Wait();
			int result2 = task2.Result;
			Console.WriteLine("Async Calculation Complete: " + result2);

			Method1();
			Method2();
		}

		static int ComplexCalculation()
		{
			double x = 2;
			for (int i = 0; i < 100000000; i++)
			{
				x += System.Math.Sqrt(x) / i;
			}
			return (int)x;
		}

		static Task<int> ComplexCalculationTask()
		{
			return Task.Run(() => ComplexCalculation());
		}

		static async Task<int> ComplexCalculationAsync()
		{
			double x = 2;
			for (int i = 0; i < 100000000; i++)
			{
				x += System.Math.Sqrt(x) / i;
			}
			return (int)x;
		}

		public static async Task Method1()
		{
			await Task.Run(() =>
			{
				for (int i = 0; i < 100; i++)
				{
					Console.WriteLine(" Method 1");
				}
			});
		}

		public static void Method2()
		{
			for (int i = 0; i < 25; i++)
			{
				Console.WriteLine(" Method 2");
			}
		}
	}
}

