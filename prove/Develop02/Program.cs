using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.IO;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine(promptGenerator.GetRandomPrompt());
                    string entryText = Console.ReadLine();
                    Entry entry = new Entry
                    {
                        _date = DateTime.Now.ToString(),
                        _promptText = promptGenerator.GetRandomPrompt(),
                        _entryText = entryText
                    };
                    journal.AddEntry(entry);
                    break;
                case 2:
                    journal.DisplayAll();
                    break;
                case 3:
                    Console.WriteLine("Enter the filename to load:");
                    string loadFileName = Console.ReadLine();
                    journal.LoadFromFile(loadFileName);
                    break;
                case 4:
                    Console.WriteLine("Enter the filename to save:");
                    string saveFileName = Console.ReadLine();
                    journal.SaveToFile(saveFileName);
                    break;
                case 5:
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please choose again.");
                    break;
            }
        }
    }
}
