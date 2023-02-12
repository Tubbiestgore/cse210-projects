using System;

public class Reference
{
    private string _book;
    private string _chapter;    // Private Variables
    private string _verse;

    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter; //Gets variables from random generator.
        _verse = verse;
    }

    public string toString()
    {
        return string.Format("{0} {1}{2}", _book, _chapter, _verse); // Sets as string for display.
    }
}
