public class EventStorage
{
    public void SaveEvent(Event eventDetail)
    {
        // Logic to save the event to a database or file
        Console.WriteLine("Event Saved to the Database");
    }

    public Event GetEvent(string eventName)
    {
        // Logic to retrieve the event based on its name
        Console.WriteLine($"Fetching the Event {eventName} Details");
            
        return new Event(); // Placeholder return for demonstration
    }
       
}