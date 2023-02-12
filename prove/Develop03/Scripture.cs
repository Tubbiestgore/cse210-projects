using System;

public class Scripture
{
    private string _scriptureText;  // Private Variables.
    private Reference _scriptureReference;

    public Scripture (Reference scriptureReference, string scriptureText)
    {
        _scriptureReference = scriptureReference;   //Gets variables from random generator.
        _scriptureText = scriptureText;
    }

    public string toString()
    {
        return string.Format("{0}", _scriptureText);    // Sets variables for display.
    }
}