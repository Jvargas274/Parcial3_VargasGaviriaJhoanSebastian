using Parcial3_VargasGaviriaJhoanSebastian.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Parcial3_VargasGaviriaJhoanSebastian.DAL
{
    public class DataBaseContext : DbContext
    {
        
        public DbSet<Ticket> Tickets { get; set; }

        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ticket>().HasIndex(t => t.TicketID).IsUnique();
        }

    }
}