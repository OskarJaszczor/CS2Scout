using System.Text.Json.Serialization;

namespace CS2Scout.Api.Models
{
    public class PlayerStatsResponse
    {
        [JsonPropertyName("player_id")]
        public string playerId {  get; set; }
        [JsonPropertyName("game_id")]
        public string gameId { get; set; }

        [JsonPropertyName("lifetime")]
        public LifeTime lifeTime { get; set; }

        public class LifeTime
        {
            // --- 1. PODSTAWOWE STATYSTYKI ŻYCIOWE ---

            // Całkowita liczba rozegranych meczów na platformie.
            [JsonPropertyName("Matches")]
            public string Matches { get; set; }

            // Duplikat całkowitej liczby meczów (często zwracany zamiennie przez Faceit).
            [JsonPropertyName("Total Matches")]
            public string TotalMatches { get; set; }

            // Całkowita liczba wygranych spotkań.
            [JsonPropertyName("Wins")]
            public string Wins { get; set; }

            // Procentowy stosunek wygranych meczów do wszystkich rozegranych (powyżej 50% = częściej wygrywasz).
            [JsonPropertyName("Win Rate %")]
            public string WinRatePercentage { get; set; }

            // Średni stosunek zabójstw do śmierci (Kills/Deaths) liczony na jeden mecz.
            [JsonPropertyName("Average K/D Ratio")]
            public string AverageKdRatio { get; set; }

            // Zsumowany stosunek wszystkich zabójstw do wszystkich śmierci z całej historii konta.
            [JsonPropertyName("K/D Ratio")]
            public string KdRatio { get; set; }

            // Average Damage per Round - średnie obrażenia zadane przeciwnikom w jednej rundzie.
            [JsonPropertyName("ADR")]
            public string Adr { get; set; }

            // Średni procent zabójstw zakończonych trafieniem w głowę.
            [JsonPropertyName("Average Headshots %")]
            public string AverageHeadshotsPercentage { get; set; }

            // Całkowita LICZBA (nie procent, mimo nazwy w API) trafień w głowę w historii konta.
            [JsonPropertyName("Total Headshots %")]
            public string TotalHeadshotsPercentage { get; set; }

            // Obecna seria zwycięstw z rzędu.
            [JsonPropertyName("Current Win Streak")]
            public string CurrentWinStreak { get; set; }

            // Najdłuższa historyczna seria zwycięstw z rzędu.
            [JsonPropertyName("Longest Win Streak")]
            public string LongestWinStreak { get; set; }

            // Tablica pięciu ostatnich meczów ("1" = wygrana, "0" = przegrana).
            [JsonPropertyName("Recent Results")]
            public List<string> RecentResults { get; set; }


            // --- 2. STATYSTYKI OGÓLNE (ZABÓJSTWA, RUNDY, OBRAŻENIA) ---

            // Suma wszystkich obrażeń zadanych wrogom w historii gry na Faceicie.
            [JsonPropertyName("Total Damage")]
            public string TotalDamage { get; set; }

            // Całkowita liczba rozegranych rund od wprowadzenia przez Faceit śledzenia zaawansowanych danych.
            [JsonPropertyName("Total Rounds with extended stats")]
            public string TotalRoundsWithExtendedStats { get; set; }

            // Całkowita liczba zdobytych zabójstw od wprowadzenia zaawansowanych danych.
            [JsonPropertyName("Total Kills with extended stats")]
            public string TotalKillsWithExtendedStats { get; set; }


            // --- 3. STATYSTYKI ENTRY FRAGGERA (OTWIERANIE RUND) ---

            // Częstotliwość, z jaką podejmujesz pierwsze starcie w rundzie (opening duel).
            [JsonPropertyName("Entry Rate")]
            public string EntryRate { get; set; }

            // Procent wygranych pierwszych starć w rundzie (zdobycie przewagi 5v4).
            [JsonPropertyName("Entry Success Rate")]
            public string EntrySuccessRate { get; set; }

            // Łączna liczba podjętych prób zdobycia pierwszego zabójstwa.
            [JsonPropertyName("Total Entry Count")]
            public string TotalEntryCount { get; set; }

            // Liczba faktycznie zdobytych pierwszych zabójstw w rundzie.
            [JsonPropertyName("Total Entry Wins")]
            public string TotalEntryWins { get; set; }


            // --- 4. STATYSTYKI SNAJPERA ---

