using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Models;

public class Link
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;

    public User User { get; set; } = null!;
    //[ForeignKey("User")]
    public int UserId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}