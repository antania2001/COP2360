using System;

class Program
{
    // The Main method serves as the entry point of the program, allowing users to input two numbers and attempt division while providing an option to repeat the process.
    static void Main()
    {
        bool keepRunning = true;

        while (keepRunning)
        {
            Console.WriteLine("=== Division Program ===");

            Console.Write("Enter the first number: ");
            string input1 = Console.ReadLine();

            Console.Write("Enter the second number: ");
            string input2 = Console.ReadLine();

            Divide(input1, input2);

            Console.Write("\nWould you like to try again? (y/n): ");
            string answer = Console.ReadLine().ToLower();

            if (answer != "y")
            {
                keepRunning = false;
                Console.WriteLine("Exiting program...");
            }

            Console.WriteLine(); // spacing for readability
        }
    }
// The Divide method takes two string inputs, attempts to convert them to integers, and performs division while handling potential exceptions.
    static void Divide(string value1, string value2)
    {
        try
        {
            int number1 = Convert.ToInt32(value1);
            int number2 = Convert.ToInt32(value2);

            int result = number1 / number2;

            Console.WriteLine($"Success! {number1} divided by {number2} equals {result}.");
        }
        // Catching FormatException to handle cases where the input cannot be converted to an integer.
        catch (FormatException)
        {
            Console.WriteLine("Format Error: One or both inputs were not valid whole numbers.");
            Console.WriteLine("Tip: Make sure you enter digits only, with no letters or symbols.");
        }
        // Catching DivideByZeroException to handle division by zero errors.
        catch (DivideByZeroException)
        {
            Console.WriteLine("Math Error: Division by zero is not allowed.");
            Console.WriteLine("Tip: The second number must be something other than zero.");
        }
        // Note: OverflowException is unlikely in this specific case since we're only converting to int, but it's included for completeness.
        catch (OverflowException)
        {
            Console.WriteLine("Overflow Error: One of the numbers is too large or too small to convert.");
            Console.WriteLine("Tip: Try entering a smaller number within the range of -2,147,483,648 to 2,147,483,647.");
        }
    }
}
