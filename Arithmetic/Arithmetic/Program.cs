using System;
internal class Program
{
    // Project Name: Arithmetic Using C#
    // Project Date: 02/07/2023
    // Project Description: Working with simple operators, arithmetic, increments, and decrements.
    private static void Main(string[] args)
    {
        Console.Title = "Arithmetic"; // Sets console title to "Arithmetic".

        int a = 8, b = 4; // Initialize two int variables "a" and "b" and sets them equal to 8 and 4 respectively.

        Console.WriteLine( "Addition:\t " + (a + b));        // Displays the value of a + b. (12)
        Console.WriteLine( "Subtraction:\t " + (a - b));     // Displays the value of a - b. (4)
        Console.WriteLine( "Multiplication:\t " + (a * b));  // Displays the value of a * b. (32)
        Console.WriteLine( "Division:\t " + (a / b));        // Displays the value of a / b. (2)
        Console.WriteLine("Modulus:\t " + (a % b));          // Displays the value of a % b. (0)

        Console.WriteLine("\nPostfix Increment:\t " + (a++));  // Displays the value of a post increment. (8)
        Console.WriteLine("Postfix Result.....\t " + a);       // Displays the reslt of a post increment. (9)

        Console.WriteLine( "\nPrefix Increment:\t " + (++b));  // Displays the value of b Prefix increment. (5)
        Console.WriteLine("Prefix Result......\t " + b);       // Displays the result of b Prefix Increment. (5)
        Console.ReadKey();


    }
}