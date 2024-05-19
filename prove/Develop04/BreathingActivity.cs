using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();

        int cycles = _duration / 3;
        for (int i = 0; i < cycles; i++)
        {
            Console.WriteLine("Breathe in...");
            AnimateBreath(true);
            Console.WriteLine("Now breathe out...");
            AnimateBreath(false);
        }

        DisplayEndingMessage();
    }

    private void AnimateBreath(bool isInhale)
    {
        int steps = 20;

        for (int i = 0; i <= steps; i++)
        {
            int delay = isInhale ? i : steps - i;
            double factor = (double)delay / steps;
            int size = (int)(factor * 20) + 1;
            Console.Clear();
            Console.WriteLine(new string('>', size));
            Thread.Sleep(50 + (isInhale ? (steps - delay) : delay) * 10);
        }

        Console.Clear();
    }
}