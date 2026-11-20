using CS2Scout.Api.Models;
using System.Text.Json;

namespace CS2Scout.Api.Services
{
    public class FaceitService : IFaceitService
    {
        private readonly HttpClient _httpClient;

        public FaceitService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        public async Task<PlayerDTO?> GetPlayerAsync(string nickname)
        {
            var response = await _httpClient.GetAsync($"players?nickname={nickname}");

            if (!response.IsSuccessStatusCode)
                return null;

            var rawJson = await response.Content.ReadAsStringAsync();
            var faceitPlayer = JsonSerializer.Deserialize<FaceitServerResponse>(rawJson);

            if (faceitPlayer == null)
                return null;

            //Console.WriteLine(rawJson);

            PlayerDTO playerDTO = new PlayerDTO
            (
                 faceitPlayer.Nickname,
                 faceitPlayer.PlayerId,
                 faceitPlayer.Country,
                 faceitPlayer.Games.Cs2.FaceitElo,
                 faceitPlayer.Games.Cs2.SkillLevel
            );


            return playerDTO;
        }

        public async Task<PlayerStatsDTO> GetPlayerStatsAsync(string playerId)
        {
            var response = await _httpClient.GetAsync($"players/{playerId}/stats/cs2");

            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine("chjuj");
                return null;
            }

            var rawJson = await response.Content.ReadAsStringAsync();
            //Console.WriteLine( rawJson );
            var faceitPlayerStats = JsonSerializer.Deserialize<PlayerStatsResponse>(rawJson);


            PlayerStatsDTO playerStatsDTO = new PlayerStatsDTO
            (
                faceitPlayerStats.lifeTime.Matches,
                faceitPlayerStats.lifeTime.WinRatePercentage,
                faceitPlayerStats.lifeTime.AverageKdRatio,
                faceitPlayerStats.lifeTime.Adr,
                faceitPlayerStats.lifeTime.AverageHeadshotsPercentage,
                faceitPlayerStats.lifeTime.SniperKillRate,
                faceitPlayerStats.lifeTime.EntryRate,
                faceitPlayerStats.lifeTime.WinRate1v1,
                faceitPlayerStats.lifeTime.UtilityDamagePerRound

            );

            return playerStatsDTO;
        }


    }
}
