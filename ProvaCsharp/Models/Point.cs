namespace ProvaCsharp.Models;

public class Point
{
    public int PointID { get; set; }
    public string Title { get; set; }
    public ICollection<Tour> Tours { get; set; } = [];
}