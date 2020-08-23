using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator!");
            Console.WriteLine("Example");
            Console.WriteLine("Input: 2+2");
            Console.WriteLine("Result: 2+2 = 4");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("--------------------");
                var input = Console.ReadLine();
                

                if (input.IndexOf("+") > 0)
                {
                    var numbersString = input.Split('+');
                    double[] numbers = new double[2];
                    numbers[0] = Convert.ToDouble(numbersString[0]);
                    numbers[1] = Convert.ToDouble(numbersString[1]);
                    Console.WriteLine(input + " = " + Add(numbers[0], numbers[1]));

                }

                if (input.IndexOf("-") > 0)
                {
                    var numbersString = input.Split('-');
                    double[] numbers = new double[2];
                    numbers[0] = Convert.ToDouble(numbersString[0]);
                    numbers[1] = Convert.ToDouble(numbersString[1]);
                    Console.WriteLine(input + " = " + Sub(numbers[0], numbers[1]));

                }
                if (input.IndexOf("*") > 0)
                {
                    var numbersString = input.Split('*');
                    double[] numbers = new double[2];
                    numbers[0] = Convert.ToDouble(numbersString[0]);
                    numbers[1] = Convert.ToDouble(numbersString[1]);
                    Console.WriteLine(input + " = " + Multiply(numbers[0], numbers[1]));

                }

                if (input.IndexOf("/") > 0)
                {
                    var numbersString = input.Split('/');
                    double[] numbers = new double[2];
                    numbers[0] = Convert.ToDouble(numbersString[0]);
                    numbers[1] = Convert.ToDouble(numbersString[1]);
                    Console.WriteLine(input + " = " + Divide(numbers[0], numbers[1]));

                }
            }
        }

        static double Add(double x, double y)
        {
            double result = x + y;
            return result;
        }
        static double Sub(double x, double y)
        {
            double result = x - y;
            return result;
        }
        static double Multiply(double x, double y)
        {
            double result = x * y;
            return result;
        }
        static double Divide(double x, double y)
        {
            double result = x / y;
            return result;
        }
    }
}
