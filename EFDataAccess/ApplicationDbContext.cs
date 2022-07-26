using EFDataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace EFDataAccess
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }


        public virtual DbSet<Room> Room{ get; set; }
        public virtual DbSet<Employee> Employee{ get; set; }
        public virtual DbSet<Reservation> Reservation{ get; set; }
        public virtual DbSet<Assistant> Assistant{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}