using System;
using System.ComponentModel;

namespace ConsoleLib
{
    public class ConsoleIO
    {
        public static void Test()
        {
            string numString = "34";
            int num;
            bool success = TryParse(numString, out num);
        }

        public static T Read_Value<T>(string message, T min, T max)
        {
            T result;
            bool valid = false;
            do
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();
                bool validInput = TryParse<T>(input, out result);

                if(Type.GetTypeCode(typeof(T)) == TypeCode.Char)
                {
                    char res;
                    TryParse<char>(input, out res);

                    if(char.IsLetter(res))
                    {
                        validInput = true;
                    } else {
                        validInput = false;
                    }
                } else{
                    foreach(char a in input)
                    {
                        if(char.IsDigit(a) || a.Equals("."))
                        {
                            validInput = true;
                        } else {
                            validInput = false;
                        }
                    }
                }
                
                if (validInput)
                {
                    Console.WriteLine("true");
                    switch(Type.GetTypeCode(typeof(T)))
                    {
                        case TypeCode.Int32:

                            valid = (result >= min && result <= max);
                            break;
                        default:
                            throw new Exception("Type not supported.");
                    }
                }else{
                    throw new Exception("Type not supported.");
                }

            } while (!valid);

            return result;
        }

        static bool TryParse<T>(string text, out T value)
             {
                    value = default(T);
 
                    try
                    {
                           value = (T)Convert.ChangeType(text, typeof(T));
                           return true;
                    }
                    catch
                    {
                           return false;
                    }
             }
        
        public static bool ReadBoolean(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            bool valid = false;

            Boolean.TryParse(input, out valid);
            Console.WriteLine("The input was valid: {0}", valid);


            return valid;

        }

        public static string ReadString(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return input;
        }

        public static int ReadMenu(string[] items)
        {
            for(int a = 0; a < items.Length; a++)
            {
                Console.WriteLine("0 - Quit");

                int num = a+1;
                Console.WriteLine(num + " - " + items[a]);
                
            }
            string input = Console.ReadLine();

            int v = items.Length + 5;
            int.TryParse(input, out v);

            if(v != items.Length + 5){return v;}
            else{return -1;}
        }
                
    }
}
