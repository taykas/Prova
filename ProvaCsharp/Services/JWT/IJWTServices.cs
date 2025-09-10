
namespace ProvaCsharp.Services.JWT;
using ProvaCsharp.Services.LoginService;

public interface IJWTServices
{
    string CreateToken(LoginService data);
}