namespace Trip_Planner_APP.Server.Models
{
    public class Flight
    {
        public int FlightId { get; set; }
        public string FlightNumber { get; set; }
        
        public string DipartureAirport { get; set; }

        public string ArrivalAirport { get; set; }

        public DateTime DepartureDate { get; set; }

        public DateTime ReturnDate { get; set; }

        public decimal Price { get; set; }

     
      

        public int TripId { get; set; }
        public Trip Trip { get; set; }
    }
}
