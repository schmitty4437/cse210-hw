using System;

class Program
{
    static void Main()
    {
        string choice;

        Journal myJournal = new Journal();
        Prompt myPrompt = new Prompt();
        Inspiration myInspiration = new Inspiration();
        myInspiration.InspirationQuotes();

        do
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Inspiration");
            Console.WriteLine("3. Display");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Load");
            Console.WriteLine("6. Quit");

            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    //Generate and store prompt question and user response
                    string promptQuestion = myPrompt.GeneratePrompt();
                    Console.WriteLine(promptQuestion);
                    Console.Write("> ");
                    string userAnswer = Console.ReadLine();

                    //New entry to make sure it adds a new line each time
                    Entry myEntry = new Entry();

                    //Add new entries to Entry class and Journal list
                    myEntry.addEntry(promptQuestion, userAnswer);
                    myJournal.addEntry(myEntry);
                    Console.WriteLine(myEntry._response);

                    break;
                
                case "2":
                    string inspirationQuote = myInspiration.GenerateInspiration();
                    Console.WriteLine(inspirationQuote);
                    break;

                case "3":
                    myJournal.Display();
                    break;

                case "4":
                    myJournal.saveToFile();
                    
                    break;

                case "5":
                    myJournal.loadFromFile();
                    break;

                case "6":
                    Environment.Exit(0);
                    break;

                default:
                    //Changed color to red to show there is a mistake/error
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your choice was invalid. Please select an option between 1-6.");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        } while (choice != "6");
    }
}