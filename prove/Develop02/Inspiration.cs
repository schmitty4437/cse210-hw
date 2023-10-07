using System;

class Inspiration
{
    public List<String> _inspiration = new List<String>();

    //Load file with inspiration quotes and adding them to _inspiration list
    public void InspirationQuotes()
    {
        string filePath = @"inspirationQuotes.txt";

        using(StreamReader reader = new StreamReader(filePath))
        {
            //Loop through to add all lines to the _inspiration list
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                _inspiration.Add(line);
            }
        }
    }

    //Randomizing the inspiration list
    public string GenerateInspiration()
    {
        Random random = new Random();
        int index = random.Next(_inspiration.Count);
        string randomInspiration = _inspiration[index];
        return randomInspiration;
    }
}
