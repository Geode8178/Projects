using System;
internal class Program
{
    // Project Name: Assigning Values Using C#
    // Project Date: 02/07/2023
    // Project Description: Simple program used to learn how to assign values to variables using assignment operators.
    private static void Main(string[] args)
    {
        Console.Title = "Assigning Values";  // Sets the console title to "Assigning Values".

        int a, b; // Initializes two int variables "a" & "b".

        Console.Write("Assign Values: ");        // The following three lines of code display a message to the user 
        Console.Write("\t a = " + (a = 8));      // and sets the values of the two int variables "a" and "b" to
        Console.WriteLine("\t b = " + (b = 4));  // a = 8 and b = 4.

        Console.Write("\n\nAdd and Assign: ");                   // Displays Add and Assign:
        Console.Write( "\t a += b (8 += 4)\t a = " + (a += b));  // Displays a += b (8 += 4) a = 12. Sets a to 12.

        Console.Write( "\n\nSubtract and Assign: ");             // Displays Subtract and Assign: 
        Console.Write( "\t a -= b (12 - =4)\t a = " + (a -= b)); // Displays a -= b (12 += 4) a = 8. Sets a to 8.

        Console.Write( "\n\nMultipy and Assign: ");              // Displays Multiply and Assign:
        Console.Write("\t a *= b (8 *= 4)\t a = " + (a *= b));   // Displays a *= b (8 *= 4) a = 32. Sets a to 32.

        Console.Write( "\n\nDivide and Assign: ");               // Displays Divide and Assign:
        Console.Write("\t a /= b (32 /=4)\t a = " + (a /= b));   // Displays a /= b (32 /= 4) a = 8. Sets a to 8.

        Console.Write("\n\nModulus and Assign: ");               // Displays Modulus and Assign:
        Console.Write("\t a %= b (8 %= 4)\t a = " + (a %= b));   // Displays a %= b (8 %= 4) a = 0. Sets a to 0.

        Console.ReadKey();


    }
}