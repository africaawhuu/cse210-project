using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise 5 Project.");
        
        // Display the welcome message
        DisplayWelcome();

        // Ask for the user's name
        string name = PromptUserName();

        // Ask for the user's favorite number
        int number = PromptUserNumber();

        // Square the number
        int squaredNumber = SquareNumber(number);

        // Display the final result
        DisplayResult(name, squaredNumber);
    }

    // Displays the welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Asks for and returns the user's name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    // Asks for and returns the user's favorite number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    // Squares the number and returns the result
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Displays the user's name and squared number
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}