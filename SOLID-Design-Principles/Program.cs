using System;

internal class Program
{
   
    private static void Main(string[] args)
    {
        Event concert = new Event {
            Name = "Rap Concert",
            Date = DateTime.Now.AddDays(30),
            Location = "Santo domingo"
        };

        EventStorage storage = new EventStorage();
        storage.SaveEvent(concert);

        EventPromoter promoter = new EventPromoter();
        promoter.ShareOnSocialMedia(concert);
          
        Console.ReadKey();
    }
} 