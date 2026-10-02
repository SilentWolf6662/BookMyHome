using BookMyHome.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace BookMyHome.Infrastructure
{
    public class BookMyHomeDbContext : DbContext
    {
        public DbSet<Accommodation> Accommodations => Set<Accommodation>();
        public DbSet<Booking> Bookings => Set<Booking>();
    }
}