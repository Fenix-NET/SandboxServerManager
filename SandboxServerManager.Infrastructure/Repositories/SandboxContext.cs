using Microsoft.EntityFrameworkCore;
using SandboxServerManager.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxServerManager.Infrastructure.Repositories
{
    public class SandboxContext :DbContext
    {
        public SandboxContext(DbContextOptions options)
            : base(options)
        {
            
        }

        public DbSet<Clan> Clans { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerRole> PlayerRoles { get; set; }
    }
}
