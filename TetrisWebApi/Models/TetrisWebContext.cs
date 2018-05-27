using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TetrisWebApi.Models;

namespace TetrisWebApi.Models
{
    public class TetrisWebContext : DbContext
    {
        public TetrisWebContext(DbContextOptions<TetrisWebContext> options) : base(options) {
            
        }

        public DbSet<User> Users { get; set; }

        public DbSet<TetrisWebApi.Models.Score> Score { get; set; }
        
    }
}
