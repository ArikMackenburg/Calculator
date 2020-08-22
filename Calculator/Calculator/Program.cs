using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine( Add(2.2 , 4));
            var input = Console.ReadLine();
            //Console.Write(input.IndexOf('+'));

            if (input.IndexOf("+") > 0)
            {
                var numbersString = input.Split('+');
                double[] numbers = new double[2];
                numbers[0] = Convert.ToDouble(numbersString[0]);
                numbers[1] = Convert.ToDouble(numbersString[1]);
                Console.WriteLine(Add(numbers[0],numbers[1]));
                
            }

            if (input.IndexOf("-") > 0)
            {
                var numbersString = input.Split('-');
                double[] numbers = new double[2];
                numbers[0] = Convert.ToDouble(numbersString[0]);
                numbers[1] = Convert.ToDouble(numbersString[1]);
                Console.WriteLine(Sub(numbers[0], numbers[1]));

            }
            if (input.IndexOf("*") > 0)
            {
                var numbersString = input.Split('*');
                double[] numbers = new double[2];
                numbers[0] = Convert.ToDouble(numbersString[0]);
                numbers[1] = Convert.ToDouble(numbersString[1]);
                Console.WriteLine(Multiply(numbers[0], numbers[1]));

            }

            if (input.IndexOf("/") > 0)
            {
                var numbersString = input.Split('/');
                double[] numbers = new double[2];
                numbers[0] = Convert.ToDouble(numbersString[0]);
                numbers[1] = Convert.ToDouble(numbersString[1]);
                Console.WriteLine(Divide(numbers[0], numbers[1]));

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
