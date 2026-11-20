using CS2Scout.Api.Models;

namespace CS2Scout.Api.Services
{
    public interface IFaceitService
    {
        Task<PlayerDTO> GetPlayerAsync(string nickname);
        Task<PlayerStatsDTO> GetPlayerStatsAsync(string playerId);
    }
    
}
