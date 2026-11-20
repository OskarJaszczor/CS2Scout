namespace CS2Scout.Api.Models
{
    public class PlayerDTO
    {
        public string nickName { get; set; } = string.Empty;
        public string playerId { get; set; } = string.Empty;
        public string country{ get; set; } = string.Empty;
        public int elo { get; set;  }
        public int level { get; set;  }


        public PlayerDTO(string nickName, string playerId, string country, int elo, int level)
        {
            this.nickName = nickName;
            this.playerId= playerId;
            this.country = country;
            this.elo = elo;
            this.level = level;
        }
    }
}
