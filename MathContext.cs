using Microsoft.EntityFrameworkCore;

namespace Straumann.Assignment
{
    public class MathContext : DbContext
    {

        public MathContext(DbContextOptions<MathContext> options)
        : base(options)
        {
        }
        public DbSet<MathOperationsEntity> MathOperationsEntities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MathOperationsEntity>(a =>
            {
                a.Property<int>("OperationId");
                a.HasKey("OperationId");
            });
        }
    }
}
