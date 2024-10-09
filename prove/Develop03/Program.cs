using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Reference r1 = new Reference("Moses", 7, 18);
        Scripture s2 = new Scripture(r1, "And the Lord called his people Zion, because they were of one heart and one mind, and dwelt in righteousness; and there was no poor among them.");
        Console.Clear();
        Console.WriteLine(r1.GetDisplayText());
        Console.WriteLine(s2.GetDisplayText());

        
        // Console.WriteLine("Press Enter or type 'quit'.");
        // Console.ReadLine();
        
        // while (Console.ReadLine() != "quit")
        // {
        //     Console.ReadLine();
        //     Console.Clear();
        //     s2.HideRandomWord(3);

        //     while (s2.IsCompletelyHidden() != true)
        //     {
        //         Console.ReadLine();
        //         Console.Clear();
        //         s2.HideRandomWord(3);
        //     }

        // }


        Console.WriteLine("GoodBye!");
        
        // int userInput = -1;
        
        // Console.WriteLine("Welcome to Scripture Mastery!");

        // while (userInput != 4)
        // {
        //     Console.WriteLine("1.Add New Scripture");
        //     Console.WriteLine("2.Open Scripture");
        //     Console.WriteLine("3.Display");
        //     Console.WriteLine("4.Quit");
        //     Console.WriteLine("");

        //     string choice = Console.ReadLine();
        //     userInput = int.Parse(choice);

        //     if (userInput == 1)
        //     {
        //         Reference r1 = new Reference();
        //         Console.WriteLine("Please enter the scripture reference: book chapter:verse");
        //         Console.ReadLine($"{Reference("", , )})
        //     }

        // }

        // Console.WriteLine("GoodBye!");



        // Console.WriteLine("Please enter the scripture reference: book chapter:verse");
        // Console.ReadLine();


        

        //Scripture s2 = new Scripture(r1, "And the Lord called his people Zion, because they were of one heart and one mind, and dwelt in righteousness; and there was no poor among them.");
        //Console.WriteLine(s2.HideRandomWord(3));

        
        // //private string _welcomeMessage;
        // string text = "And the Lord called his people Zion";
        

        // //add scripture text to list
        // //index loop with whole text
        // Word w1 = new Word("And");
        // Word w2 = new Word("the");
        // Word w3 = new Word("Lord");
        // Word w4 = new Word("called");
        // Word w5 = new Word("his");


        
        

        // Reference myReference = r1.GetDisplayText();

        //Console.WriteLine(ref1.GetDisplayText());


        //loop to add to list
        //add empty constructor for Scripture? necessary?
        // Scripture s1 = new Scripture(r1, "");
        // s1._words.Add(w1);
        // s1._words.Add(w2);
        // s1._words.Add(w3);
        // s1._words.Add(w4);
        // s1._words.Add(w5);


        
        // Console.WriteLine(s1.GetDisplayText());

        //     private string _book;
        // private int _chapter;
        // private int _verse;
        // private int _endVerse;
        

        // Word s1 = new Word();
        // s1._text = "And the Lord called his people Zion, because they were of one heart and one mind, and dwelt in righteousness; and there was no poor among them.";

    


        //private string _storeScripture;

        // private string _storeReference;
        // private string _quit;

        // public string DisplayWelcomeMessage()
        // {
        //     //needs to contain directions about "enter" and quit
        //     _welcomeMessage = "hello";
        
        //     return _welcomeMessage;
        // }

        // public string StoreScripture()
        // {
        //     Reference();
        // }

        
            
            

        

        


    }
}