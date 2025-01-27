﻿using SandboxServerManager.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxServerManager.Core.Interfaces
{
    public interface IPlayerRepository
    {
        Task<IEnumerable<Player>> GetAllPlayersAsync();

        Task<IEnumerable<Player>> GetAllAdminsAsync();

    }
}
