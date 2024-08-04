using Microsoft.EntityFrameworkCore;
using SandboxServerManager.Core.Entities;
using SandboxServerManager.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SandboxServerManager.Infrastructure.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly SandboxContext _context;
        public PlayerRepository(SandboxContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Player>> GetAllPlayersAsync()
        {
            return await _context.Players.AsNoTracking()
                .Include(i => i.PlayerRole)
                .Include(i => i.Clan)
                .ToListAsync();
        }
        public async Task<IEnumerable<Player>> GetAllAdminsAsync()
        {
            var admins = await _context.Players.AsNoTracking()
                .Where(p => p.RoleId == 1 || p.RoleId == 2 || p.RoleId == 3)
                .ToListAsync();

            return admins;
        }
    }
}
