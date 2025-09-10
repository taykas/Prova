namespace ProvaCsharp.Models;

public class Point
{
    public int PointID { get; set; }
    public string Title { get; set; }
    public Tour Tour { get; set; }
    public ICollection<ToursPoint> ToursPoints { get; set; } = [];
}