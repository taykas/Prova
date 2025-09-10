namespace ProvaCsharp.Models;

/// não sei oq dizer dessa tabela ainda

public class ToursPoint
{
    public int ToursPointID { get; set; }
    public int UserID { get; set; }
    public int TourID { get; set; }
    public int PointID { get; set; }
    public User User { get; set; }
    public Tour Tour { get; set; }
    public Point Point { get; set; }
    public ICollection<Point> Points { get; set; } = new List<Point>();
}