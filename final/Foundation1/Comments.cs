using System;

public class Comments
{
    public string _commentAuthor = "";
    public string _comment = "";

    public void Display()
    {   
        Console.WriteLine($"\nAuthor: {_commentAuthor}");
        Console.WriteLine($"Comment: {_comment}");
    }
}