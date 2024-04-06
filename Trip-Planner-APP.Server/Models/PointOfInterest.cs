namespace Trip_Planner_APP.Server.Models
{
    public class PointOfInterest
    {
        public int PointOfInterestId { get; set; }
        public string Name { get; set; }
        
        public string Description { get; set; }

        public string Catagory { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }
       

        public int TripId { get; set; }
        public Trip Trip { get; set; }
    }
}
