using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CS2Scout.Api.Models;
using CS2Scout.Api.Services;
using System.Text.Json;
using System.Text;


namespace CS2Scout.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {

        private readonly IFaceitService _faceitService;
        private readonly IPlayerRoleService _playerRoleService;

        public PlayerController(IFaceitService faceitService, IPlayerRoleService playerRoleService)
        {
            _faceitService = faceitService;
            _playerRoleService = playerRoleService;
        }

        [HttpGet("{nickname}")]
        public async Task<IActionResult> GetPlayer(string nickname)
        {
            var player = await _faceitService.GetPlayerAsync(nickname);

            if (player == null)
            {
                return NotFound("Nie znaleziono gracza!");
            }

            var playerStats = await _faceitService.GetPlayerStatsAsync(player.playerId);
            var role = _playerRoleService.CalculatePlayerRole(playerStats);

            //return Ok(playerStats);
            return Ok(new
            {
                Player = player,
                Stats = playerStats,
                Role = role
            }
                );
        }
    }
}
