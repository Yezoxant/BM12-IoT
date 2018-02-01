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
        public DbSet<User> User { get; set; }
        public DbSet<PictureData> PictureData { get; set; }
        public DbSet<Beacon> Beacons { get; set; }
        public DbSet<UserActivity> Userpresences { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<ClassCourse> ClassCourse { get; set; }
        public DbSet<CourseActivity> CourseActivity { get; set; }
        public DbSet<UserActivity> UserActivity { get; set; }
        public DbSet<UserClass> UserClass { get; set; }

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
            
        }
    }
}
