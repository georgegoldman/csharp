using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            SayHi("george");
            SayHi("john");
            SayHi("georgegoldman");
            */
            int cubedNumber = cube(5);
            Console.WriteLine(cubedNumber);
        }        
        static void SayHi(string name)
        {
            Console.WriteLine("Hi "+name+"!");
        }
        static int cube(int num)
        {
            int result = num * num * num;
            return result;
        }
    }
}