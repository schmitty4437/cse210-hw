using System;

//Class: Prompt
// Attributes:
// * _prompts : List<Prompt>

// Behaviors:
// * _generatePrompt()

class Prompt
{
    //List that contains all the prompt questions.
    public List<String> _prompts = new List<String>
    {
        "Did you help someone today?",
        "What did you do for family time?",
        "What is something new you learned today?",
        "What would you have done differently today?",
        "How did you feel after praying and reading scriptures?",
        "What was a memorable emotion you had today?"
    };

    

    //Object that generates random question from the prompt list.
    //It gets a random number from the number of elements contained in the list.
    public string GeneratePrompt()
    {
        Random r = new Random();
        int index = r.Next(_prompts.Count);
        string randomString = _prompts[index];
        return randomString;
    }
}