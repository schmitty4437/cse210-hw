using System;
using System.Collections.Generic;

public class Comment
{
    public string _name;
    public string _comment;
    public List<Comment> _comments = new List<Comment>();

    //Method adds new comments
    public void AddComment(string name, string comment)
    {
        Comment newComment = new Comment
        {
            _name = name,
            _comment = comment
        };
        _comments.Add(newComment);
    }

    //Method gets number of comments
    public void GetCommentCount()
    {
        Console.WriteLine(_comments.Count());
    }

    //Displays all the comments
    public void CommentDisplay()
    {
        //Iterate through to display each comment
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"User: {comment._name}");
            Console.WriteLine($"Comment: {comment._comment}");
            Console.WriteLine();
        }
    }
}