using System.ComponentModel.DataAnnotations;

namespace Core.Models;

public class User
{
    public int Id { get; set; }
    
    [MaxLength(50)]
    public string Username { get; set; } = string.Empty;
    [MaxLength(255)]
    public string Email { get; set; } = string.Empty;
    [MaxLength(255)]
    public string PasswordHash { get; set; } = string.Empty;
    public int? Age { get; set; }
    [MaxLength(20)]
    public string Role { get; set; } = "User";
    public ICollection<Link>? Links { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}