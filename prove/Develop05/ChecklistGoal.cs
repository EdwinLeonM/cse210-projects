class ChecklistGoal : Goal
{
    public int AmountCompleted { get; private set; }
    public int Target { get; private set; }
    public int Bonus { get; private set; }

    public ChecklistGoal(string name, string description, string points, int target, int bonus)
        : base(name, description, points)
    {
        Target = target;
        Bonus = bonus;
        AmountCompleted = 0;
    }

    public override void RecordEvent()
    {
        AmountCompleted++;
    }

    public override bool IsComplete()
    {
        return AmountCompleted >= Target;
    }

    public override string GetDetailsString()
    {
        return $"[ ] {Name} ({Description}) -- Currently completed: {AmountCompleted}/{Target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{Name}|{Description}|{Points}|{Target}|{Bonus}|{AmountCompleted}";
    }
}