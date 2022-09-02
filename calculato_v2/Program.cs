using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("version 2 calculator init");

            Console.Write("enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("enter an operator: ");
            char op = Convert.ToChar(Console.ReadLine());

            Console.Write("enter a numbe: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == '+')
            {
                Console.WriteLine(num1 + num2);
            }
            else if (op == '-')
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == '/')
            {
                Console.WriteLine(num1 / num2);
            }
            else if (op == '*')
            {
                Console.WriteLine(num1 * num2);
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }


        }
    }
}