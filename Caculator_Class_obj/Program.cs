using System;

namespace Caculator_Class_obj
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

            var calculator = new Caculator();

            calculator.Operation(function, a, b);
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
    }
}