namespace Trip_Planner_APP.Server.Models
{
    public class Trip
    {
        public int TripId { get; set; }
        public string TripName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public string Status { get; set; }


        public string UserId { get; set; }
        public User User { get; set; }

        public ICollection<Flight> Flights { get; set; }
        public ICollection<Hotel> Hotels { get; set; }
        public ICollection<PointOfInterest> PointsOfInterest { get; set; }
        public ICollection<Weather> Weather{ get; set;}

    }

    }