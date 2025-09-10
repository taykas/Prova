namespace ProvaCsharp.Services.JWT;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using ProvaCsharp.Infrastructure;
using ProvaCsharp.Services.LoginService;

public class JWTService : IJWTServices
{
    public string CreateToken(ProfileToAuth data)
    {
        var jwtSecret = Environment.GetEnvironmentVariable("JWT_SECRET");
        var keyBytes = Encoding.UTF8.GetBytes(jwtSecret);
        var key = new SymmetricSecurityKey(keyBytes);

        var jwt = new JwtSecurityToken(
            claims: [
                new Claim(ClaimTypes.NameIdentifier, data.UserID.ToString()),
                new Claim(ClaimTypes.Name, data.UserName)
            ],
            expires: DateTime.UtcNow.AddHours(2),
            signingCredentials: new SigningCredentials(
                key,
                SecurityAlgorithms.HmacSha256Signature
            )
        );
        var handler = new JwtSecurityTokenHandler();
        return handler.WriteToken(jwt);
    }

}