
using Microsoft.EntityFrameworkCore;
using Trip_Planner_APP.Server.Data;
using Trip_Planner_APP.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;




namespace Trip_Planner_APP.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionstring = builder.Configuration.GetConnectionString("TripDb");
            builder.Services.AddDbContext<TripPlannerContext>(options=>options.UseSqlServer(connectionstring));
            builder.Services.AddAuthorization();
            builder.Services.AddIdentity<User, IdentityRole>(options => 
            { 

                //password must atleast be 8 charactes, must include atleast 1 special character,1 lowercase,1 uppercase,atleaset 1 number(example @Tensae1234)
                options.Password.RequiredUniqueChars = 0;
                options.Password.RequireUppercase = true;
                options.Password.RequireLowercase = true;
                options.Password.RequiredLength = 8;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireDigit = true;
            
            
            })

              .AddEntityFrameworkStores<TripPlannerContext>()
              .AddDefaultTokenProviders();
    

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            app.UseDefaultFiles();
            app.UseStaticFiles();
            

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.MapFallbackToFile("/index.html");

            app.Run();
        }
    }
}
