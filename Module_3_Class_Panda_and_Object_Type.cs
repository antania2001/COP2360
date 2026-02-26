using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Division Program ===");

        Console.Write("Enter the first number: ");
        string input1 = Console.ReadLine();

        Console.Write("Enter the second number: ");
        string input2 = Console.ReadLine();

        Divide(input1, input2);
    }

    static void Divide(string value1, string value2)
    {
        try
        {
            int number1 = Convert.ToInt32(value1);
            int number2 = Convert.ToInt32(value2);

            int result = number1 / number2;

            Console.WriteLine($"Success! {number1} divided by {number2} equals {result}.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Format Error: One or both inputs were not valid whole numbers.");
            Console.WriteLine("Tip: Make sure you enter digits only, with no letters or symbols.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Math Error: Division by zero is not allowed.");
            Console.WriteLine("Tip: The second number must be something other than zero.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Overflow Error: One of the numbers is too large or too small to convert.");
            Console.WriteLine("Tip: Try entering a smaller number within the range of -2,147,483,648 to 2,147,483,647.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected Error: Something went wrong that wasn't covered by the other exceptions.");
            Console.WriteLine($"Details: {ex.Message}");
        }
    }
}
