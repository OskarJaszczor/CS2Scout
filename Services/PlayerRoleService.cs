using CS2Scout.Api.Models;
using System.Globalization;

namespace CS2Scout.Api.Services
{
    public class PlayerRoleService : IPlayerRoleService
    {
        public PlayerRoleDTO CalculatePlayerRole(PlayerStatsDTO? playerStatsDTO)
        {

            if (playerStatsDTO == null)
            {
                return new PlayerRoleDTO("Unknown", 0);
            }

            double sniper = Parse(playerStatsDTO.SniperKillRate);
            double entry = Parse(playerStatsDTO.EntryRate);
            double clutch1v1 = Parse(playerStatsDTO.WinRate1v1);
            double utility = Parse(playerStatsDTO.UtilityDamagePerRound);

            var candidates = new[]
            {
                new { Role = "AWPer", Score = sniper * 140.0 },          
                new { Role = "Entry Fragger", Score = entry * 110.0 },   
                new { Role = "Clutcher", Score = clutch1v1 * 65.0 },     
                new { Role = "Utility Support", Score = utility * 5.5 }  
            };

            var best = candidates.OrderByDescending(c => c.Score).First();

            if (best.Score <= 0)
            {
                return new PlayerRoleDTO("All-Rounder", 50);
            }

            int scoreValue = (int)Math.Clamp(Math.Round(best.Score), 1, 100);
            return new PlayerRoleDTO(best.Role, scoreValue);
        }

        private static double Parse(string? value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return 0;

            return double.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out var num)
                ? num
                : 0;
        }
    }
}
