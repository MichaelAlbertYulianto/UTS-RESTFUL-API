namespace TodoApi.Models;

public class Posts
{
    public long id { get; set; }
    public long user_id { get; set; }
    public string? title { get; set; }
    public string? content { get; set; }
}