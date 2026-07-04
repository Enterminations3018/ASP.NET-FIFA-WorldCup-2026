namespace WorldCup2026.Models;

public class PowerRanking
{
    public int Rank { get; set; }
    public string TeamName { get; set; } = string.Empty;
    public string FlagUrl { get; set; } = string.Empty;
    public string Group { get; set; } = string.Empty;
    public int FifaRanking { get; set; }
    public int AttackScore { get; set; }
    public int MidfieldScore { get; set; }
    public int DefenseScore { get; set; }
    public int GoalkeeperScore { get; set; }
    public int TotalScore { get; set; }
    public decimal WinProbability { get; set; }
    public string StarPlayer { get; set; } = string.Empty;
    public string BestFinish { get; set; } = string.Empty;
}
