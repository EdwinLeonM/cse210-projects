public class Cycling : Activity
{
    public double SpeedMph { get; set; }

    public Cycling(DateTime date, int durationMinutes, double speedMph)
        : base(date, durationMinutes)
    {
        SpeedMph = speedMph;
    }

    public override double GetDistance() => (SpeedMph * DurationMinutes) / 60;

    public override double GetSpeed() => SpeedMph;

    public override double GetPace() => 60 / SpeedMph;
}