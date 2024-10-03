using System;
using System.IO;
class Journal2
{
    static void Main(string[] args)
    {
        public List<Entry> _entries = new List<Entry>();

        Journal2 j1 = new Journal2();
        
        Entry2 newEntry = new Entry2();
        newEntry._showPrompt = $"{Prompts2._GetRandomPrompt()}";
        newEntry._promptResponse = Console.ReadLine();

        AddEntry(Entry2 newEntry);

        
        // Job job1 = new Job();
        // job1._jobTitle = "Software Engineer";
        // job1._company = "Microsoft";
        // job1._startYear = 2006;
        // job1._endYear = 2019;

        // Resume myResume = new Resume();
        // myResume._name = "Anissa Pooley";

        // myResume._jobs.Add(job1);
        // myResume._jobs.Add(job2);

        // myResume.Display();

    
        // public string _showPrompt = GetRandomPrompt();
        
        // _entryText
    }

    public void AddEntry(Entry2 newEntry)
        { 
            Console.WriteLine(_showPrompt);
            string newEntry = Console.ReadLine();
            _entries.Add(newEntry);
        } 


    public void DisplayAll()
        {
            Console.WriteLine("Entries:");
      
                foreach (Entry2 entry in _entries)
                {
                    entry.Display();
                }  
        }

    public void SaveToFile(string file)
        {
            Console.WriteLine("What would you like to call this?");
            string fileName = Console.ReadLine();
            


            // // Don't forget to put this at the top, so C# knows where to find the StreamWriter class
            // using System.IO; 

            // ...

            // string fileName = "myFile.txt";

            // using (StreamWriter outputFile = new StreamWriter(filename))
            // {
            //     // You can add text to the file with the WriteLine method
            //     outputFile.WriteLine("This will be the first line in the file.");
    
            //     // You can use the $ and include variables just like with Console.WriteLine
            //     string color = "Blue";
            //     outputFile.WriteLine($"My favorite color is {color}");

            // }



            // Create a file to write to.
            // string createText = "Hello and Welcome" + Environment.NewLine;
            // File.WriteAllText(path, createText);

            // ...

            // // Open the file to read from.
            // string readText = File.ReadAllText(path);



            // Writing a text file:

            // using(StreamWriter writetext = new StreamWriter("write.txt"))
            // {
            //     writetext.WriteLine("writing in text file");
            // }
            // Reading a text file:

            // using(StreamReader readtext = new StreamReader("readme.txt"))
            // {
            //    string readText = readtext.ReadLine();
            // }

    public void LoadFromFile (file)
        {
            Console.WriteLine("What would you like to load?");
            string file = Console.ReadLine();

        //use with separate file for the prompt questions
        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);


            foreach (string line in lines)
            {
                string[] parts = line.Split(",");

                string firstName = parts[0];
                string lastName = parts[1];
            }
        }

}


 