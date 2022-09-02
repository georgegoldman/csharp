using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "georgegoldman";
            int characterAge = 25;
            /*Console.WriteLine("There was once a man named " + characterName);
            Console.WriteLine("He was "+ characterAge +" years old");
            Console.WriteLine("He really liked the name "+ characterName);
            Console.WriteLine("But didn't like being "+characterAge );*/
            char grade = 'A';
            int age = -30;
            double gpa = 3.2;
            bool isMale = true;

            // Console.WriteLine(30);

            // working with strings
            string phrase = "Goldman";
            int getLength = phrase.Length;
            string phraseToUppercase = phrase.ToUpper();
            bool phraseIfContainsWord = phrase.ToLower().Contains("gold");
            bool phraseIfContainsChar = phrase.ToLower().Contains('a');
            char printPhraseChar = phrase[5];
            int printPhraseCharPosition = phrase.IndexOf('o');
            string phraseChunkString = phrase.Substring(1,3);

            /*
            Console.WriteLine(getLength);
            Console.WriteLine(phraseToUppercase);
            Console.WriteLine(phraseIfContainsWord);
            Console.WriteLine(phraseIfContainsChar);
            Console.WriteLine(printPhraseChar);
            Console.WriteLine(printPhraseCharPosition);
            Console.WriteLine(phrase.Substring(1,3));
            */

            /**
            Working with Numbers
            */
            int num = 6;
            int numAbs = Math.Abs(-num);
            double numSq = Math.Pow(num, 2);
            double numSqrt = Math.Sqrt(numSq);

            /*
            Console.WriteLine(++ num);
            Console.WriteLine(-- num);
            Console.WriteLine(-num);
            Console.WriteLine(numAbs);
            Console.WriteLine(numSq);
            Console.WriteLine(numSqrt);
            Console.WriteLine(Math.Min(num, 11));
            Console.WriteLine(Math.Round(17.522));
            */

            // Console.WriteLine(num);

            /* Getting Input from User*/
            /*
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("hello "+ name);
            */
            /* Building a calculator*/
            
        }
        
    }
}