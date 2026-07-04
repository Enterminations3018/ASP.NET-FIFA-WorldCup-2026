namespace WorldCup2026.Models;

public class Player
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public string Position { get; set; } = string.Empty;
    public string NationalTeam { get; set; } = string.Empty;
    public string NationalFlag { get; set; } = string.Empty;
    public string Club { get; set; } = string.Empty;
    public int InternationalGoals { get; set; }
    public int WorldCupGoals { get; set; }
    public int PredictedGoals { get; set; }
    public decimal MarketValueM { get; set; }
}
