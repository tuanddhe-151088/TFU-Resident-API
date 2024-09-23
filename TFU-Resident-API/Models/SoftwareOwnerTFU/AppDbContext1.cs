using Microsoft.EntityFrameworkCore;

namespace TFU_Resident_API.Models.SoftwareOwnerTFU
{
    public class AppDbContext1 : DbContext
    {
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Investor> Investors { get; set; }
        public DbSet<Payment> Payments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure Role-User relationship
            modelBuilder.Entity<User>()
                .HasOne(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.RoleID);

            // Configure User-Investor relationship
            modelBuilder.Entity<Investor>()
                .HasOne(i => i.User)
                .WithMany(u => u.Investors)
                .HasForeignKey(i => i.UserID);

            // Configure Investor-Payment relationship
            modelBuilder.Entity<Payment>()
                .HasOne(p => p.Investor)
                .WithMany(i => i.Payments)
                .HasForeignKey(p => p.InvestorID);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Server=DESKTOP-SJ965H8;Database=SoftwareOwnerTFU;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
