using CS2Scout.Api.Models;

namespace CS2Scout.Api.Services
{
    public interface IPlayerRoleService
    {
        PlayerRoleDTO CalculatePlayerRole(PlayerStatsDTO? playerStatsDTO);

    }
}
