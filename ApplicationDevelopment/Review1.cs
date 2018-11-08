using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review
{
    class Review
        
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name? ");
            string input = Console.ReadLine();
            Console.WriteLine("Using variable output: {0}.", input);
            Console.WriteLine("Using string interpolation: " + input + "\n");

            string senVer = @"C:\\myfolder\\verbatim.txt";
            string esc = "This is my \"string\"";
            Console.WriteLine(senVer);
            Console.WriteLine(esc);

            string nice = "Today is a nice day!";
            Console.WriteLine(nice);
            string fantastic = nice.Replace("nice", "fantastic");
            Console.WriteLine(fantastic + "\n");

            string buil = "Welcome too Neumont College!\n";
            StringBuilder builder = new StringBuilder(buil, 256);
            builder.Remove(10,1);
            Console.WriteLine(builder);

            Console.WriteLine("How many bits in a short? {0}", 16);
            string refer = "Reference type variables are stored on the stack, \nwhile static and instance variables are stored on the heap";
            Console.WriteLine("Where are data types stored? {0}\n", refer);

            byte b1 = 123;
            int i1 = (int)b1;
            Console.WriteLine(b1 + " to " + i1 + "\n\n");

            Console.WriteLine("This issue with casting an int to a byte is that an int is bigger, so it must be cut down to the size of a byte.");
            Console.WriteLine("This issue is called trunication.\n");


            Console.WriteLine("string fruit = 'apple';\n");

            DateTime date = new DateTime(1999, 7, 9);
            Console.WriteLine("My bday is: {0}.\n", date.ToShortDateString());
            Console.WriteLine("My bday is: {0}/{1}/{2}/{3}.\n", date.Day, date.Month, date.Year, date.DayOfWeek);

            int[] arr1 = new int[] {35, 10, 55, 120, 5};
            Array.Sort(arr1);
            for(int x = 0; x<arr1.Length; x++){
                Console.Write(arr1[x] + " ");
            }
            Console.Write("\n");

            object oo = new object();
            object tt = new object();
            long ll = 232;
            int ii = 10;
            string ss = "ss";

            object[] arr2 = new object[] {oo, ll, ss, ii, tt};
            for(int x = 0; x<arr2.Length; x++){
                Console.Write(arr2[x] + " ");
            }
            Console.Write("\n");

            Queue<float> q = new Queue<float>();
            q.Enqueue(21.34f);
            q.Enqueue(22.3445f);
            q.Enqueue(72.2f);
            q.Dequeue();
            foreach(float element in q){
                Console.Write(element + " ");
            }
            Console.Write("\n");

            Stack<int> ints = new Stack<int>();
            ints.Push(32);
            ints.Push(22);
            ints.Push(827);
            Console.WriteLine(ints.Peek());
            Console.WriteLine(ints.Pop() + "\n");

            ints.ToArray();
            ints.Clear();
            q.Clear();

            string ans = "\n'Stack' is a place of storage in memory, whereas 'Stack<>' is a class type"; 
            Console.WriteLine("What's the difference between Stack<> and Stack : {0}.\n", ans);

            int i = 0;
            do{
                i +=1;
            }while(i == 0);

            for(int i = 0; i<10; i++){
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            try
            {
                string sn = "23s4";
                int i = int.Parse(sn);
            }
            catch(Exception exception)
            {
                Console.WriteLine("Exception type exception : Cannot convert string to int.\n");
            }

            Nullable<int> bored = null;
            if ((bored ?? 0) == 0 )
            {
                bored = 5;
            }

            ///////////////////////////////////////////////////////
            ///
            int bla = 500 - 20;
            Console.WriteLine("500 - 20 = " + bla);











        Console.ReadLine();
        }
    }


    class objRand{

     }


}
