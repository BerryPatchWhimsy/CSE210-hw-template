using System;
using System.Runtime.InteropServices;
public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = ""; 
        _isHidden = true;
        //set initial visible
    }

    public void Hide()
    {
        //hide word
    }


    public void Show()
    {
        //show word
    }

    public bool IsHidden()
    {
        //check if word is shown or hidden, true or false
        return true;
    }

    public string GetDisplayText()
    {
        // show word or underscore
        return "";
    }
}