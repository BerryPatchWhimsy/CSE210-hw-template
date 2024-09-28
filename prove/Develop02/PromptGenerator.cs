public class PromptGenerator
{
    //static void Main(string[] args)
    //{
        public List<string> _prompts = new List<string>();

        public string prompt1 = "Who was the most memorable person you encountered today?";
        public string prompt2 = "What was the best thing that happened to you today?";
        public string prompt3 = "What tender mercies of the Lord have you noticed?";
        public string prompt4 = "Describe the stingest emotion you felt today and what caused it.";
        public string prompt5 = "What was the best thing you ate today?";


        _prompts.Add(prompt1);
        _prompts.Add(prompt2);
        _prompts.Add(prompt3);
        _prompts.Add(prompt4);
        _prompts.Add(prompt5);

        Random randomGenerator = new Random();
        int index = randomGenerator.Next(_prompts.Count);

        public string GetRandomPrompt()
        {
            Console.WriteLine(_prompts[index]);
        }
}

        // //example from internet
        // List<string> fruits = new List<string>
        // {
        //     "Apple", "Banana", "Cherry", "Dragonfruit", "Elderberry"
        // };

        // // Random object
        // Random rnd = new Random();

        // // Get random index
        // int index = rnd.Next(fruits.Count);

        // // Print random fruit
        // Console.WriteLine(fruits[index]);



        
    //}