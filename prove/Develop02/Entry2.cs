using System;

public class Entry2
{
    DateTime _date = DateTime.Today;
    
    public string _showPrompt;
    public string _promptResponse;

    public void Display()
    {
        Console.WriteLine($"{_date}");
        Console.WriteLine($"{_showPrompt}");
        Console.WriteLine($"{_promptResponse}");
    }

}