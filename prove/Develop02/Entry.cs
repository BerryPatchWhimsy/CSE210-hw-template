using System;

public class Entry
{
    DateTime theCurrentTime = DateTime.Now;
    public string _date = theCurrentTime.ToShortDateString();
    //public string _date;
    
    public string _promptText;
    public string _entryText;
    

    public void Display()
    {
        Console.WriteLine($"{_date}");
        Console.WriteLine($"{_promptText}");
        Console.WriteLine($"{_entryText}");
    }
    
}
