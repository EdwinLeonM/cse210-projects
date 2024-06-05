public class Swimming : Activity
{
    public int Laps { get; set; }
    private const double LapLengthMeters = 50;
    private const double MetersToMiles = 0.000621371;

    public Swimming(DateTime date, int durationMinutes, int laps)
        : base(date, durationMinutes)
    {
        Laps = laps;
    }

    public override double GetDistance() => Laps * LapLengthMeters * MetersToMiles;

    public override double GetSpeed() => (GetDistance() / DurationMinutes) * 60;

    public override double GetPace() => DurationMinutes / GetDistance();
}