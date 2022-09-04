using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("exception handling"); 

            try
            {
                Console.Write("enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1/num2);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("please enter a valid input!");
            }

        }
    }
}