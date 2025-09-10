using System.ComponentModel.DataAnnotations;
namespace ProvaCsharp.UseCases.Users.CreateAccount;

public record CreateAccountRequest
{
    [Required]
    public string Name { get; init; }

    [Required]
    public string UserName { get; init; }

    [Required]
    public string Password { get; init; }
}
