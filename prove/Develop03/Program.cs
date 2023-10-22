using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string response;
        string location = "scriptures.txt";
        //Instance of LoadFile is created
        LoadFile loader = new LoadFile();

        Console.Clear();
        //Added menu to give user choice to use default file or load their own scriptures.
        Console.WriteLine("Welcome to Scritpure Memorization App");
        Console.WriteLine("You can upload your own file or load our default one. Make a Choice:");
        Console.WriteLine("1. Upload file");
        Console.WriteLine("2. Default file");

        //Loop to get the user to pick a correct selection
        do
        {
            //Get users choice
            Console.Write("What would you like to do? ");
            response = Console.ReadLine();
            switch(response)
            {
                case "1": 
            
                    Console.WriteLine("Type in file location (remember to replace \\ with /): ");
                    location = Console.ReadLine();
                    break;

                case "2":
                    location = "scriptures.txt";
                    break;
                
                default:
                    Console.WriteLine("Your choice was invalid. Please select either 1 or 2.");
                    break;
            }
        } while (response != "1" && response != "2");

        //Scripture is loaded
        List<string> scriptures = loader.LoadScripturesFromFile(location);

        //Verify if scripture was loaded
        if (scriptures.Count == 0)
        {
            Console.WriteLine("No scriptures found.");
            return;
        }

        // Select a random scripture
        Random random = new Random();
        string randomScriptureText = scriptures[random.Next(scriptures.Count)];

        // Reference & scripture text are split to help avoid hiding the reference info
        string[] parts = randomScriptureText.Split(new[] { ',' }, 2);

        if (parts.Length == 2)
        {
            //Program separates the reference and scripture texts
            string reference = parts[0].Trim();
            string scriptureText = parts[1].Trim();

            //Reference and text are used to create scripture objectt
            var scripture = new Scripture(reference, scriptureText);

            Console.Clear();
            //Display the version of scripture with hidden words
            Console.WriteLine(scripture.GetRenderedScripture());
            
            while (!scripture.AllWordsHidden())
            {
                //This will prompt the user to hit enter or quit until program ends
                Console.WriteLine("Press Enter to continue, or type 'quit' to exit.");
                string userInput = Console.ReadLine();

                //Exit program with quit
                if (userInput.ToLower() == "quit")
                    break;

                //Clear console each time user hits enter and words are hidden
                Console.Clear();
                //Hides at least 3 words
                scripture.HideWords(3);
                Console.WriteLine(scripture.GetRenderedScripture());
            }
        }

    }
}