using System;

class Journal2
{
    static void Main(string[] args)
    {
    }
   
    Entry newEntry = new Entry();
    newEntry._showPrompt = Prompts2._GetRandomPrompt();
    newEntry._promptResponse = ""

    public void AddEntry(Entry newEntry)
    {

    }



    public string _showPrompt;
    public string _promptResponse;

    //   Job job1 = new Job();
    //     job1._jobTitle = "Software Engineer";
    //     job1._company = "Microsoft";
    //     job1._startYear = 2006;
    //     job1._endYear = 2019;

    //     Job job2 = new Job();
    //     job2._jobTitle = "Web Designer";
    //     job2._company = "Apple";
    //     job2._startYear = 2019;
    //     job2._endYear = 2023;


    //     Resume myResume = new Resume();
    //     myResume._name = "Anissa Pooley";

    //     myResume._jobs.Add(job1);
    //     myResume._jobs.Add(job2);

    //     myResume.Display();




    public string prompt1 = "Who was the most memorable person you encountered today?";
    public string prompt2 = "What was the best thing that happened to you today?";
    public string prompt3 = "What tender mercies of the Lord have you noticed?";
    public string prompt4 = "Describe the stingest emotion you felt today and what caused it.";
    public string prompt5 = "What was the best thing you ate today?";

    Prompt2 myPrompts = new Prompt2();

    myPrompts._prompts.Add("Who was the most memorable person you encountered today?");



    

}
