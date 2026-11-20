using System.Text.Json.Serialization;

namespace CS2Scout.Api.Models
{
    public class FaceitServerResponse
    {
        [JsonPropertyName("player_id")]
        public string PlayerId { get; set; }
        [JsonPropertyName("nickname")]
        public string Nickname{ get; set; }
        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("games")]
        public FaceitGames Games { get; set; }

    }

    public class FaceitGames
    {
        [JsonPropertyName("cs2")]
        public Cs2 Cs2 { get; set; }

    }

    public class Cs2
    {
        [JsonPropertyName("skill_level")]
        public int SkillLevel { get; set; }
        [JsonPropertyName("faceit_elo")]
        public int FaceitElo{ get; set; }
    }

}
