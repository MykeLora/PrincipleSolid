public class HotelRoom
{
    public int RoomNumber { get;set;}
    public bool IsBooked { get;set;}

    public void MarkAsBooked()
    {
        IsBooked = true;
    }
}