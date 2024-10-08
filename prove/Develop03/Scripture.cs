using System;
using System.Collections.Generic;


public class Scripture
{

    public List<Word> _words = new List<Word>();

    private Reference _reference;
    

    
    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        string input = text;
        //Word w = new Word("");

        string[] pieces = input.Split(' '); 
        List<string> list = pieces.ToList();

        

        foreach (string s in list)
        {
            List<string> _words = new List<string>();
            // Scripture script = new Scripture(Reference, "");

            // script._words.Add(s);

        }
        
        
        //List<string> list = pieces.ToList();

        // List<string> _words = new List<string>();
        // List

        // foreach(string s in list)
        // {
        //     _words.Add((object)s);   
        // }

        // foreach(Object o in words)
        // {
        //     _words.Add(o);
        // }

    }

    
    public void HideRandomWord(int numberToHide)
    {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(_words.Count);
            
        object randWord = _words[index];

        //Console.WriteLine(_words[index]);

        //loop repeat random for number to hide
        for (int i=0; i<_words.Count; i = i + numberToHide)
        {
            foreach (Word word in _words)
            {
                Word w = new Word("");
                //w.IsHidden();
                
                if (word == randWord)
                {
                    //w.IsHidden() = true;
                    Console.WriteLine("___");
                }

                else 
                {
                   
                   Console.WriteLine(word);
                }
            }
        }

    }

    public string GetDisplayText()
    {
        //notes how to show list
        object wordList = _words;

        string scriptureText = wordList.ToString();

        return scriptureText;
    }

    public bool IsCompletelyHidden()
    {
        //while word in _words are != hidden, then false
        Word word = new Word("");
        word.IsHidden();

        while (word.IsHidden() == false)
        {
            return false;
        } 
        return true;
    }

}