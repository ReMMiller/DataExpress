using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IntroCore
{
	class Collections
	{
		public static void Display()
		{
			// (1) - ArrayList
			// ArrayList are resizable arrays, standard arrays cannot change size once declared
			ArrayList list = new ArrayList();

			list.Add("Bob");
			list.Add(40);
			
			Console.WriteLine($"list count: {list.Count}");
			Console.WriteLine($"capacity: {list.Capacity}");

			// add ArrayList to another ArrayList
			ArrayList list2 = new ArrayList(new object[] { "Spencer", "Joseph", "Savannah" });
			list.AddRange(list2);

			Console.Write("list + list2: ");
			foreach (var item in list)
			{
				Console.Write($"{item} ");
			}
			Console.WriteLine();

			// sort ArrayList that contains like types
			list2.Sort();
			Console.Write("sort: ");
			foreach (var item in list2)
			{
				Console.Write($"{item} ");
			}
			Console.WriteLine();

			list2.Reverse();
			Console.Write("reverse: ");
			foreach (var item in list2)
			{
				Console.Write($"{item} ");
			}
			Console.WriteLine();

			// insert at index of ArrayList
			list2.Insert(2, "Ed");
			Console.Write("insert: ");
			foreach (var item in list2)
			{
				Console.Write($"{item} ");
			}
			Console.WriteLine();

			// get range from list (index, length)
			ArrayList list3 = list2.GetRange(0, 2);

			Console.WriteLine("contains Spencer: {0}", list2.Contains("Spencer"));

			Console.WriteLine("index of Savannah: {0}", list2.IndexOf("Savannah", 0));

			// (2) - dictionary
			// dictionary is a key <-> value container
			// use the key to retrieve the value associated with it
			Dictionary<string, string> chairs = new Dictionary<string, string>();
			chairs.Add("BSIS", "Rich");
			chairs.Add("BSWD", "Beatty");
			chairs["BSGD"] = "Maple";

			// number of keys
			Console.WriteLine("dictionary count: {0}", chairs.Count);

			// check if key is present
			Console.WriteLine("contains BSGD: {0}", chairs.ContainsKey("BSGD"));

			// get value from key, returns true or false if it exists
			chairs.TryGetValue("BSIS", out string bsis);
			Console.WriteLine($"get value BSIS: {bsis}");

			// cycle through key value pairs
			foreach (KeyValuePair<string, string> item in chairs)
			{
				Console.WriteLine("{0} : {1}", item.Key, item.Value);
			}

			// remove a key / value
			chairs.Remove("BSGD");

			// clear out dictionary 
			chairs.Clear();

			// (3) - queue
			// FIFO - first in first out container
			// 3 -> 2 -> 1
			Queue queue = new Queue();

			// add to queue
			queue.Enqueue(1);
			queue.Enqueue(2);
			queue.Enqueue(3);

			foreach (object o in queue)
			{
				Console.WriteLine($"queue : {o}");
			}

			// peek but don't remove
			Console.WriteLine("queue peek: {0}", queue.Peek());
			// dequeue (remove) from the front of the queue
			Console.WriteLine("queue dequeue: {0}", queue.Dequeue());
			Console.WriteLine("queue peek: {0}", queue.Peek());

			// check if queue contains a value
			Console.WriteLine("queue contains 1: {0}", queue.Contains(1));

			// convert to array
			object[] queueArray = queue.ToArray();

			// convenient way to display array 
			Console.WriteLine(string.Join(",", queueArray));

			// remove all elements from the queue
			queue.Clear();

			// (4) - stack
			// FILO - first in last out
			// 3
			// v
			// 2
			// v
			// 1
			Stack stack = new Stack();

			// add to stack
			stack.Push(1);
			stack.Push(2);
			stack.Push(3);

			foreach (object o in stack)
			{
				Console.WriteLine($"stack : {o}");
			}

			// peek but don't remove
			Console.WriteLine("stack peek: {0}", stack.Peek());
			// pop off the top of the stack
			Console.WriteLine("stack pop: {0}", stack.Pop());
			Console.WriteLine("stack peek: {0}", stack.Peek());

			// check if stack contains a value
			Console.WriteLine("contains 1: {0}", stack.Contains(1));
						
			// convert to array
			object[] stackArray = stack.ToArray();
			
			// convenient way to display array 
			Console.WriteLine(string.Join(",", stackArray));

			// remove all elements from the stack
			stack.Clear();
		}
	}
}
