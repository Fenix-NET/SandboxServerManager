using Microsoft.AspNetCore.Mvc;
using SandboxServerManager.Application.DataTransferObject;
using SandboxServerManager.Application.Services;

namespace SandboxServerManager.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly IPlayerService _playerService; 
        public PlayerController(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAllPlayers()
        {
            try
            {
                var players = await _playerService.GetAllPlayersAsync();
                return Ok(players);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("getalladmins")]
        public async Task<IActionResult> GetAllAdmins()
        {
            try
            {
                var admins = await _playerService.GetAllAdminsAsync();
                return Ok(admins);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
