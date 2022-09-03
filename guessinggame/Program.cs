using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "goldman";
            string guess = "";

            while (guess != secretWord)
            {
                Console.Write("Enter guess: ");
                guess = Console.ReadLine();
            }
            Console.WriteLine("you win!");
        }
    }
}