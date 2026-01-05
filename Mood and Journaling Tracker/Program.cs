// Maria Osiana Buenas C. Dabocol
// BSCS 3-2
// 2023-11213-MN-0
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Daily Mood & Journaling Tracker ===\n");

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.WriteLine("\nHow are you feeling today?");
        Console.WriteLine("1 - Very Bad");
        Console.WriteLine("2 - Bad");
        Console.WriteLine("3 - Okay");
        Console.WriteLine("4 - Good");
        Console.WriteLine("5 - Very Good");

        Console.Write("\nEnter your mood (1-5): ");
        int mood = int.Parse(Console.ReadLine());

        Console.WriteLine("\nJournaling Section");
        Console.WriteLine("Write your thoughts or the reason for your mood.");
        Console.WriteLine("(Press ENTER when done)\n");

        Console.Write("Journal Entry: ");
        string journal = Console.ReadLine();

        Console.WriteLine("\n--- Daily Reflection Summary ---");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Mood Level: " + mood);
        Console.WriteLine("Journal Entry: " + journal);

        Console.WriteLine("\nSupport Message:");
        switch (mood)
        {
            case 1:
            case 2:
                Console.WriteLine("Thank you for sharing. Your feelings are valid. Take things one step at a time.");
                break;
            case 3:
                Console.WriteLine("An okay day is still progress. Keep reflecting and moving forward.");
                break;
            case 4:
            case 5:
                Console.WriteLine("It's great that you're feeling positive. Keep nurturing what makes you happy.");
                break;
        }
        DisplayMoodAdvice(mood);

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    static void DisplayMoodAdvice(int mood)
{
    Console.WriteLine("\nMood Analysis:");

    if (mood == 1)
    {
        Console.WriteLine("Mood: Very Bad");
        Console.WriteLine("Advice: Please consider resting and reaching out to someone you trust.");
    }
    else if (mood == 2)
    {
        Console.WriteLine("Mood: Bad");
        Console.WriteLine("Advice: Take a short break and do something calming.");
    }
    else if (mood == 3)
    {
        Console.WriteLine("Mood: Okay");
        Console.WriteLine("Advice: You’re doing fine. Small improvements matter. You can do it!");
    }
    else if (mood == 4)
    {
        Console.WriteLine("Mood: Good");
        Console.WriteLine("Advice: Keep maintaining the habits that make you feel good.");
    }
    else if (mood == 5)
    {
        Console.WriteLine("Mood: Very Good");
        Console.WriteLine("Advice: Share your positivity and enjoy the moment.");
    }
    else
    {
        Console.WriteLine("Invalid mood input.");
    }
}

}

