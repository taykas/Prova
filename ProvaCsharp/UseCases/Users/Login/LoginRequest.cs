namespace ProvaCsharp.UseCases.Users.Login;

public record LoginRequest (
    string UserName,
    string Password
);