using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a list of numbers, type 0 when finished. \n");
        List<int> numbers = new List<int>();
    
        int userNumber = -1;
        while (userNumber != 0)   
        {
        
            Console.Write("Enter number:");
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);
            
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }

        }
        
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");
        

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");


        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        // Stretch Challenge   

        Console.WriteLine($"The largest number is: {max}");

        int min = numbers[0];
        foreach (int number in numbers)
        {
            if (number < min && number > 0)
            {
                min = number;

            }
        }

        Console.WriteLine($"The smallest positive number is: {min}");

        Console.WriteLine("The sorted list is:");
        for (int i = 0; i < numbers.Count; i++)
        {
        Console.WriteLine(numbers[i]);
        }

    }
}