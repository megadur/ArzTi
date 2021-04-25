using Microsoft.EntityFrameworkCore;
using ArzTiServer.Models;

namespace ArzTiServer.DataAccess
{
    public class HospitalSqlContext: DbContext
    {
        public HospitalSqlContext(DbContextOptions<HospitalSqlContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Patient> Patients { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
        }
    }
}
