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
        _isHidden = false;
        Console.WriteLine(_text);
    }

    public void Hide()
    {
        _text = "___";
        _isHidden = true;
        Console.WriteLine(_text);
        //hide word
    }

    public bool IsHidden()
    {
        //check if word is shown or hidden, true or false
        if (_isHidden == false)
        {
            return false;
        }
        else 
        {
            return true;
        }
    }

    public string GetDisplayText()
    {
        // show word or underscore
        // bool txt = IsHidden();

        // if (txt == false)
        // {
            
        //     return _text;
        // }
        // else
        // {
        //     return "___";
        // }

        return _text;
    }
}