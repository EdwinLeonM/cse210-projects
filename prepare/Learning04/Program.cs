using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment p1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(p1.GetSummary());

        MathAssignment p2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(p2.GetSummary());
        Console.WriteLine(p2.GetHomeworkList());

        WritingAssignment p3 = new WritingAssignment("Mary Waters ", "European History", "The Causes of World War II");
        Console.WriteLine(p3.GetSummary());
        Console.WriteLine(p3.GetWritingInformation());
    }
}