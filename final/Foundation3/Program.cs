class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Anytown", "CA", "12345");
        Address address2 = new Address("456 Elm St", "Othertown", "TX", "67890");
        Address address3 = new Address("789 Oak St", "Thistown", "NY", "11223");

        Lecture lecture = new Lecture("Python Programming", "Learn the basics of Python", "2024-06-20", "10:00 AM", address1, "John Doe", 100);
        Reception reception = new Reception("Networking Event", "Meet and greet with industry professionals", "2024-07-10", "06:00 PM", address2, "rsvp@event.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Summer Picnic", "Enjoy a fun day at the park", "2024-08-15", "12:00 PM", address3, "Sunny and warm");

        Event[] events = { lecture, reception, outdoorGathering };

        foreach (var eventItem in events)
        {
            Console.WriteLine("Standard Details:\n" + eventItem.GetStandardDetails());
            Console.WriteLine("Full Details:\n" + eventItem.GetFullDetails());
            Console.WriteLine("Short Description:\n" + eventItem.GetShortDescription());
            Console.WriteLine(new string('-', 50));
        }
    }
}