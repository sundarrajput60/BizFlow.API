using Microsoft.EntityFrameworkCore;
using BizFlow.Domain.Entities;

namespace BizFlow.Infrastructure.Data
{
    public class BizFlowDbContext : DbContext
    {
        public BizFlowDbContext(DbContextOptions<BizFlowDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(e => e.HireDate)
                .HasColumnType("datetime"); // Set SQL type here

            base.OnModelCreating(modelBuilder);
        }
    }
}
