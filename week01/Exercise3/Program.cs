using System;

class Program
{
    static void Main(string[] args)
    {
        // string response;
        // do
        // {
        //     Console.WriteLine("What is the magic number");
        //     string magic = Console.ReadLine();
        //     int number = int.Parse(magic);
        //     Console.WriteLine($"Debug: The number is {number}");
        //     Console.Write("Do you want to continue? ");
        //     response = Console.ReadLine();
        // } while (response == "yes");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        int response = -1;

        while (response != number)
        {
            Console.WriteLine($"The rng is {number}");
            Console.WriteLine("What is your guess? ");
            response = int.Parse(Console.ReadLine());

            if (number > response)
            {
                Console.WriteLine("Guess Higher");
            }

            else if (number < response)
            {
                Console.WriteLine("Guess Lower");
            }

            else
            {
                Console.WriteLine("You guessed it");
            }
        }

    }
}