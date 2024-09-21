using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percent?");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string letter = "";

        if (grade >=94)
        {
            letter = "A";
        }
        else if (grade <=93 && grade >=90)
        {
            letter = "A-";
        }    
        else if (grade <90 && grade >=87)
        {
            letter = "B+"; 
        }
        else if (grade <87 && grade >=84)
        {
            letter = "B";
        }
        else if (grade <=83 && grade >=80)
        {
            letter = "B-"; 
        }
        else if (grade <80 && grade >=77)
        {
            letter = "C+";
        }
        else if (grade <77 && grade >=74)
        {
            letter = "C";
        }
        else if (grade <=73 && grade >=70)
        {
            letter = "C-";
        }
        else if (grade <70 && grade >=67)
        {
            letter = "D+"; 
        }
        else if (grade <67 && grade >=64)
        {
            letter = "D";
        }
        else if (grade <=63 && grade >=60)
        {
            letter = "D-";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is a/an '{letter}'.");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass. Better luck next time.");
        }
    }
}