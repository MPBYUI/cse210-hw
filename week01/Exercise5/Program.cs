using System;

class Program
{
    
        static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        return number;
    }


    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise5 Project.");
        WelcomeMessage();
        string userName = PromptUserName();
        int number = PromptUserNumber();
        float square = number * number;
        Console.WriteLine($"Brother {userName}, the square of your number is {square}");


    }
}