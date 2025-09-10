namespace ProvaCsharp.Models;

public class User
{
    public int UserID { get; set; }
    public string Nome { get; set; }
    public string NickName { get; set; }
    public string Senha { get; set; }
    public Passeio passeio { get; set; }
    public ICollection<Passseio> Passeios { get; set; }
}