using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter arithmetic expression for example, 2+3-4):");
            string input = Console.ReadLine();

            int result = CalculateExpression(input);

            Console.WriteLine("Result is" + result);
        }

        static int CalculateExpression(string input)
        {
            int result = 0;
            int currentNumber = 0;
            char operation = '+';

            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    currentNumber = currentNumber * 10 + (c - '0');
                }
                else
                {
                    if (operation == '+')
                    {
                        result += currentNumber;
                    }
                    else if (operation == '-')
                    {
                        result -= currentNumber;
                    }

                    operation = c;
                    currentNumber = 0;
                }
            }

            if (operation == '+')
            {
                result += currentNumber;
            }
            else if (operation == '-')
            {
                result -= currentNumber;
            }

            return result;
        }
    }
}