            // Procent wszystkich Twoich zabójstw, które zostały zdobyte za pomocą snajperki (AWP).
            [JsonPropertyName("Sniper Kill Rate")]
            public string SniperKillRate { get; set; }

            // Średnia liczba zabójstw ze snajperki przypadająca na jedną rozegraną rundę.
            [JsonPropertyName("Sniper Kill Rate per Round")]
            public string SniperKillRatePerRound { get; set; }

            // Zsumowana liczba zlikwidowanych przeciwników za pomocą broni snajperskiej.
            [JsonPropertyName("Total Sniper Kills")]
            public string TotalSniperKills { get; set; }


            // --- 5. STATYSTYKI CLUTCHY (SYTUACJE 1v1 i 1v2) ---

            // Procent wygranych rund, w których zostałeś sam na jednego przeciwnika.
            [JsonPropertyName("1v1 Win Rate")]
            public string WinRate1v1 { get; set; }

            // Liczba wszystkich napotkanych sytuacji 1 na 1.
            [JsonPropertyName("Total 1v1 Count")]
            public string Total1v1Count { get; set; }

            // Liczba wygranych sytuacji 1 na 1.
            [JsonPropertyName("Total 1v1 Wins")]
            public string Total1v1Wins { get; set; }

            // Procent wygranych rund, w których zostałeś sam na dwóch przeciwników.
            [JsonPropertyName("1v2 Win Rate")]
            public string WinRate1v2 { get; set; }

            // Liczba wszystkich napotkanych sytuacji 1 na 2.
            [JsonPropertyName("Total 1v2 Count")]
            public string Total1v2Count { get; set; }

            // Liczba wygranych sytuacji 1 na 2.
            [JsonPropertyName("Total 1v2 Wins")]
            public string Total1v2Wins { get; set; }


            // --- 6. STATYSTYKI GRANATÓW (UTILITY I FLASHE) ---

            // Średnia liczba rzuconych granatów taktycznych (smoke, molotov, HE) w pojedynczej rundzie.
            [JsonPropertyName("Utility Usage per Round")]
            public string UtilityUsagePerRound { get; set; }

            // Skuteczność użycia granatów (np. czy dym faktycznie spowolnił wroga).
            [JsonPropertyName("Utility Success Rate")]
            public string UtilitySuccessRate { get; set; }

            // Całkowita liczba rzuconych granatów taktycznych.
            [JsonPropertyName("Total Utility Count")]
            public string TotalUtilityCount { get; set; }

            // Całkowita liczba udanych (skutecznych) granatów taktycznych.
            [JsonPropertyName("Total Utility Successes")]
            public string TotalUtilitySuccesses { get; set; }

            // Średnia liczba obrażeń zadanych wrogom w jednej rundzie za pomocą granatów.
            [JsonPropertyName("Utility Damage per Round")]
            public string UtilityDamagePerRound { get; set; }

            // Procent rzuconych granatów ofensywnych, które faktycznie zraniły przeciwnika.
            [JsonPropertyName("Utility Damage Success Rate")]
            public string UtilityDamageSuccessRate { get; set; }

            // Łączna pula obrażeń zadanych od granatów.
            [JsonPropertyName("Total Utility Damage")]
            public string TotalUtilityDamage { get; set; }

            // Średnia liczba rzuconych granatów błyskowych w rundzie.
            [JsonPropertyName("Flashes per Round")]
            public string FlashesPerRound { get; set; }

            // Procent flashbangów, które faktycznie kogoś oślepiły.
            [JsonPropertyName("Flash Success Rate")]
            public string FlashSuccessRate { get; set; }

            // Suma wszystkich rzuconych granatów błyskowych.
            [JsonPropertyName("Total Flash Count")]
            public string TotalFlashCount { get; set; }

            // Suma wszystkich udanych granatów błyskowych.
            [JsonPropertyName("Total Flash Successes")]
            public string TotalFlashSuccesses { get; set; }

            // Średnia liczba przeciwników oślepionych przez Twoje granaty w jednej rundzie.
            [JsonPropertyName("Enemies Flashed per Round")]
            public string EnemiesFlashedPerRound { get; set; }

            // Całkowita historyczna liczba oślepionych graczy przeciwnej drużyny.
            [JsonPropertyName("Total Enemies Flashed")]
            public string TotalEnemiesFlashed { get; set; }
        }

    }
}
