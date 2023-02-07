using System;
    class Program
{
       static void Main(string[] args)
       { 
        Console.BackgroundColor = ConsoleColor.Black; // Use to adjust the background color for the text in the console window.
        Console.Title = "Variables";                  // Adjusts the title for the console app window to "Variables"
        char letter; letter = 'A';                    // Initializes the char variable "letter" and sets it to 'A'.
        int number; number = 100;                     // Initializes the int variable "number" and sets it to 100.
        float body; body = 98.6f;                     // Initializes the float variable "body" and sets it to 98.6f.
        double pi = 3.14159;                          // Initializes the double variable "pi" and sets it to 3.14159.
        decimal sum = 1000.00m;                       // Iniitlaizes the decimal variable "sum" and sets it to 1000.00m.
        bool flag = false;                            // Initializes the bool variable "flag" and sets it to false.
        string text = "C# Practice";                  // Initializes the string variable "text" and sets it to "C# Practice".

        Console.WriteLine( "char letter:\t" + letter );  // Displays the value of the variable "letter".
        Console.WriteLine( "int number:\t" + number );   // Displays the value of the variable "number".
        Console.WriteLine( "float body:\t" + body );     // Displays the value of the variable "body".
        Console.WriteLine( "double pi:\t" + pi );        // Displays the value of the variable "pi".
        Console.WriteLine( "decimal sum:\t" + sum );     // Displays the value of the variable "sum".
        Console.WriteLine( "bool flag:\t" + flag );      // Displays the value of the variable "flag".
        Console.WriteLine( "string text:\t" + text );    // Displays the value of the variable "text".

        Console.ReadKey();  // Console stays open until a key is pressed.

    }
}