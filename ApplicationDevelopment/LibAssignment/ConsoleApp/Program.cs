using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleLib;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Enter a valid year: \n");
           // ConsoleIO.ReadInteger("Year: ", 0000, 2018);

            ConsoleIO.Read_Value<byte>("Enter age: ", 0, 110);
            ConsoleIO.Read_Value<short>("Enter area code: ", 0, 999);
            ConsoleIO.Read_Value<int>("Enter zip code: ", 0, 99999);
            ConsoleIO.Read_Value<long>("Enter a number: ", long.MinValue, long.MaxValue);
            ConsoleIO.Read_Value<float>("Enter amount in checking account: ", float.MinValue, float.MaxValue);
            ConsoleIO.Read_Value<decimal>("Enter desired salary: ", 0, decimal.MaxValue);
            ConsoleIO.Read_Value<char>("Enter First Initial: ");

            ConsoleIO.ReadBoolean("I am happy [true/false]: ");
            ConsoleIO.ReadString("Enter ypur last name: ");

            string[] arr = new string[5];
            arr[0] = "Open";
            arr[1] = "Save";
            arr[2] = "Print";
            arr[4] = "Close";
            ConsoleIO.ReadMenu();

            Console.ReadLine();
        }
    }
}
