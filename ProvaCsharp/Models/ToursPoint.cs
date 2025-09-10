namespace ProvaCsharp.Models;

public class ToursPoint
{
    public int PasseioPontoID { get; set; }
    public string UserName { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public ICollection<Point> Points { get; set; }
}