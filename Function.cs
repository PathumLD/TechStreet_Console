using System;
namespace Function
{
    class program
    {
        static void Main(string[] args)
        {
            double num1 = 10;
            double num2 = 20;

            double total1 = Addition(num1, num2);
            Console.WriteLine(total1);

            double total2 = Substraction(num1, num2);
            Console.WriteLine(total2);

            double total3 = Multiplication(num1, num2);
            Console.WriteLine(total3);

            double total4 = Devidence(num1, num2);
            Console.WriteLine(total4);

            Console.ReadLine();
        }

        static double Addition(double x, double y)
        {
            double addition = x + y;
            return Addition;
        }

        static double Substraction(double x, double y)
        {
            double addition = x - y;
            return Substraction;
        }

        static double Multiplication(double x, double y)
        {
            double addition = x * y;
            return Multiplication;
        }

        static double Devidence(double x, double y)
        {
            double addition = x / y;
            return Devidence;
        }
    }
}