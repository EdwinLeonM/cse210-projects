abstract class Goal
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Points { get; set; }

    public Goal(string name, string description, string points)
    {
        Name = name;
        Description = description;
        Points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();
}