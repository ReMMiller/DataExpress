using System;
using System.Text;


namespace IntroCore
{
	class Strings
	{
		public static void Display()
		{
			// (1) - creation
			string str = "This is a string";
			Console.WriteLine(str);

			// (2) - length
			Console.WriteLine("Length: {0}", str.Length);

			// (3) - contains
			Console.WriteLine("Contains 'is': {0}", str.Contains("is"));
			Console.WriteLine("Index of 'is': {0}", str.IndexOf("is"));

			// (4) - remove / insert / replace
			Console.WriteLine("Remove: {0}", str.Remove(10, 6));
			Console.WriteLine("Insert: {0}", str.Insert(10, "short "));
			Console.WriteLine("Replace: {0}", str.Replace("string", "sentence"));

			// (5) - compare
			// < 0 : str1 preceeds str2
			// = : Zero
			// > 0 : str2 preceeds str1
			Console.WriteLine("Compare A to B : {0}", String.Compare("A", "B", StringComparison.OrdinalIgnoreCase));
			Console.WriteLine("A = a : {0}", String.Equals("A", "a", StringComparison.OrdinalIgnoreCase));
			Console.WriteLine("Hello == Hello: {0}", "Hello" == "Hello");
			Console.WriteLine("Hello != Hello: {0}", "Hello" != "Hello");

			// (6) - padding
			Console.WriteLine("Pad Left: {0}",	str.PadLeft(20, '.'));
			Console.WriteLine("Pad Right: {0}", str.PadRight(20, '.'));

			// Trim whitespace
			Console.WriteLine("Trim : {0}",	str.Trim());

			// (7) - upper / lower case
			Console.WriteLine("Uppercase: {0}", str.ToUpper());
			Console.WriteLine("Lowercase : {0}", str.ToLower());

			// (8) - format
			string strFormat = String.Format("{0} {1} to {2} in the {3}.",
				"Ashley", "walked", "school", "rain");
			Console.WriteLine(strFormat);

			// (9) - concatenate
			string strB = " Poor girl.";
			Console.WriteLine(strFormat + strB);

			// (10) - escape characters
			// \' \" \\ \t \a

			// verbatim strings ignore escape characters
			Console.WriteLine(@"C:\downloads\apps");
			string verbatim = @"""hello!""";
			Console.WriteLine(verbatim);

			// (11) - StringBuilder
			StringBuilder sb = new StringBuilder("This is other text", 256);
			Console.WriteLine("SB: {0}", sb);
			Console.WriteLine("SB Capacity: {0}", sb.Capacity);
			Console.WriteLine("SB Length: {0}", sb.Length);

			// (12) - StringBuilder append / replace / insert / remove
			sb.Append(" to display");
			Console.WriteLine("SB Append: {0}", sb);
			sb.Replace("display", "show");
			Console.WriteLine("SB Replace: {0}", sb);
			sb.Insert(8, "the ");
			Console.WriteLine("SB Insert: {0}", sb);
			sb.Remove(12, 6);
			Console.WriteLine("SB Remove: {0}", sb);

			string newStr = "Lucy";
			sb.AppendFormat(" to {0}", newStr);
			Console.WriteLine("SB Append Format: {0}", sb);

			// (13) - StringBuilder compare
			StringBuilder sbo = new StringBuilder("This is text");
			Console.WriteLine("Equals: {0}", sb.Equals(sbo));
			Console.WriteLine("==: {0}", sb == sbo);

			sb.Clear();
			Console.WriteLine("SB Clear: {0}", sb);
		}
	}
}
