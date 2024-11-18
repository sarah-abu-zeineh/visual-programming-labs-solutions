using System;

class Program
{
    static void Main()
    {
        float[,] numbers = new float[2, 5];
        float summation = 0;

        Console.WriteLine("Please Enter 10 float numbers:");

        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                string stringNumber = Console.ReadLine();
                float number = Convert.ToSingle(stringNumber);

                numbers[i, j] = number;

                summation += number;

            }
        }

        float avg = summation / (2 * 5);
        // summation / numbers.Length;


        Console.WriteLine("Summation:" + summation);
        Console.WriteLine("Average: " + avg);

        Console.ReadKey();
    }
}

