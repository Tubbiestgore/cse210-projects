using System;

public class Word
{
    private Scripture _scripture;
    private List<string> _scriptureList;    // Private variables. 
    private int _wordsRemoved = 0;

    public Word(Scripture scripture)
    {
        _scripture = scripture;
        _scriptureList = new List<string>();    // Gets variables from random generator.
        convertTextToList();
    }

    public void convertTextToList()
    {
        _scriptureList = _scripture.toString().Split(" ").ToList(); // Places variable into a list.

    }

    public void removeWords()
    {
        int numWordsRemoved = 3;
        int wordsRemoved = 0;

        do
        {
            int index = new Random().Next(0, _scriptureList.Count());
            if (_scriptureList[index].Contains('_') == false)
            {
                _scriptureList[index] = new string('_', _scriptureList[index].Length);
                wordsRemoved++;
                _wordsRemoved++;
            
                if ((_scriptureList.Count() - numWordsRemoved) <= _wordsRemoved && _wordsRemoved < (_scriptureList.Count() + 1)) // This whole functions design is to remove 3 words from the text and then to reaplce them with an underline.
                {
                    wordsRemoved = 3;
                }
            }    

        } while (wordsRemoved != numWordsRemoved);

    }

    public string toString()
    {
        return string.Join(" ", _scriptureList); 
    }

    public bool remainingWords()
    {
        bool val = false;

        foreach (string word in _scriptureList) 
        {
            if (word.Contains("_") == false)
            {
                val = true;
                break;
            }
        }

        return val;
    }


}