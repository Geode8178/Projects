using System;
internal class Program
{
    // Project Name: Comparing Values Using C#
    // Project Date: 02/07/2023
    // Project Description: Simple program for running equality and inequality statements.
    private static void Main(string[] args)
    {
        Console.Title = "Value Comparisons";  // Sets the console title to Value Comparisons.

        int nil = 0, num = 0, max = 1;  // Initializes three int variables nil, num, and max. Sets them to 0, 0, and 1 respectively.
        char cap = 'A', low = 'a';      // Initializes two char variables cap and low and sets them to A and a respectively.

        Console.Write( "Equality:" );                           // Displays Equality:
        Console.Write( "\t (0 == 0) : " + (nil == num));       // Displays (0 == 0), checks the equality, then displays true.
        Console.Write( "\n\t\t (A == a) : " + (cap == low));   // Displays ( A == a), checks the equality, then displays false.

        Console.Write( "\n\nInequailty:" );                     // Displays Inequality:
        Console.Write( "\t (0 != 1) : " + (nil != max));        // Displays (0 != 1), checks the equality, then displays true.

        Console.Write( "\n\nGreater: " );                       // Displays Greater:
        Console.Write( "\t (0 > 1) : " + (nil > max));          // Displays ( 0 > 1), checks the equality, then displays false.

        Console.Write("\nLess:");                               // Displays Less:
        Console.Write("\t\t (0 < 1) : " + (nil < max));         // Displays (0 < 1), checks the equality, then displays true.

        Console.Write( "\n\nGreater/Equal:" );                  // Displays Greater/Equal:
        Console.Write( "\t (0 >= 0) : " + (nil >= num));        // Displays (0 >= 0), checks the equality, then displays true.

        Console.Write( "\nLess or Eqaul:" );                  // Displays Less or Equal:
        Console.Write( "\t (1 <= 0) : " + (max <= nil));        // Displays (1 <= 0), checks the equality, then displays false.

        Console.ReadKey();
    }
}