public class RoomBookingManager
{
    public bool BookRoom(HotelRoom hotel)
    {
        if(!hotel.IsBooked)
        {
            hotel.MarkAsBooked();
            return true;
        }
        return false;
    }

}