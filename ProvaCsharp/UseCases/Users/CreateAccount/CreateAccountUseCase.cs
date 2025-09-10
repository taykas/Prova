using ProvaCsharp.Models;
namespace ProvaCsharp.UseCases.Users.CreateAccount;

public class CreateAccountUseCase(ProvaCscharpDbContext ctx)
{
    public async Task<Result<CreateAccountResponse>> Do(CreateAccountRequest request)
    {
        var username = await ctx.Users.FindAsync(request.UserName);
        if (username is not null)
            return Result<CreateAccountResponse>.Fail("UserName unavailable");

        var user = new User
        {
            UserName = request.UserName,
            Name = request.Name,
            Password = request.Password
        };

        ctx.Users.Add(user);
        await ctx.SaveChangesAsync();

        return Result<CreateAccountResponse>.Ok(new());
    }
}