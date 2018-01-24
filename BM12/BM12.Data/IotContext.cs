using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BM12___Entity_Framework.Models;

namespace BM12___Entity_Framework
{
    public class IotContext: DbContext
    {
        public IotContext(DbContextOptions<IotContext> options) : base(options)
        {
        }

        public DbSet<Class> Classes { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
