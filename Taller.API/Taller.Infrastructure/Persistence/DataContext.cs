using Microsoft.EntityFrameworkCore;
using Taller.Domain.Models;

namespace Taller.Infrastructure.Persistence;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<Report> Reports { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Report>(entity =>
        {
            entity.Property(p => p.Status)
            .HasConversion(
                v => v.ToString(),
                v => (ReportStatus)Enum.Parse(typeof(ReportStatus), v));
        });

        base.OnModelCreating(modelBuilder);
    }
}
