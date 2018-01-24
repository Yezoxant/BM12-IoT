using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BM12.Data.Models;

namespace BM12___Entity_Framework
{
    public class IotContext: DbContext
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

    }
}
