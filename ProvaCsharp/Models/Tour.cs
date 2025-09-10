namespace ProvaCsharp.Models;

public class Tour
{
    public int TourID { get; set; }
    public int UserID { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public User User { get; set; }
    public int PointID { get; set; }
    public Point Point { get; set; }
    public ICollection<ToursPoint> ToursPoints { get; set; } = [];
    public ICollection<User> Users { get; set; } = [];
    public ICollection<Point> Points { get; set; } = [];
}