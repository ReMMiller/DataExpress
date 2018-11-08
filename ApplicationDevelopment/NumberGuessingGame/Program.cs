using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    class Program
    {
        public static int num;
        public static string tooHighLow;
        public static bool isSound = true;

        /////////////////////////////////////////////////////////////////////////////////
        static void Main(string[] args)
        {
            bool cont = true;
            bool validNum = false;

            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Gray;

            while (cont)
            {
                validNum = GetNumber();
                while (validNum == false)
                {
                    validNum = GetNumber();
                }

                cont = Game();
            }

        }
        ////////////////////////////////////////////////////////////////////////////////////
        public static bool Game()
        {

            Random rand = new Random();
            int genNum = rand.Next(0, num);
            
            Console.WriteLine("Guess a random number between 0-{0}", num);
            Console.WriteLine(genNum);
            string response = "";
            
            for(int tries = 5; tries>0; tries-=1)
            {
                response = Console.ReadLine();
                if (IsCorrect(response, genNum) && tries >=1)
                {
                    if (isSound)
                    {
                        Console.Beep(900, 100);
                    }
                    Console.WriteLine("You got it right! The answer was {0}!", genNum);
                    
                    tries = 0;
                }
                else
                {
                    if (isSound)
                    {
                        Console.Beep(37, 100);
                    }
                    Console.WriteLine("Nope. {0} was {1}. {2} tries left.", response, tooHighLow, tries-1);
                    
                    if(tries > 1)
                    {
                        Console.WriteLine("Please guess again: ");
                    }
                }
            }
            if(!IsCorrect(response, genNum))
            {
                Console.WriteLine("Sorry, you ran out of tries. The number was: {0}.", genNum);
                
            }

            Console.WriteLine("Play again? [yes / no] ", genNum);
            string again = Console.ReadLine();

            if ((string.Equals(again.ToLower(), "yes")) || (string.Equals(again.ToLower(), "y")))
            {
                Console.WriteLine("Alright then! Let's play again!");
                Console.Clear();
                return true;
            }
            else
            {
                Console.WriteLine("Alright then. See you next time!");
                return false;
            }

            

        }
        ///////////////////////////////////////////////////////////////////////////////////
        public static bool GetNumber()
        {
            num = 0;
            bool valid = false;
            Console.WriteLine("Please enter your maximum random number: ");

            while (!valid)
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out num))
                {
                    Console.WriteLine("Alright then! The maximum random number is: {0}.", num);
                    return true;
                    
                }
                else
                {
                    Console.WriteLine("Sorry, {0} wasn't a proper value. Plase enter a valid /maximum random value/.", input);
                    return false;
                }

            }
            return true;
            
        }
        ///////////////////////////////////////////////////////////////////////////////////
        public static bool IsCorrect(string numb, int answer)
        {
            int numbb;

            if(int.TryParse(numb, out numbb))
            {
                if(numbb > answer)
                {
                    tooHighLow = "too high";
                }
                else if(numbb < answer)
                {
                    tooHighLow = "too low";
                }

                if(numbb == answer)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }

}
