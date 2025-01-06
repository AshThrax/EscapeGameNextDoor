using Microsoft.EntityFrameworkCore;


namespace NotificationService.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options) { }
        
        public DbSet<NotificationType> NotificationTypes { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Annonce> Annonces { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //notification
            modelBuilder.Entity<Notification>()
                        .HasKey(e =>e.Id);
            modelBuilder.Entity<Notification>()
                        .HasOne(x=>x.NotificationType)
                        .WithMany()
                        .HasForeignKey(x=>x.NotificationTypeId)
                        .OnDelete(DeleteBehavior.Restrict);

            //notification Type
            modelBuilder.Entity<NotificationType>().HasKey(e =>e.Id);
            base.OnModelCreating(modelBuilder);
            //Annonce
        }
    }
}
