using AutoMapper;
using SandboxServerManager.Application.DataTransferObject;
using SandboxServerManager.Core.Entities;
using SandboxServerManager.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxServerManager.Application.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository _playerRepository;
        private readonly IMapper _mapper;

        public PlayerService(IPlayerRepository playerRepository, IMapper mapper)
        {
            _playerRepository = playerRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PlayerDto>> GetAllPlayersAsync()
        {
            var players = await _playerRepository.GetAllPlayersAsync();

            return _mapper.Map<IEnumerable<PlayerDto>>(players).ToList();
        }
        public async Task<IEnumerable<PlayerDto>> GetAllAdminsAsync()
        {
            var admins = await _playerRepository.GetAllAdminsAsync();

            return _mapper.Map<IEnumerable<PlayerDto>>(admins).ToList();
        }

    }
}
