using System;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //int to double
            Console.WriteLine("int to double");

            int number = 10;
            double number2 = number;
            Console.WriteLine(number);
            Console.WriteLine(number2);
            Console.WriteLine();


            //double to int
            Console.WriteLine("double to int");

            double number3 = 15.6;
            int number4 = (int)number3;
            Console.WriteLine(number3);
            Console.WriteLine(number4);
            Console.WriteLine();



            //User Input for String
            Console.WriteLine("User input for String");

            String name;
            Console.Write("Please enter your name : ");
            name = Console.ReadLine();

            Console.WriteLine("Your name is " + name);
            //Console.ReadLine();
            //Console.WriteLine();



            //User Input for int
            Console.WriteLine("User input for int");

            Console.Write("Please enter your age : ");
            int age = Int16.Parse(Console.Read());

            Console.WriteLine("Your age is : " + age);
            Console.WriteLine();
            //Console.ReadLine();


            //Operators

            int number1 = 10;
            int number2 = 20;

            Console.WriteLine(number1 + number2);
            Console.WriteLine(number1 - number2);
            Console.WriteLine(number1 * number2);
            Console.WriteLine(number1 / (double)number2);
            Console.WriteLine(number1 % number2);
            Console.WriteLine(number1++);
            Console.WriteLine(number1--);

            //Console.ReadLine();


            // if else statement

            double marks;
            Console.WriteLine('Enter your marks : ');
            marks = Double.Parse(Console.ReadLine());

            if (marks >= 75)
            {
                Console.WriteLine("Your grade is A");
            }
            else if(marks >= 65)
            {
                Console.WriteLine("Your grade is B");
            }
            else if (marks >= 50)
            {
                Console.WriteLine("Your grade is C");
            }
            else if (marks >= 35)
            {
                Console.WriteLine("Your grade is S");
            }
            else 
            {
                Console.WriteLine("Your grade is F");
            }


            // Switch Case

            int num;
            Console.Write("Enter a number between 1-7 : ");
            num = Int16.Parse(Console.ReadLine());

            switch (num)
            {
                case 1: 
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default: Console.WriteLine("Invalid Day");
                    break;

            }


            //While loop

            int count = 0;

            while (count <= 100)
            {
                Console.WriteLine(count);
                count++;
            }

            //Example

            int count = 1;
            double marks;
            double total = 0;
            double average;

            while (count <= 10)
            {
                Console.Write("Enter the marks of student : " + count);
                marks = Double.Parse(Console.ReadLine());

                total += marks;
                count++;
            }

            average = total / 10;
            Console.WriteLine("Total is " + total);
            Console.WriteLine("Average is " + average);
            


            Console.ReadLine();



        }
    }
}
