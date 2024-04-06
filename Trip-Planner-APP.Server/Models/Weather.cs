namespace Trip_Planner_APP.Server.Models
{
    public class Weather
    {
        public int WeatherId { get; set; }
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Description { get; set; } 

       

        public int TripId { get; set; }
        public Trip Trip { get; set; }
    }
}
