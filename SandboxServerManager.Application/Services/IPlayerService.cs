using SandboxServerManager.Application.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxServerManager.Application.Services
{
    public interface IPlayerService
    {
        Task<IEnumerable<PlayerDto>> GetAllPlayersAsync();
        Task<IEnumerable<PlayerDto>> GetAllAdminsAsync();
    }
}
