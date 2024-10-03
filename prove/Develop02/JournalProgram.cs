using System;

class Journal
{
    // static void Main(string[] args)
    // {

        
        public List<Entry> _entries = new List<Entry>();
        public string _promptText = GetRandomPrompt();
        
        
        _entryText
    
        public void AddEntry(Entry newEntry)
        { 
            Console.WriteLine(_promptText);
            string newEntry = Console.ReadLine();
            _entries.Add(newEntry);
        } 

        public void DisplayAll()
        {
            Console.WriteLine("Entries:");
      
                foreach (Entry entry in _entries)
                {
                    entry.Display();
                }  
        }

        public void SaveToFile(string file)
        {
            Console.WriteLine("What would you like to call this?");
            string file = Console.ReadLine();


            //You can create or write a text file in C# using a class the System.IO.StreamWriter class. When you create an object of this class you can use the Write() and WriteLine() methods in the same way as the Console.Write() methods, except that they will write the strings to the file instead of to the Console.
            // To make sure the file gets closed and cleaned up appropriately when you are done, it is best practice to put the StreamWriter object in a using() block. This works the same as a "with" block in Python and ensures that the resources are cleaned up when you leave that area of the code.
            // The following shows an example of writing text to a new file

            // Don't forget to put this at the top, so C# knows where to find the StreamWriter class
            using System.IO; 

            string fileName = ($"{file}.txt");

            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                // You can add text to the file with the WriteLine method
                outputFile.WriteLine("This will be the first line in the file.");
    
                // You can use the $ and include variables just like with Console.WriteLine
                string color = "Blue";
                outputFile.WriteLine($"My favorite color is {color}");
            }
        }

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
    // }
}