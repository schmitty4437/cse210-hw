using System;

class Program
{
    static void Main(string[] args)
    {

        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squared = SquareNumber(number);

        DisplayResult(name, squared);

        //Function to display welcome message
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        //Function to prompt user for name
        static string PromptUserName()
        {
            Console.Write("What is your name: ");
            string userName = Console.ReadLine();

            return userName;
        }

        //Function to prompt user for their favorite number
        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number: ");
            string temp = Console.ReadLine();
            int userNumber = int.Parse(temp);

            return userNumber;
        }

        //Function that calculates their number squared
        static int  SquareNumber(int squareNumber)
        {
            int x = squareNumber * squareNumber;

            return x;
        }

        //Function that displays users number and squared number
        static void DisplayResult(string userName, int squareNumber)
        {
            Console.WriteLine($"{userName}, the square of your numer is {squareNumber}");
        }
    }
}