public class InvoiceGenerator
{
    public string GenerateInvoice( HotelRoom hotel)
    {
        if(hotel.IsBooked)
        {
            return $"Invoice for Room {hotel.RoomNumber}";
        }
        return string.Empty;
    }
}