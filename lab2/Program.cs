using System;

namespace lab1_extra_material
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------------------------------------------------------------------------//
            // Data types

            // Integer data type
            int number1 = 5;  // Example of integer data type

            // Float, double, and decimal data types
            float number2 = 5.75f;    // 'F, f' suffix for float literals
            double number3 = 9.99;    // No suffix needed for double literals
            decimal number4 = 1000.99m;  // 'M, m' suffix for decimal literals

            // String data type
            string text = "Hello, World!"; // String is enclosed in double quotes

            // Char data type
            char letter = 'A'; // Char is enclosed in single quotes

            // Boolean data type
            bool isCSharpEasy = true;  // Boolean can be either true or false

            //------------------------------------------------------------------------------//
            // Conversion between data types

            // String to int using Parse and Convert
            string stringNumber = "123";
            int parsedNumber = int.Parse(stringNumber);  // Parse string to int
            int convertedNumber = Convert.ToInt32(stringNumber);  // Convert String to int

            // String to double using Parse and Convert
            string stringDouble = "45.67";
            double parsedDouble = double.Parse(stringDouble);  // Parse string to double
            double convertedDouble = Convert.ToDouble(stringDouble);  // Convert String to double

            // String to decimal using Parse and Convert
            string stringDecimal = "100.99";
            decimal parsedDecimal = decimal.Parse(stringDecimal);  // Parse string to decimal
            decimal convertedDecimal = Convert.ToDecimal(stringDecimal);  // Convert string to decimal

            // String to a boolean
            string stringBool = "false";
            bool stringToBool = bool.Parse(stringBool); // Parse string to bool false
            bool convertedBool = Convert.ToBoolean(stringBool); // Convert String to bool

            //------------------------------------------------------------------------------//
            // Arithmetic operations

            int firstNumber = 10;
            int secondNumber = 3;

            // Addition
            int sum = firstNumber + secondNumber;

            // Subtraction
            int difference = firstNumber - secondNumber;

            // Multiplication
            int product = firstNumber * secondNumber;

            // Division
            double quotient = (double)firstNumber / secondNumber; // Cast to double for decimal result -> 3.33333
            int divisionResult = firstNumber / secondNumber; // Integer division -> 3

            // Remainder
            int remainder = firstNumber % secondNumber;

            // Output arithmetic results
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Quotient with casting: {quotient}");
            Console.WriteLine($"Integer Division Result: {divisionResult}");
            Console.WriteLine($"Remainder: {remainder}");


            // Use \n or Environment.NewLine to insert new lines within strings.
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine();
            Console.Write('\n');

            //------------------------------------------------------------------------------//
            //Input Ooutput Commands

            // Output Command without moving to the next line
            Console.Write("Please Enter Your Name:\t");

            // Read the user input
            string userName = Console.ReadLine();

            // This command takes the full line 
            // Concatenate a string for the output
            Console.WriteLine("Hello, " + userName + "! Welcome to the program.");
            // Using string interpolation for output
            Console.WriteLine($"Hello, {userName}! Welcome to the program.");

            // Wait for user input to close the console window
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
