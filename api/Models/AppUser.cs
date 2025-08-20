namespace api.Models;

public class AppUser
{
    public string Id { get; set; } = default!;
    public string Address { get; set; } = default!;
    public string? Email { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;  
}