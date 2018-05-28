using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using TicketBook.BusinessLayer;
using TicketBook.DataAccessLayer;
using TicketBook.Data;

namespace TicketBook
{
    public class Program
    {
        public static  void Main(string[] args)
        {
            //BuildWebHost(args).Run();

            var host = BuildWebHost(args);

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                try
                {
                    var userManger = services.GetRequiredService<UserManager<ApplicationUser>>();
                    var rolesManager = services.GetRequiredService<RoleManager<IdentityRole>>();
                    var dbContext = services.GetRequiredService<ApplicationDbContext>();
                    //var uowService = services.GetRequiredService<IUnitOfWork>();

                    RoleInitializer.InitializeAsync(userManger, rolesManager);
                    //var context = services.GetRequiredService<ApplicationDbContext>();

                   //new InitialFlights().CreateFlightsEveryWednsday(context);

                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred while seeding the database.");
                }


                try
                {
                    var uowService = services.GetRequiredService<ApplicationUnitOfWork>();

                    //FlightsInitalizer.InitializeAsync(uowService);
                    var context = services.GetRequiredService<ApplicationDbContext>();

                    //new InitialFlights().CreateFlightsEveryWednsday(context);

                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred while seeding the database.");
                }

                host.Run();
            }
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
