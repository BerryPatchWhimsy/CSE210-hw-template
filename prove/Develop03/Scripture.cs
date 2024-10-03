using System;

public class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        //_words = text;   //?
    }

    public void HideRandomWord(int numberToHide)
    {
        

    }

    public string GetDisplayText()
    {
        return "";
    }

    public bool IsCompletelyHidden()
    {
        return true;
    }

}