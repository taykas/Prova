namespace ProvaCsharp.Models;

public class Passeio
{
    public int PasseioID { get; set; }
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public Ponto Pontos { get; set; }
    public ICollection<Ponto> Pontos { get; set; }
}