
using ProvaCsharp.Models;
using ProvaCsharp.Services.JWT;
using ProvaCsharp.Services.LoginService;

namespace ProvaCsharp.UseCases.Users.Login;

public class LoginUseCase(
    IJWTServices jwt,
    ProvaCscharpDbContext ctx
)
{
    public async Task<Result<LoginResponse>> Do(LoginRequest request)
    {
        var user = await ctx.Users.FindAsync(request.UserName);

        if (user.Password != request.Password)
            return Result<LoginResponse>.Fail("Login or Password are incorrects");


        var token = jwt.CreateToken(new LoginService
        {
            UserID = user.UserID,
            UserName = user.UserName
        });

        var response = new LoginResponse(token);
        return Result<LoginResponse>.Ok(response);
    }
}