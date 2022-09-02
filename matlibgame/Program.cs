using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatLibGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string color, pluralNoun, celebrity;

            Console.Write("enter a color: ");
            color = Console.ReadLine();

            Console.Write("enter a plura noun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("this is the mad lib game");
            Console.WriteLine("Rose are "+color);
            Console.WriteLine(pluralNoun+"  are blue");
            Console.WriteLine("I love "+celebrity);
            
        }
    }
}