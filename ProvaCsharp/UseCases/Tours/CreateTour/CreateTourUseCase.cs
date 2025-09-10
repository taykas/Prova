using ProvaCsharp.Models;

namespace ProvaCsharp.UseCases.Tours.CreateTour;

public class CreateTourUseCase(ProvaCscharpDbContext ctx)
{
    public async Task<Result<CreateTourResponse>> Do(CreateTourRequest request)
    {
        var tour = new Tour
        {
            UserID = request.UserID,
            Title = request.Title,
            Description = request.Description
        };

        ctx.Add(tour);
        await ctx.SaveChangesAsync();
        return Result<CreateTourResponse>.Ok(new());
    }
}