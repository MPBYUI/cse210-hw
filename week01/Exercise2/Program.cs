using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.WriteLine("What is your grade number? ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);
        Console.WriteLine(number);

        if (number >= 90)
        {
            Console.WriteLine("Your Grade Is A");
            Console.WriteLine("You passed the class.");
        }
        else if (number >= 80)
        {
            Console.WriteLine("Your Grade Is B");
            Console.WriteLine("You passed the class.");
        }
        else if (number >= 70)
        {
            Console.WriteLine("Your Grade Is C");
            Console.WriteLine("You passed the class.");
        }
        else if (number >= 60)
        {
            Console.WriteLine("Your grade is D");
            Console.WriteLine("You failed the class.");
        }
        else if (number < 60)
        {
            Console.WriteLine("Your Grade Is F");
            Console.WriteLine("YOU LOSE");
        }
    }
}

// 
// A >= 90
// B >= 80
// C >= 70
// D >= 60
// F < 60
// 