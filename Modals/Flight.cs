namespace Onthebeach.Models
{
    // Represents a flight with details like airline, departure, and destination.
    public class Flight
    {
        // Unique identifier for the flight.
        public int Id { get; set; }

        // Name of the airline operating the flight.
        public string Airline { get; set; }

        // Airport code from which the flight departs.
        public string From { get; set; }

        // Airport code to which the flight is headed.
        public string To { get; set; }

        // Price of the flight ticket.
        public decimal Price { get; set; }

        // Departure date of the flight.
        public DateTime DepartureDate { get; set; }
    }
}
