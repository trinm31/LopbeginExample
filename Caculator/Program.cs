using System;

namespace Caculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, result = 0, function;
            Welcome();
            // get value
            a = GetInput("Let's input a");
            b = GetInput("Let's input b");

            function = GetInput("Let's input 1 - sum; 2 - subtract; 3 - multiple; 4 - device");

            switch (function)
            {
                case 1: 
                    result = Sum(a, b);
                    break;
                case 2:
                    result = Subtract(a, b);
                    break;
                case 3:
                    result = Multiple(a, b);
                    break;
                case 4:
                    result = Device(a, b);
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
            
            PrintResult(result);
        }

        public static void Welcome()
        {
            Console.WriteLine("welcome to my calculator");
            Console.WriteLine("-------------------------");
        }
        public static int GetInput(string text) // "hello world"
        {
            Console.WriteLine(text); // in ra man hinh
            var output = Convert.ToInt32(Console.ReadLine());
            return output;
        }
        public static void PrintResult(int result)
        {
            Console.WriteLine($"Final result is: {result}");
        }
        public static int Sum(int c, int d)
        {
            return c + d;
        }
        public static int Subtract(int c, int d)
        {
            return c - d;
        }
        public static int Multiple(int c, int d)
        {
            return c * d;
        }
        public static int Device(int c, int d)
        {
            return c / d;
        }
    }
}