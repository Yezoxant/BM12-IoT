using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BM12.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BM12
{
    public class IotContext: IdentityDbContext
    {
        public IotContext(DbContextOptions<IotContext> options) : base(options)
        {
        }

        public DbSet<Class> Classes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<FeedbackQuestion> FeedbackQuestions { get; set; }
        public DbSet<FeedbackAnswer> Feedbackanswers { get; set; }
        public DbSet<PictureData> PictureData { get; set; }
        public DbSet<Beacon> Beacons { get; set; }
        public DbSet<UserPresence> Userpresence { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder OptionsBuilder)
        {
        }

        private static string GetConnectionString()
        {
            const string databaseName = "bm12-iot.database.windows.net";
            const string databaseUser = "IoT";
            const string databasePass = "Zuyd123";

            return $"Server=localhost;" +
                   $"database={databaseName};" +
                   $"uid={databaseUser};" +
                   $"pwd={databasePass};" +
                   $"pooling=true;";
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //builder.Entity<User>().HasIndex(u => u.Identity.Email).IsUnique();
        }
    }
}
