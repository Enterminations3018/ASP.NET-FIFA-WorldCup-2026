namespace WorldCup2026.Models;

public class Match
{
    public int Id { get; set; }
    public DateTime MatchDate { get; set; }
    public string Stage { get; set; } = string.Empty; // 小组赛/16 强/8 强/半决赛/决赛
    public string Venue { get; set; } = string.Empty;
    public Team HomeTeam { get; set; } = new();
    public Team AwayTeam { get; set; } = new();
    public int? HomeScore { get; set; }
    public int? AwayScore { get; set; }
    public bool IsFinished { get; set; }
    public string Status { get; set; } = string.Empty; // 未开始/进行中/已结束
}
