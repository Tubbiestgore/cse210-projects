using System;

public class Video
{
    public string _title = "";
    public string _author = "";
    public int _length = 0;
    public int _totalComments = 0;
    public List<Comments> _comments = new List<Comments>();
    public void Display()
    {
        Console.WriteLine($"{_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Total Length: {_length} seconds");
        Console.WriteLine($"Total Comments: {_totalComments}");

        foreach (Comments comment in _comments)
        {   
            comment.Display();
        }
    }
}