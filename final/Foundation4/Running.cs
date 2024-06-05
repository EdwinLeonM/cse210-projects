public class Running : Activity
{
    public double DistanceMiles { get; set; }

    public Running(DateTime date, int durationMinutes, double distanceMiles)
        : base(date, durationMinutes)
    {
        DistanceMiles = distanceMiles;
    }

    public override double GetDistance() => DistanceMiles;

    public override double GetSpeed() => (DistanceMiles / DurationMinutes) * 60;

    public override double GetPace() => DurationMinutes / DistanceMiles;
}



