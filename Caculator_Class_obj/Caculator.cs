using System;

namespace Caculator_Class_obj
{
    public class Caculator
    {
        public void Operation(int function, int a , int b)
        {
            int result = 0; 
            
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
        
        
        public void PrintResult(int result)
        {
            Console.WriteLine($"Final result is: {result}");
        }
        
        public int Sum(int c, int d)
        {
            return c + d;
        }
        
        public int Subtract(int c, int d)
        {
            return c - d;
        }
        
        public int Multiple(int c, int d)
        {
            return c * d;
        }
        
        public int Device(int c, int d)
        {
            return c / d;
        }
    }
}