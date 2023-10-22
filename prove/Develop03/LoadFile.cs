using System;
using System.Collections.Generic;
using System.IO;

//Class: LoadFile
// Attributes:
// * _List<_scriptures> : string

// Behaviors:
// * LoadFile() : string
// * LoadScripturesFromFile(string : filePath)
// * GetScriptures() : string

public class LoadFile
{
    private List<string> _scriptures;

    public LoadFile()
    {
        //Initialize list
        _scriptures = new List<string>();
    }

    //Load scripture file
    public List<string> LoadScripturesFromFile(string filePath)
    {
        //Try-catch to help handle any errors
        try
        {
            //Read all lines and convert to list
            _scriptures = File.ReadAllLines(filePath).ToList();
        }
        catch (IOException ex)
        {
            //Display error message.
            Console.WriteLine($"Error reading file: {ex.Message}");
            _scriptures = new List<string>();
        }

        return _scriptures;
    }

    //Get scriptures list
    public List<string> GetScriptures()
    {
        return _scriptures;
    }
}