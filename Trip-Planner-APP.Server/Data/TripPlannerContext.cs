using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Trip_Planner_APP.Server.Models;

namespace Trip_Planner_APP.Server.Data
{
    public class TripPlannerContext:IdentityDbContext<User>
    {

        public DbSet<Trip> Trips { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<PointOfInterest> PointsOfInterest { get; set; }
        public DbSet<Weather> Weather { get; set; }

        public TripPlannerContext(DbContextOptions<TripPlannerContext> options) : base(options)
        {
            
        }

    }
}
