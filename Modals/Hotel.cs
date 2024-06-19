namespace Onthebeach.Models
{
    // Represents a hotel with details like name, arrival date, and pricing.
    public class Hotel
    {
        // Unique identifier for the hotel.
        public int Id { get; set; }

        // Name of the hotel.
        public string Name { get; set; }

        // Arrival date for the hotel booking.
        public DateTime ArrivalDate { get; set; }

        // Price per night for staying at the hotel.
        public decimal PricePerNight { get; set; }

        // List of local airports accessible from the hotel.
        public List<string> LocalAirports { get; set; }

        // Number of nights the booking covers.
        public int Nights { get; set; }
    }
}
