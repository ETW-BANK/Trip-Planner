namespace Trip_Planner_APP.Server.Models
{
    public class Hotel
    {
        public int HotelId { get; set; }
        public string HotelName { get; set; }
        
        public int HotelType { get; set; }

        public string Address { get; set; }

        public DateTime CheckIn { get; set; }

        public DateTime CheckOut { get; set; }

        public decimal PricePerNight { get; set; }

       

        public int TripId { get; set; }
        public Trip Trip { get; set; }
    }
}
