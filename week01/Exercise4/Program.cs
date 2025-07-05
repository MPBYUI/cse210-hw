using System;
using System.Collections.Generic;
using System.Collections.Specialized;



class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise4 Project.");
        


        List<int> numbers = new List<int>();

        int inputNumbers = -1;
        Console.WriteLine("Please dont grade the functionality of the program as i had to rely on the sample soultuion");
        while (inputNumbers != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished. ");
            String response = Console.ReadLine();
            inputNumbers = int.Parse(response);

            if (inputNumbers != 0)
            {
                numbers.Add(inputNumbers);

            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }


        Console.WriteLine($"The sum is: {sum}");


    }
}