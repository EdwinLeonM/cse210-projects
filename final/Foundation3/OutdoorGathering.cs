class OutdoorGathering : Event
{
    private string weatherStatement;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weatherStatement)
        : base(title, description, date, time, address)
    {
        this.weatherStatement = weatherStatement;
    }

    public override string GetFullDetails()
    {
        return GetStandardDetails() + $"Type: Outdoor Gathering\nWeather: {weatherStatement}\n";
    }
}