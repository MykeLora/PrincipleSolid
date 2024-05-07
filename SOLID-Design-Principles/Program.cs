using System;


internal class Program
{
    private static void Main(string[] args)
    {
        HotelRoom hotel = new HotelRoom
        {
            RoomNumber = 120
        };

        RoomBookingManager manager = new RoomBookingManager();

        bool isBooked = manager.BookRoom(hotel);

        if (isBooked)
        {
            InvoiceGenerator invoiceGen = new InvoiceGenerator();

            string invoice = invoiceGen.GenerateInvoice(hotel);
        }
    }
}