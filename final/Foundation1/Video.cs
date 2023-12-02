using System;
using System.Collections.Generic;
using static Comment;

public class Video
{
    public string _title;
    public string _author;
    public string _length;
    public int _seconds;
    public int _videoNumber;
    public Comment _comments;
    public List<Video> _videos = new List<Video>();

    //Method that adds all the video and comment information
    public void AddVideo(string title, string author, string length, params string[] namesAndComments)
    {

        //New Video instance
        Video video = new Video
        {
            _title = title,
            _author = author,
            _length = length,
        };

        //Changes video length to seconds
        TimeSpan duration = TimeSpan.Parse(video._length);
        video._seconds = (int)duration.TotalSeconds;

        // Initialize _comments only if it's null
        if (video._comments == null)
        {
            video._comments = new Comment();
        }

        //Adds comments to video
        for (int i = 0; i < namesAndComments.Length; i += 2)
        {
            video._comments.AddComment(namesAndComments[i], namesAndComments[i + 1]);
        }

        //Adds each video to the list of videos
        _videos.Add(video);
    }

    //Method displays all the videos and comments
    public void Display()
    {
        _videoNumber = 1;

        Console.WriteLine("    ****  Video and Comment Tracker  ****    ");
        Console.WriteLine();

        //Iterate through each video to display all the information
        foreach (Video video in _videos)
        {
            Console.WriteLine($"Video Information for video number {_videoNumber}:");
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Video length: {video._seconds} (seconds)");
            Console.WriteLine();

            Console.Write("Number of Comments: ");
            video._comments.GetCommentCount();

            Console.WriteLine("User Comments:");
            video._comments.CommentDisplay();

            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine();

            _videoNumber++;
        }
    }
}
