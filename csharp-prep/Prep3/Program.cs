using System;

class Program
{
    static void Main(string[] args)
    {
        //First step
        //Console.Write("Enter a magic number: ");
        //string magic = Console.ReadLine();
        //int number = int.Parse(magic);

        //Random number generator
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,101);

        int guess = 0;
        string guessText = "";
       
       //Ask user for their number
        Console.Write("Guess a number: ");
        guessText = Console.ReadLine();
        guess = int.Parse(guessText);
        int times = +1;

        //While loop that continues to ask for new number if wrong
        while (guess != number)
        {
        //if statement to guess higher or lower
            if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }

            Console.Write("Guess a number: ");
            guessText = Console.ReadLine();
            guess = int.Parse(guessText);

            times++;
        }

        if (guess == number)
        {
            Console.WriteLine("You guessed correctly!");
            Console.WriteLine($"It took you {times} guesses.");
        }
    }
}