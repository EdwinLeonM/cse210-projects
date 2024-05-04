using System;

public class Journal
{
    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void LoadFromFile(string fileName)
    {
        try
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    Entry entry = new Entry
                    {
                        _date = parts[0],
                        _promptText = parts[1],
                        _entryText = parts[2]
                    };
                    AddEntry(entry);
                }
                Console.WriteLine("File loaded successfully.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading file: {ex.Message}");
        }
    }

    public void SaveToFile(string fileName)
    {
        try
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                foreach (var entry in _entries)
                {
                    sw.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
                }
                Console.WriteLine("File saved successfully.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving file: {ex.Message}");
        }
    }
}
