namespace CS2Scout.Api.Models
{
    public class PlayerStatsDTO
    {
        private string averageKdRatio;

        public string Matches { get; set; } = string.Empty;
        public string WinRatePercentage { get; set; } = string.Empty;
        public string KdRatio { get; set; } = string.Empty;
        public string Adr { get; set; } = string.Empty;
        public string AverageHeadshotsPercentage { get; set; } = string.Empty;
        public string SniperKillRate { get; set; } = string.Empty;
        public string EntryRate { get; set; } = string.Empty;
        public string WinRate1v1 { get; set; } = string.Empty;
        public string UtilityDamagePerRound { get; set; } = string.Empty;
        public PlayerStatsDTO(string matches, string winRatePercentage, string kdRatio, string adr, string averageHeadshotsPercentage, string sniperKillRate, string entryRate, string winRate1v1, string utilityDamagePerRound)
        {
            Matches = matches;
            WinRatePercentage = winRatePercentage;
            KdRatio = kdRatio;
            Adr = adr;
            AverageHeadshotsPercentage = averageHeadshotsPercentage;
            SniperKillRate = sniperKillRate;
            EntryRate = entryRate;
            WinRate1v1 = winRate1v1;
            UtilityDamagePerRound = utilityDamagePerRound;
        }


    }
}
