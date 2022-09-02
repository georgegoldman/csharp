using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("this is an array console app");

            int[] luckyNumbers = {4, 8, 15, 16, 23, 42};
            string[] friends = new string[5];
            friends[0] = "George";
            friends[1] = "goldman";
            Console.WriteLine(friends[0]+friends[1]);
        }
    }
}