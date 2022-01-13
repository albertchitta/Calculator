using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an operator followed by a series of numbers (Ex. * 1,2,3):");
            string input = Console.ReadLine();
            string[] op = input.Split(" ");
            string[] numbers = op[1].Split(",");

            int result;

            if (op[0] == "*")
            {
                result = 1;
            }
            else if (op[0] == "/")
            {

            }
            else if (op[0] == "+")
            {

            }
            else if (op[0] == "-")
            {

            }

            foreach (var number in numbers)
            {
                int intNumber = int.Parse(number);
                if (op[0] == "*")
                {
                    result *= intNumber;
                }
                else if (op[0] == "/")
                {
                    result /= intNumber;
                }
                else if (op[0] == "+")
                {
                    result += intNumber;
                }
                else if (op[0] == "-")
                {
                    result -= intNumber;
                }
            }

            Console.WriteLine(result);
        }
    }
}
