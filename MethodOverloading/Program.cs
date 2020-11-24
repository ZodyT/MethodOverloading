using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(5, 10));
            Console.WriteLine();
            Console.WriteLine(Add(5.5, 10.3));
            Console.WriteLine();
            Console.WriteLine(Add(1, 0, false));
        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public static string Add(int num1, int num2, bool result)
        {
            int answer = num1 + num2;
            return result ? $"Value: {answer}" : answer == 1 ? $"Value: {answer,0:c} dollar" : $"Value: {answer,0:c} dollars";

            
        }
    }
}
