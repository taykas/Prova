namespace ProvaCsharp.Models;

public class User
{
    public int UserID { get; set; }
    public string Name { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public Tour Tour { get; set; }
    public ICollection<Tour> Tours { get; set; } = [];
}