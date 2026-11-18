using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TodoServerApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public virtual DbSet<TaskItem> TaskItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<TaskItem>().HasData([
                new TaskItem{Id = 1, Title = "sad", Description = "tsad1"},
                new TaskItem{Id = 2, Title = "happ", Description = "tsad2"},
                new TaskItem{Id = 3, Title = "abg", Description = "tsad3"},
                new TaskItem{Id = 4, Title = "abdsg", Description = "tsad4"},
            ]);
        }
    }
}
