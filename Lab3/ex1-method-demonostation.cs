using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5, num2 = 15;

            Console.WriteLine($"Values for num1 and num2 efore the swapping\n " +
                $"num1 = {num1}, num2 = {num2}");
            swap(ref num1, ref num2);
            Console.WriteLine($"Values for num1 and num2 After the swapping\n " +
                $"num1 = {num1}, num2 = {num2}");
            /*            Add(num1, num2, out int result);
            */
            /*            Console.WriteLine($"The Summation of {num1} + {num2} = {result}");
            */
            Console.ReadKey();
        }

        /*static void Add(int a, int b, out int result) {
            result = a + b;
        }*/

        static void swap(ref int num1, ref int num2) {
            //num1 = 5, num2 = 15
            int temp = num1;  // temp -> 5
            num1 = num2; //num1 = 15
            num2 = temp; //num2 = 5
        }
    }
}
