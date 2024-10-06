using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text; 
        _isHidden = false;
        //set initial visible
    }

    public void Show()
    {
        Console.WriteLine(_text);
    }

    public void Hide()
    {
        _text = "___";
        Console.WriteLine(_text);
        //hide word
    }

    public bool IsHidden()
    {
        //check if word is shown or hidden, true or false
        if (_text != "___")
        {
            _isHidden = false;
            return false;
        }
        else 
        {
            _isHidden = true;
            return true;
        }
    }

    public string GetDisplayText()
    {
        // show word or underscore
        if (IsHidden() == false)
        {
            
            return _text;
        }
        else
        {
            return "___";
        }
    }
}