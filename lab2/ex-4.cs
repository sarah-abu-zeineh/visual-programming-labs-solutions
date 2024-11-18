using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[10];

        Console.WriteLine("Please Enter 10 integer values:");

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        string countingResult = CountEvenOdd(numbers);

        Console.WriteLine(countingResult);
        Console.ReadKey();
    }

    static string CountEvenOdd(int[] numbers)
    {
        int evenCounter = 0;
        int oddCounter = 0;

        foreach (int num in numbers)
        {
            if (num % 2 == 0)
            {
                evenCounter++;
            }
            else
            {
                oddCounter++;
            }
        }

        string result = $"Odd Counter = {oddCounter}\nEven Counter = {evenCounter}";

        return result;
    }
}
