namespace ProvaCsharp.Services.LoginService;

public record LoginService
{
    public required int UserID { get; set; }
    public required string UserName { get; set; }
}