using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            double secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(Calculate(firstNumber, @operator, secondNumber));

            static double Calculate(double firstNumber, string @operator, double secondNumber)
            {
                double result = 0;
                switch (@operator)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                            break;
                    case "-":
                        result = firstNumber - secondNumber;
                        break;
                    case "*":
                        result = firstNumber * secondNumber;
                        break;
                    case "/":
                        result = firstNumber / secondNumber;
                        break;
                }
                return result;

            }
        }
    }
}
