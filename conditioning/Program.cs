using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditioning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conditioning console app");
            bool isMale = false;
            bool isTall = true;

            if(isMale && isTall)
            {
                Console.WriteLine("male");
            } else
            {
                Console.WriteLine("female and short or you are one of the both");
            }
        }
    }
}