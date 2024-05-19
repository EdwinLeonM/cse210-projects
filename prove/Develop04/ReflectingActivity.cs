using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() : base("Reflecting Activity",
        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = new List<string>
            {
                "Think of a time when you did something really difficult.",
                "Recall a moment when you felt truly proud of yourself.",
                "Remember a time when you helped someone in need."
            };

        _questions = new List<string>
            {
                "How did you feel when it was complete?",
                "What is your favorite thing about this experience?",
                "What did you learn about yourself from this experience?",
                "How can you apply this strength in other areas of your life?"
            };
    }

    public override void Run()
    {
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.WriteLine("You may begin in:");
        ShowCountDown(5);

        foreach (string question in _questions)
        {
            Console.WriteLine(question);
            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}