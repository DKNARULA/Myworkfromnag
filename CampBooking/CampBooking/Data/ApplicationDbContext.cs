using CampBooking.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using CampBooking.Models.ViewModels;

namespace CampBooking.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<BookingTable> BookingTables { get; set; }
        public DbSet<campDetails> campDetails { get; set; }
        public DbSet<CampBooking.Models.ViewModels.campDetailsViewModel> campDetailsViewModel { get; set; }





    }
}
