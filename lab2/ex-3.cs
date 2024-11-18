using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please Enter the Mark");

        int mark = int.Parse(Console.ReadLine());

        PrintStundentRate(mark);
        Console.ReadKey();

    }

    static void PrintStundentRate(int grade)
    {
        if (grade >= 90)
        {
            Console.WriteLine("Excellent");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("Very Good");

        }
        else if (grade >= 70)
        {
            Console.WriteLine("Good");

        }
        else if (grade >= 60)
        {
            Console.WriteLine("Average");

        }
        else
        {
            Console.WriteLine("Poor");
        }
    }
}


