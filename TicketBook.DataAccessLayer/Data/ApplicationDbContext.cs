using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TicketBook.DataAccessLayer.DomainModel;

namespace TicketBook.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Airplane> Airplanes { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Flight> Flights { get; set; }

        public DbSet<Order> Orders { get; set; }

        //DbSet<OrderedTicket> OrderedTickets { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Flight>()
                .HasOne(a => a.Airplane)
                .WithMany(f => f.Flights)
                .HasForeignKey(k => k.AirplaneId);


            builder.Entity<Flight>()
                .HasOne(c => c.DepartureCity)
                .WithMany(f => f.FligtsAsDeparture)
                .HasForeignKey(k => k.DepartureCityId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Flight>()
                .HasOne(c => c.ArrivalCity)
                .WithMany(f => f.FlightsAsArrival).OnDelete(DeleteBehavior.Restrict);
            ;// .HasForeignKey(k => k.ArrivalCityId);

           // ---------------------------

            builder.Entity<Order>()
                .HasOne(p => p.Profile)
                .WithMany(o => o.Orders)
                .HasForeignKey(k => k.ProfileId);

            builder.Entity<Ticket>()
                .HasOne(p => p.Order)
                .WithMany(o => o.Tickets)
                .HasForeignKey(k => k.OrderId);

            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
