using System;
using System.Collections.Generic;
public class Prompts2
{  
    static void Main(string[] args)
    {
        public string GetRandomPrompt()
        {
            List<string> _prompts = new List<string>();

            _prompts.Add("Who was the most memorable person you encountered today?");
            _prompts.Add("What was the best thing that happened to you today?");
            _prompts.Add("What tender mercies of the Lord have you noticed?");
            _prompts.Add("Describe the stingest emotion you felt today and what caused it.");
            _prompts.Add("What was the best thing you ate today?");

            Random randomGenerator = new Random();
            int index = randomGenerator.Next(_prompts.Count);
            
            return _prompts[index];
            
        }
    }

    // //example from internet
    //     List<string> fruits = new List<string>
    //     {
    //         "Apple", "Banana", "Cherry", "Dragonfruit", "Elderberry"
    //     };

    //     // Random object
    //     Random rnd = new Random();

    //     // Get random index
    //     int index = rnd.Next(fruits.Count);

    //     // Print random fruit
    //     Console.WriteLine(fruits[index]);
}