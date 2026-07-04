namespace WorldCup2026.Models;

public class Stadium
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string CountryFlag { get; set; } = string.Empty;
    public int Capacity { get; set; }
    public int MatchesHosted { get; set; }
}
