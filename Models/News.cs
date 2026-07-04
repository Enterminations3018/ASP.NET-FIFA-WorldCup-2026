namespace WorldCup2026.Models;

public class News
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Summary { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public DateTime PublishDate { get; set; }
    public string ImageUrl { get; set; } = string.Empty;
    public string Source { get; set; } = string.Empty;
}
