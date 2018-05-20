using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MountainWalkerWebAPI.Models;

namespace MountainWalkerWebAPI.Models
{
    public class UserContext : DbContext
    {

        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
		public DbSet<Achievements> Achievements { get; set; }
		public DbSet<UserAchivements> UserAchivements { get; set; }
    }
}
