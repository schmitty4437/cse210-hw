using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int numberList = -1;
        List<int> numbers = new List<int>();


        while (numberList != 0)
        {
            Console.Write("Enter a number (press 0 to stop): ");
            string entry = Console.ReadLine();
            numberList = int.Parse(entry);

            if (numberList != 0)
            {
                numbers.Add(numberList);
            }

        }

        //foreach loop for the sum of numbers in list
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;  
        }

        //Compute the average
        int total = numbers.Count();
        float average = ((float)sum) / total;

        int maxNum = 0;
        foreach (int number in numbers)
        {
            if (maxNum < number)
            {
                maxNum = number;
            }
        }

        //Smallest positive number
        int minNum = numbers.Where(i => i > 0).Min();

        //Sum, total, average, max, min of all numbers in list without loops
        // int sum = numbers.Sum();
        // int total = numbers.Count();
        // float average = ((float) sum)/total ;
        // int max = numbers.Max();
        // int ? min = numbers(i => i > 0 ? e : null).Min();

        
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maxNum}");
        Console.WriteLine($"The smallest positive number is: {minNum}");

        //Sort list from lowest to highest
        numbers.Sort();

        Console.WriteLine("The sorted list is: ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        
    }
}