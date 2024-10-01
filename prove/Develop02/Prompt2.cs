using System;

public class Prompt2
{
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(_prompts.Count);

        Console.WriteLine(_prompts[index]);
        
        // int random = Random. Range(0, questions. Length)
    }



    // Questions._prompts.Add(prompt1);


    // public void Main(string[] args)
    // {
    //     string prompt1 = "Who was the most memorable person you encountered today?";
    //     public string prompt2 = "What was the best thing that happened to you today?";
    //     public string prompt3 = "What tender mercies of the Lord have you noticed?";
    //     public string prompt4 = "Describe the stingest emotion you felt today and what caused it.";
    //     public string prompt5 = "What was the best thing you ate today?";

    //     public List<string> prompts = new List<string>();

    //     prompts.Add(prompt1);
    // _prompts.Add(prompt2);
    // _prompts.Add(prompt3);
    // _prompts.Add(prompt4);
    // _prompts.Add(prompt5);
    }
    

    // int random = Random. Range(0, questions. Length)
}