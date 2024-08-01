using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace Study
{
    class studyy
    {
        static void Main(string[] args)
        {
            //study methods
            Add();
            Add();
            Add2(20, 30);
            Add3(25);
            int number1 = 20;
            int number2 = 35;
            var result2 = Add4(ref number1, number2);
            Console.WriteLine(result2);
            Console.WriteLine(number1);
            int number3;
            var result3 = Add5(out number1, number2);
            Console.WriteLine(number1);
            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply2(2, 4, 5));
            Console.WriteLine(Add6(1, 2, 3, 4, 5, 6, 8));
            Console.WriteLine();

            Console.ReadLine();

        }
        static void Add()
        {
            Console.WriteLine("Added!");

        }
        static void Add2(int number1, int number2)
        {
            //parameter methods
            var result = number1 + number2;
            Console.WriteLine(result);

        }
        static void Add3(int number1, int number2 = 45)
        {
            //default methods
            var result = number1 + number2;
            Console.WriteLine(result);
        }

        // ref keyword
        static int Add4(ref int number1, int number2)
        {

            number1 = 15;
            return number1 + number2;

        }

        //out keyword
        static int Add5(out int number1, int number2)
        {

            number1 = 65;
            return number1 + number2;

        }

        //method overloading
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply2(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        //params keyword
        static int Add6(params int[] numbers)
        {
            return numbers.Sum();
        }



    }
}
