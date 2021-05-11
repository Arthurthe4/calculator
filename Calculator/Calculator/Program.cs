using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables and then initialize to zero.
            int number1 = 0;
            int number2 = 0;

            // Display title as the C# console calculator app.
            Console.WriteLine("Console Calculator\r");
            Console.WriteLine("------------------\n");

            // Ask the user to type the first number.
            Console.WriteLine("Type a number, and then press Enter");
            number1 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to type the second number.
            Console.WriteLine("Type another number, and then press Enter");
            number2 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to choose an option.
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Substract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option ?");

            // Use a switch statement to do the math.
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {number1} + {number2} = " + (number1 + number2));
                    break;

                case "s":
                    Console.WriteLine($"Your result: {number1} - {number2} = " + (number1 - number2));
                    break;

                case "m":
                    Console.WriteLine($"Your result: {number1} * {number2} = " + (number1 * number2));
                    break;
                case "d":
                    while (number2 == 0)
                    {
                        Console.WriteLine("Enter a non-zero divisor: ");
                        number2 = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine($"Your result: {number1} / {number2} = " + (number1 / number2));
                    break;
            }

            // Wait for the user to respond befor closing.
            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
}
