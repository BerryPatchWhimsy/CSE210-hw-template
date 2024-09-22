using System;

class Program
{
    static void Main(string[] args)
    {
        
        
            DisplayMessage();
            string userName = PromptUserName();
            int userNumber = PromptUserNumber();
            int squaredNumber = SquareNumber(userNumber);
            DisplayResult(userName, squaredNumber);
        
        
        
        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name1 = Console.ReadLine();
            return name1;
        }
        
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        
        static int SquareNumber(int number )
        {
            int squareNumber = number*number;
            return squareNumber;
        }

        static void DisplayResult(string name1, int squareNumber)
        {
            Console.WriteLine($"{name1}, the square of your number is {squareNumber}");
        }
    }
}